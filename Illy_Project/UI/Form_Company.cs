using Illy_Project.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Illy_Project.DAL;


namespace Illy_Project.UI
{
    public partial class Form_Company : Form
    {
        public Company SelectedCompany { get => listBox_Companies.SelectedItem as Company; }

        public Form_Company(Company company = null)
        {
            InitializeComponent();

            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (company != null && company.Id <= 0)
                company = null;

            //טעינת אוסף הישובים לרשימה בטופס
            Form_Company_InputLanguageChanged(null, null);
            CompanyArrToForm(company);
            CompanyToForm(company);
        }


        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        private void textBox_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }
        private bool IsEngLetter(char c)
        {
            return (c >= 97 && c <= 122 || c >= 65 && c <= 90);
        }

        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            if (textBox_Name.Text.Length < 2)
            {
                flag = false;
                textBox_Name.BackColor = Color.Red;
            }
            else
                textBox_Name.BackColor = Color.White;


            return flag;
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Company company = FormToCompany();

                if (company.Id == 0)
                {
                    CompanyArr oldCompanyArr = new CompanyArr();
                    oldCompanyArr.Fill();
                    if (!oldCompanyArr.IsContains(company.Name))
                    {
                        if (company.Insert())
                        {

                            MessageBox.Show("Added successfully");

                            label_id.Text = "0";
                            textBox_Name.Text = "";

                            //עדכון תיבת הרשימה

                            CompanyArrToForm();
                            CompanyArr companyArr = new CompanyArr();
                            companyArr.Fill();
                            company = companyArr.GetCompanyWithMaxId();
                        }
                        else
                            MessageBox.Show("Error adding");

                    }
                    else
                        MessageBox.Show("Already exist");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (company.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        CompanyArrToForm();

                        label_id.Text = "0";
                        textBox_Name.Text = "";


                    }
                    else
                        MessageBox.Show("Error updating");
                }
                CompanyArrToForm(company);
            }





        }
        private void textBox_Name_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            if (textBox.Text.Length < 2)
                textBox.BackColor = Color.Red;
            else
                textBox.BackColor = Color.White;

        }
        private void comboBox_nickname_Leave(object sender, EventArgs e)
        {
            ComboBox comboBox = (sender as ComboBox);
            if (comboBox.Text.Length == 0)
                comboBox.BackColor = Color.Red;
            else
                comboBox.BackColor = Color.White;

        }
        private void Form_Company_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
            {
                MessageBox.Show("Are you stupid? Swich to English!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void CompanyToForm(Company company)
        {

            //ממירה את המידע בטנ"מ לקוח לטופס


            if (company != null)
            {
                label_id.Text = company.Id.ToString();
                textBox_Name.Text = company.Name;

            }
            else
            {

                label_id.Text = "0";
                textBox_Name.Text = "";


            }
        }
        private Company FormToCompany()
        {
            Company company = new Company();
            company.Name = textBox_Name.Text;

            company.Id = int.Parse(label_id.Text);
            return company;
        }
        private void CompanyArrToForm(Company curCompany = null)
        {


            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CompanyArr companyArr = new CompanyArr();
            companyArr.Fill();
            listBox_Companies.DataSource = companyArr;
            listBox_Companies.ValueMember = "Id";
            listBox_Companies.DisplayMember = "Name";

            if (curCompany != null)
                listBox_Companies.SelectedValue = curCompany.Id;

        }

        private void ListBox_Companies_DoubleClick(object sender, EventArgs e)
        {
            CompanyToForm(listBox_Companies.SelectedItem as Company);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            CompanyToForm(null);
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {



            if (label_id.Text == "0")

                MessageBox.Show("You need to choose a company");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    Company company = FormToCompany();
                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות
                        
                    ProductArr productArr = new ProductArr();
                    productArr.Fill();
                    if (productArr.DoesCompanyExist(company))
                        MessageBox.Show("You can’t delete a company that is related to a product");
                    else
                    {
                        if (company.Delete())
                        {
                            MessageBox.Show("Successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("not deleted!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    CompanyToForm(null);
                    CompanyArrToForm();

                }
            }

        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        //private void TextBox_filter_KeyUp(object sender, KeyEventArgs e)
        //{
        //    int id = 0;

        //    //אם המשתמש רשם ערך בשדה המזהה

        //    if (textBox_ID_filter.Text != "")
        //        id = int.Parse(textBox_ID_filter.Text);

        //    //מייצרים אוסף של כלל הלקוחות

        //    CompanyArr companyArr = new CompanyArr();
        //    companyArr.Fill();

        //    //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

        //    companyArr = companyArr.Filter(id, textBox_name_filter.Text);
        //    //מציבים בתיבת הרשימה את אוסף הלקוחות

        //    listBox_Companies.DataSource = companyArr;
        //}
    }
}
