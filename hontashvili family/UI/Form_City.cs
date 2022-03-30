using hontashvili_family.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hontashvili_family.DAL;


namespace hontashvili_family.UI
{
    public partial class Form_City : Form
    {
        public City SelectedCity { get => listBox_Citys.SelectedItem as City; }

        public Form_City(City city = null)
        {
            InitializeComponent();

            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (city != null && city.Id <= 0)
                city = null;

            //טעינת אוסף הישובים לרשימה בטופס
            Form_City_InputLanguageChanged(null, null);
            CityArrToForm(city);
            CityToForm(city);
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
                City city = FormToCity();
                                
                if (city.Id == 0)
                {
                    CityArr oldCityArr = new CityArr();
                    oldCityArr.Fill();
                    if (!oldCityArr.IsContains(city.Name))
                    {
                        if (city.Insert())
                        {

                            MessageBox.Show("Added successfully");

                            label_id.Text = "0";
                            textBox_Name.Text = "";

                            //עדכון תיבת הרשימה

                            CityArrToForm();
                            CityArr cityArr = new CityArr();
                            cityArr.Fill();
                            city = cityArr.GetCityWithMaxId();
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

                    if (city.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        CityArrToForm();

                        label_id.Text = "0";
                        textBox_Name.Text = "";
                       

                    }
                    else
                        MessageBox.Show("Error updating");
                }
                CityArrToForm(city);
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
        private void Form_City_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
            {
                MessageBox.Show("Are you stupid? Swich to English!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void CityToForm(City city)
        {

            //ממירה את המידע בטנ"מ לקוח לטופס


            if (city != null)
            {
                label_id.Text = city.Id.ToString();
                textBox_Name.Text = city.Name;
              
            }
            else
            {

                label_id.Text = "0";
                textBox_Name.Text = "";
                

            }
        }
        private City FormToCity()
        {
            City city = new City();
            city.Name = textBox_Name.Text;
            
            city.Id = int.Parse(label_id.Text);
            return city;
        }
        private void CityArrToForm(City curCity = null)
        {


            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CityArr cityArr = new CityArr();
            cityArr.Fill();
            listBox_Citys.DataSource = cityArr;
            listBox_Citys.ValueMember = "Id";
            listBox_Citys.DisplayMember = "Name";

            if (curCity != null)
                listBox_Citys.SelectedValue = curCity.Id;

        }

        private void ListBox_Citys_DoubleClick(object sender, EventArgs e)
        {
            CityToForm(listBox_Citys.SelectedItem as City);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            CityToForm(null);
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {


            
            if (label_id.Text == "0")

                MessageBox.Show("You need to choose a city");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    City city = FormToCity();
                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(city))
                        MessageBox.Show("You can’t delete a city that is related to a client");
                    else
                    {
                        if (city.Delete())
                        {
                            MessageBox.Show("Successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("not deleted!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    CityToForm(null);
                    CityArrToForm();

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

        //    CityArr cityArr = new CityArr();
        //    cityArr.Fill();

        //    //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

        //    cityArr = cityArr.Filter(id, textBox_name_filter.Text);
        //    //מציבים בתיבת הרשימה את אוסף הלקוחות

        //    listBox_Citys.DataSource = cityArr;
        //}
    }
}
