using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hontashvili_family.BL;
using hontashvili_family.DAL;

namespace hontashvili_family.UI
{
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            InitializeComponent();
            Form_Product_InputLanguageChanged(null, null);

            ProductArrToForm();
            CompanyArrToForm(comboBox_Company, true);
            CompanyArrToForm(comboBox_Filter_Company, false);
            CategoryArrToForm(comboBox_Category, true);
            CategoryArrToForm(comboBox_Filter_Category, false);


        }

        private bool IsContain(string s, char c)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    return true;
                }
            }
            return false;
        }
       

        private void textBox_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ') &&   (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
                e.KeyChar = char.MinValue;
        }
        private void ResetForm()
        {

            label_id.Text = "0";
            textBox_Name.Text = "";
            CompanyArrToForm(comboBox_Company, true);
            CompanyArrToForm(comboBox_Filter_Company, false);
            CategoryArrToForm(comboBox_Category, true);
            CategoryArrToForm(comboBox_Filter_Category, false);
            numericUpDown2.Value = -1;
            numericUpDown1.Value = 0;
            textBox_Name_Filter.Text = "";


            textBox_Name.BackColor = Color.White;
            comboBox_Category.ForeColor = Color.Black;
            comboBox_Company.ForeColor = Color.Black;
        }

        private void myCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
            if (numericUpDown1.Value < 0)
            {
                flag = false;
                numericUpDown1.BackColor = Color.Red;
                MessageBox.Show("The inventory can't be negetive!");
            }
            else
                numericUpDown1.BackColor = Color.White;


            if ((int)comboBox_Company.SelectedValue < 1)
            {
                comboBox_Company.ForeColor = Color.Red;
                flag = false;
            }
            else
                comboBox_Company.ForeColor = Color.Black;

            if ((int)comboBox_Category.SelectedValue < 1)
            {
                comboBox_Category.ForeColor = Color.Red;
                flag = false;
            }
            else
                comboBox_Category.ForeColor = Color.Black;




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

                Product product = FormToProduct();
                if (product.Id == 0)
                {
                    if (product.Insert())
                    {
                        MessageBox.Show("Added successfully");

                        ResetForm();

                    }
                    else
                        MessageBox.Show("Error adding");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (product.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        ProductArrToForm();


                        ResetForm();


                    }
                    else
                        MessageBox.Show("Error updating");
                }
                ProductArrToForm();
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
        
        private void Form_Product_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
            {
                MessageBox.Show("Are you stupid? Swich to English!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ProductToForm(Product product)
        {

            //ממירה את המידע בטנ"מ לקוח לטופס


            if (product != null)
            {
                label_id.Text = product.Id.ToString();
                textBox_Name.Text = product.Name;
                comboBox_Company.SelectedValue = product.Company.Id;
                comboBox_Category.SelectedValue = product.Category.Id;
                numericUpDown1.Value = product.Count;
            }
            else
            {

                ResetForm();

            }
        }
        private Product FormToProduct()
        {
            Product product = new Product();
            product.Name = textBox_Name.Text;
            product.Category = comboBox_Category.SelectedItem as Category;
            product.Company = comboBox_Company.SelectedItem as Company;
            product.Id = int.Parse(label_id.Text);
            product.Count = (int)numericUpDown1.Value;
            return product;
        }
        private void ProductArrToForm()
        {

            //ממירה את הטנ "מ אוסף מוצרים לטופס

            ProductArr productArr = new ProductArr();
            productArr.Fill();
            listBox_Products.DataSource = productArr;
        }

        private void ListBox_Products_DoubleClick(object sender, EventArgs e)
        {
            ResetForm();
            ProductToForm(listBox_Products.SelectedItem as Product);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            ProductToForm(null);
        }

        /** private void Button_delete_Click(object sender, EventArgs e)
        {


            Product product = FormToProduct();
            if (product.Id == 0)

                MessageBox.Show("You need to choose a product");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (product.Delete())
                    {
                        MessageBox.Show("Successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("not deleted!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ProductToForm(null);
                    ProductArrToForm();

                }
            }

        } **/

        //Filter
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }
        private void SetProductsByFilter()
        {

            //מייצרים אוסף של כלל המוצרים

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(textBox_Name_Filter.Text,
            comboBox_Filter_Company.SelectedItem as Company,
            comboBox_Filter_Category.SelectedItem as Category, (int)numericUpDown2.Value, true);

            //מציבים בתיבת הרשימה את אוסף המוצרים

            listBox_Products.DataSource = productArr;
        }

        public void CompanyArrToForm(ComboBox comboBox, bool isMustChoose, Company curCompany = null)
        {
            CompanyArr companyArr = new CompanyArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Company companyDefault = new Company();
            companyDefault.Id = -1;
            if (isMustChoose)
                companyDefault.Name = "Choose a company";
            else
                companyDefault.Name = "All companies";
            companyArr.Add(companyDefault);
            companyArr.Fill();
            comboBox.DataSource = companyArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCompany != null)
                comboBox.SelectedValue = curCompany.Id;
        }

        public void CategoryArrToForm(ComboBox comboBox, bool isMustChoose, Category curCategory = null)
        {
            CategoryArr categoryArr = new CategoryArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Category categoryDefault = new Category();
            categoryDefault.Id = -1;
            if (isMustChoose)
                categoryDefault.Name = "Choose a category";
            else
                categoryDefault.Name = "All categories";
            categoryArr.Add(categoryDefault);
            categoryArr.Fill();
            comboBox.DataSource = categoryArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCategory != null)
                comboBox.SelectedValue = curCategory.Id;
        }
        private void button_AddCompany_Click(object sender, EventArgs e)
        {
            Form_Company form_Company = new Form_Company(comboBox_Company.SelectedItem as Company);
            form_Company.ShowDialog();
            CompanyArrToForm(comboBox_Company, true , form_Company.SelectedCompany);
        }
        private void button_AddCategory_Click(object sender, EventArgs e)
        {
            Form_Category form_Category = new Form_Category(comboBox_Category.SelectedItem as Category);
            form_Category.ShowDialog();
            CategoryArrToForm(comboBox_Category, true, form_Category.SelectedCategory);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Product product = FormToProduct();
            if (product.Id == 0)

                MessageBox.Show("You need to choose a product");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על פריט זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    OrderProductArr orderProductArr = new OrderProductArr();
                    orderProductArr.Fill();

                    if (orderProductArr.DoesProductExist(product))
                    {
                        MessageBox.Show("You can’t delete a product that is related to an order!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                         if (product.Delete())
                         {
                            MessageBox.Show("Successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                         else
                         {
                            MessageBox.Show("not deleted!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    }

                   

                    ProductToForm(null);
                    ProductArrToForm();

                }
            }
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
