using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Illy_Project.BL;
using Illy_Project.DAL;

namespace Illy_Project.UI
{
    public partial class Form_Client : Form
    {
        public Form_Client()
        {
            InitializeComponent();
            Form_Client_InputLanguageChanged(null, null);

            ClientArrToForm();
            CityArrToForm();
            

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

        private void ResetForm()
        {

            label_id.Text = "0";
            textBox_FirstName.Text = "";
            textBox_Phone.Text = "";
            textBox_LastName.Text = "";
            textBox_Mail.Text = "";
            textBox_FirstName.Text = "";
            textBox_LastName_Filter.Text = "";
           
           
            CityArrToForm();
           
          
            textBox_FirstName.BackColor = Color.White;
            textBox_LastName.BackColor = Color.White;
            textBox_Phone.BackColor = Color.White;
            textBox_Mail.BackColor = Color.White;

            
            comboBox_City.ForeColor = Color.Black;
        }
      
        private void myCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

            if (textBox_FirstName.Text.Length < 2)
            {
                flag = false;
                textBox_FirstName.BackColor = Color.Red;
            }
            else
                textBox_FirstName.BackColor = Color.White;

            if (textBox_LastName.Text.Length < 2)
            {
                flag = false;
                textBox_LastName.BackColor = Color.Red;
            }
            else
                textBox_LastName.BackColor = Color.White;

            if (!(IsContain(textBox_Mail.Text, '@') && IsContain(textBox_Mail.Text, '.')))
            {
                textBox_Mail.BackColor = Color.Red;
                if (flag && textBox_Mail.Text.Length > 0)
                    MessageBox.Show("Please enter a valid mail", "Invalid mail", MessageBoxButtons.OK);
                flag = false;

            }
            else
                textBox_Mail.BackColor = Color.White;

            if (textBox_Phone.Text.Length != 10)
            {
                
                textBox_Phone.BackColor = Color.Red;
                if (flag && textBox_Phone.Text.Length > 0)
                     MessageBox.Show("Please enter a valid phone number", "Invalid phone number", MessageBoxButtons.OK);
                flag = false;
            }
            else
                textBox_Phone.BackColor = Color.White;

            if ((int) comboBox_City.SelectedValue < 1)
            {
                comboBox_City.ForeColor = Color.Red;
                flag = false;
            }
            else
                comboBox_City.ForeColor = Color.Black;




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

                Client client = FormToClient();
                if (client.Id == 0)
                {
                    if (client.Insert())
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

                    if (client.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        ClientArrToForm();


                        ResetForm();

                            
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                ClientArrToForm();
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
        private void textBox_Phone_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            if (textBox.Text.Length != 10)
                textBox.BackColor = Color.Red;
            else
                textBox.BackColor = Color.White;

        }
       
        private void Form_Client_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
            {
                MessageBox.Show("Are you stupid? Swich to English!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ClientToForm(Client client)
        {

            //ממירה את המידע בטנ"מ לקוח לטופס


            if (client != null)
            {
                label_id.Text = client.Id.ToString();
                textBox_FirstName.Text = client.FirstName;
                textBox_LastName.Text = client.LastName;
                textBox_Mail.Text = client.Mail;
                textBox_Phone.Text = client.Phone;
                comboBox_City.SelectedValue = client.City.Id;
            }
            else
            {

                ResetForm();

            }
        }
        private Client FormToClient()
        {
            Client client = new Client();
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Mail = textBox_Mail.Text;
            client.City = comboBox_City.SelectedItem as City;
            client.Phone = textBox_Phone.Text;
            client.Id = int.Parse(label_id.Text);
            return client;
        }
        private void ClientArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
        }

        private void ListBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            ResetForm();
            ClientToForm(listBox_Clients.SelectedItem as Client);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            ClientToForm(null);
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            
            
                Client client = FormToClient();
                if (client.Id == 0)

                    MessageBox.Show("You need to choose a client");
                else
                {

                    //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                    if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                    System.Windows.Forms.DialogResult.Yes)
                    {
                    OrderArr orderArr = new OrderArr();
                    orderArr.Fill();

                    if (orderArr.DoesClientExist(client))
                    {
                        MessageBox.Show("You can’t delete a client that is related to an order!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (client.Delete())
                        {
                            MessageBox.Show("Successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("not deleted!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    ClientToForm(null);
                        ClientArrToForm();

                    }
                }
            
        }

        private void TextBox_filter_KeyUp(object sender, KeyEventArgs e)
        {
            

            //אם המשתמש רשם ערך בשדה המזהה

            
            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(textBox_FirstName_Filter.Text, textBox_LastName_Filter.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;
        }

        public void CityArrToForm( City curCity = null)
        {

            //ממירה את הטנ "מ אוסף ישובים לטופס

            CityArr cityArr = new CityArr();
            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            City cityDefault = new City();
            cityDefault.Id = -1;
            cityDefault.Name = "Choose a City";

            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            cityArr.Add(cityDefault);
            cityArr.Fill();

            comboBox_City.DataSource = cityArr;
            comboBox_City.ValueMember = "Id";
            comboBox_City.DisplayMember = "Name";
              
            if (curCity != null)
                comboBox_City.SelectedValue = curCity.Id;
        }

        private void button_AddCity_Click(object sender, EventArgs e)
        {
            Form_City form_City = new Form_City(comboBox_City.SelectedItem as City);
            form_City.ShowDialog();
            CityArrToForm(form_City.SelectedCity);
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
