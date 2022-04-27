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
    public partial class Form_Category : Form
    {
        public Category SelectedCategory { get => listBox_Categories.SelectedItem as Category; }

        public Form_Category(Category category = null)
        {
            InitializeComponent();

            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (category != null && category.Id <= 0)
                category = null;

            //טעינת אוסף הישובים לרשימה בטופס
            Form_Category_InputLanguageChanged(null, null);
            CategoryArrToForm(category);
            CategoryToForm(category);
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
                Category category = FormToCategory();

                if (category.Id == 0)
                {
                    CategoryArr oldCategoryArr = new CategoryArr();
                    oldCategoryArr.Fill();
                    if (!oldCategoryArr.IsContains(category.Name))
                    {
                        if (category.Insert())
                        {

                            MessageBox.Show("Added successfully");

                            label_id.Text = "0";
                            textBox_Name.Text = "";

                            //עדכון תיבת הרשימה

                            CategoryArrToForm();
                            CategoryArr categoryArr = new CategoryArr();
                            categoryArr.Fill();
                            category = categoryArr.GetCategoryWithMaxId();
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

                    if (category.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        CategoryArrToForm();

                        label_id.Text = "0";
                        textBox_Name.Text = "";


                    }
                    else
                        MessageBox.Show("Error updating");
                }
                CategoryArrToForm(category);
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
        private void Form_Category_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
            {
                MessageBox.Show("Are you stupid? Swich to English!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void CategoryToForm(Category category)
        {

            //ממירה את המידע בטנ"מ לקוח לטופס


            if (category != null)
            {
                label_id.Text = category.Id.ToString();
                textBox_Name.Text = category.Name;

            }
            else
            {

                label_id.Text = "0";
                textBox_Name.Text = "";


            }
        }
        private Category FormToCategory()
        {
            Category category = new Category();
            category.Name = textBox_Name.Text;

            category.Id = int.Parse(label_id.Text);
            return category;
        }
        private void CategoryArrToForm(Category curCategory = null)
        {


            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CategoryArr categoryArr = new CategoryArr();
            categoryArr.Fill();
            listBox_Categories.DataSource = categoryArr;
            listBox_Categories.ValueMember = "Id";
            listBox_Categories.DisplayMember = "Name";

            if (curCategory != null)
                listBox_Categories.SelectedValue = curCategory.Id;

        }

        private void ListBox_Categories_DoubleClick(object sender, EventArgs e)
        {
            CategoryToForm(listBox_Categories.SelectedItem as Category);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            CategoryToForm(null);
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {



            if (label_id.Text == "0")

                MessageBox.Show("You need to choose a category");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    Category category = FormToCategory();
                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ProductArr productArr = new ProductArr();
                    productArr.Fill();
                    if (productArr.DoesCategoryExist(category))
                        MessageBox.Show("You can’t delete a category that is related to a product");
                    else
                    {
                        if (category.Delete())
                        {
                            MessageBox.Show("Successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("not deleted!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    CategoryToForm(null);
                    CategoryArrToForm();

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

        //    CategoryArr categoryArr = new CategoryArr();
        //    categoryArr.Fill();

        //    //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

        //    categoryArr = categoryArr.Filter(id, textBox_name_filter.Text);
        //    //מציבים בתיבת הרשימה את אוסף הלקוחות

        //    listBox_Companies.DataSource = categoryArr;
        //}
    }
}
