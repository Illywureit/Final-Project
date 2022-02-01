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
    public partial class Form_Order : Form
    {
        public Form_Order()
        {
            InitializeComponent();
            Form_Order_InputLanguageChanged(null, null);

            OrderArrToForm();
            ClientArrToForm(false);
            ClientArrToForm(true);
            ProductArrToForm(listBox_PotentialsProducts);
            CompanyArrToForm(comboBox_Filter_Company, false);
            CategoryArrToForm(comboBox_Filter_Category, false);




        }



        private void ResetForm()
        {

            label_Id.Text = "0";
            textBox_Comment.Text = "";
            label_ChosenClient.Text = "None Chosen";
            label_chosenFirst.Text = "";
            label_ChosenLast.Text = "";
            label_chosenMail.Text = "";
            label_chosenPhone.Text = "";
            label_chosenCity.Text = "";
            dateTimePicker_Date.Value = DateTime.Today;
            dateTimePicker_Date.Checked = false;
            listBox_ProductsInOrder.DataSource = null;
            labelCat.Text = "";
            labelCom.Text = "";
            labelN.Text = "";


            ClientArrToForm(false);
            ClientArrToForm(true);



        }

        private void myCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private bool IsEngLetter(char c)
        {
            return (c >= 97 && c <= 122 || c >= 65 && c <= 90);
        }

        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            if (!dateTimePicker_Date.Checked)
            {

                dateTimePicker_Date.BackColor = Color.Red;
                if (flag)
                    MessageBox.Show("Please select a Date", "Coose a Date", MessageBoxButtons.OK);
                flag = false;
            }
            else
                dateTimePicker_Date.BackColor = Color.White;


            if (listBox_Clients.SelectedIndex ==-1 || label_ChosenClient.Text == "None chosen")
            {
                label_ChosenClient.ForeColor = Color.Red;
                if (flag)
                    MessageBox.Show("Please select a client from the list", "Coose a client", MessageBoxButtons.OK);

                flag = false;
            }
            else
                label_ChosenClient.ForeColor = Color.Black;

            if (listBox_ProductsInOrder.Items.Count == 0)
            {

                if (flag)
                    MessageBox.Show("Please select a product from the list", "Coose a client", MessageBoxButtons.OK);

                flag = false;
            }







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

                Order order = FormToOrder();

                //הוספת ההזמנה למסד הנתונים

                OrderProductArr orderProductArr_New;
                if (order.Id == 0)
                {
                    if (order.Insert())
                    {

                        //מוצאים את ההזמנה החדשה - לפי המזהה הגבוה ביותר

                        OrderArr orderArr = new OrderArr();
                        orderArr.Fill();
                        order = orderArr.GetOrderWithMaxId();
                        orderProductArr_New = FormToOrderProductArr(order);

                        //מוסיפים את הפריטים החדשים להזמנה

                        if (orderProductArr_New.Insert())
                            MessageBox.Show("Successfully saved");
                        else
                            MessageBox.Show("Error in insert");
                        OrderArrToForm();
                        ResetForm();
                        //לא לשכוח כאן לנקות את הטופס ולטעון מחדש ערכים לתיבת הרשימה של ההזמנות

                    }
                    else
                        MessageBox.Show("Error in insert");
                }
            }





        }

        private void Form_Order_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
            {
                MessageBox.Show("Are you stupid? Swich to English!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void OrderToForm(Order order)
        {

            //ממירה את המידע בטנ"מ לקוח לטופס


            if (order != null)
            {
                label_Id.Text = order.Id.ToString();
                textBox_Comment.Text = order.Comment;
                dateTimePicker_Date.Value = order.Date;
                label_ChosenClient.Text = order.Client.FirstName + " " + order.Client.LastName;
               
                
            }
            else
            {

                ResetForm();

            }
        }
        private Order FormToOrder()
        {
            Order order = new Order();
            order.Date = dateTimePicker_Date.Value;
            order.Comment = textBox_Comment.Text;
            order.Client = listBox_Clients.SelectedItem as Client;
            order.Id = int.Parse(label_Id.Text);
            return order;
        }
        private void OrderArrToForm()
        {

            //ממירה את הטנ "מ אוסף מוצרים לטופס

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();
            listBox_Orders.DataSource = orderArr;
        }

        private void ClientToForm(Client client)
        {

            //ממירה את המידע בטנ"מ לקוח לטופס


            if (client != null)
            {
                label_ChosenLast.Text = client.LastName;
                label_chosenFirst.Text = client.FirstName;
                label_chosenMail.Text = client.Mail;
                label_chosenPhone.Text = client.Phone;
                label_chosenCity.Text = client.City.Name;

            }
            else
            {

                ResetForm();

            }
        }


        private void ListBox_Orders_DoubleClick(object sender, EventArgs e)
        {
            //ResetForm();
            OrderToForm(listBox_Orders.SelectedItem as Order);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            OrderToForm(null);
        }

        /** private void Button_delete_Click(object sender, EventArgs e)
        {


            Order order = FormToOrder();
            if (order.Id == 0)

                MessageBox.Show("You need to choose a order");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (order.Delete())
                    {
                        MessageBox.Show("Successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("not deleted!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    OrderToForm(null);
                    OrderArrToForm();

                }
            }

        } **/

        //Filter
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetOrderByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            SetOrderByFilter();
        }
        private void SetOrderByFilter()
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_Id.Text != "")
                id = int.Parse(textBox_Id.Text);

            //מייצרים אוסף של כלל הלקוחות

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            DateTime from;
            DateTime to;
            if (dateTimePicker_From.Checked)
                from = dateTimePicker_From.Value;
            else
                from = DateTime.MinValue;

            if (dateTimePicker_To.Checked)
                to = dateTimePicker_To.Value;
            else
                to = DateTime.MinValue;

            orderArr = orderArr.Filter(id, comboBox_Client.SelectedItem as Client, from, to);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Orders.DataSource = orderArr;
        }

        public void ClientArrToForm(bool isMustChoose, Client curClient = null)
        {
            ClientArr clientArr = new ClientArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Client clientDefault = new Client();
            clientDefault.Id = -1;
            if (isMustChoose)
            {
                clientArr.Fill();
                listBox_Clients.DataSource = clientArr;

            }
            else
            {
                clientDefault.FirstName = "All clients";
                clientArr.Add(clientDefault);
                clientArr.Fill();
                comboBox_Client.DataSource = clientArr;
                comboBox_Client.ValueMember = "Id";
                comboBox_Client.DisplayMember = "";
                //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

                if (curClient != null)
                    comboBox_Client.SelectedValue = curClient.Id;
            }



        }

        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            //ResetForm();
            ClientToForm(listBox_Clients.SelectedItem as Client);
            label_ChosenClient.Text = (listBox_Clients.SelectedItem as Client).FirstName + " " + (listBox_Clients.SelectedItem as Client).LastName;
        }
        private void TextBox_Client_filter_KeyUp(object sender, KeyEventArgs e)
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

        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To)
        {
            ProductArr arrList = null;

            //מוצאים את הפריט הנבחר

            object selectedItem = listBox_From.SelectedItem;

            //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
            //אם כבר יש פריטים ברשימת הפוטנציאליים

            if (listBox_To.DataSource != null)
                arrList = listBox_To.DataSource as ProductArr;
            else
                arrList = new ProductArr();
            arrList.Add(selectedItem);
            ProductArrToForm(listBox_To, arrList);
        }
        private void ProductArrToForm(ListBox listBox, ProductArr productArr = null)
        {

            //מקבלת אוסף פריטים ותיבת רשימה לפריטים ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;
            if (productArr == null)
            {
                productArr = new ProductArr();
                productArr.Fill();
            }
            listBox.DataSource = productArr;
        }
        private OrderProductArr FormToOrderProductArr(Order curOrder)
        {

            // יצירת אוסף המוצרים להזמנה מהטופס
            // מייצרים זוגות של הזמנה-מוצר , ההזמנה - תמיד אותה הזמנה )הרי מדובר על הזמנה אחת(, המוצר - מגיע מרשימת המוצרים שנבחרו
            OrderProductArr orderProductArr = new OrderProductArr();
            // יצירת אוסף הזוגות הזמנה -מוצר 
            OrderProduct orderProduct;

            //סורקים את כל הערכים בתיבת הרשימה של המוצרים שנבחרו להזמנה
            for (int i = 0; i < listBox_ProductsInOrder.Items.Count; i++)
            {
                orderProduct = new OrderProduct();

                //ההזמנה הנוכחית היא ההזמנה לכל הזוגות באוסף

                orderProduct.Order = curOrder;

                //מוצר נוכחי לזוג הזמנה-מוצר

                orderProduct.Product = listBox_ProductsInOrder.Items[i] as Product;

                //הוספת הזוג הזמנה -מוצר לאוסף

                orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }

        private void listBox_PotentialsProducts_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listBox_PotentialsProducts, listBox_ProductsInOrder);
        }

        private void textBox_ProductFilter_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductByFilter();
        }
        private void comboBoxProductFilter_TextChanged(object sender, EventArgs e)
        {
            SetProductByFilter();
        }
        private void SetProductByFilter()
        {

            //מייצרים אוסף של כלל המוצרים

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(textBox_Name_Filter.Text,
            comboBox_Filter_Company.SelectedItem as Company,
            comboBox_Filter_Category.SelectedItem as Category);

            //מציבים בתיבת הרשימה את אוסף המוצרים
            listBox_PotentialsProducts.DataSource = productArr;
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

        private void ProductToForm(Product product)
        {

            //ממירה את המידע בטנ"מ לקוח לטופס


            if (product != null)
            {
                labelN.Text = product.Name;
                labelCom.Text = product.Company.Name;
                labelCat.Text = product.Category.Name;
            }
            else
            {

                ResetForm();

            }
        }

        private void ListBox_Products_Click(object sender, EventArgs e)
        {
            
            ProductToForm(listBox_PotentialsProducts.SelectedItem as Product);
        }
    }
}
