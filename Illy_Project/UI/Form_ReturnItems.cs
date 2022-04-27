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
    public partial class Form_ReturnItems : Form
    {
        public Form_ReturnItems()
        {
            InitializeComponent();
            
            Form_Order_InputLanguageChanged(null, null);

            OrderArrToForm();
            ClientArrToForm();
          
          
        }


        private void ResetForm()
        {

            label_ChosenId.Text = "";
            label_ChosenDate.Text = "";
            label1_ChosenClient.Text = "";
            

            dateTimePicker_From.Value = DateTime.Today;
            dateTimePicker_To.Value = DateTime.Today;
            dateTimePicker_From.Checked = false;
            dateTimePicker_To.Checked = false;
            listBox_ProductsInOrder.DataSource = null;
            listBox_ProductsInOrderCount.Items.Clear();
         


            ClientArrToForm();
            OrderArrToForm();



        }
        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            

            if (listBox_Orders.SelectedIndex == -1)
            {

                if (flag)
                    MessageBox.Show("Please select an order from the list!", "Coose an Order", MessageBoxButtons.OK);

                flag = false;
            }

            if ((listBox_Orders.SelectedItem as Order).Return)
            {

                if (flag)
                    MessageBox.Show("You can not return an order that has already been returned!", "Coose an Order", MessageBoxButtons.OK);

                flag = false;
            }


            return flag;
        }
        private void Form_Order_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
            {
                MessageBox.Show("Are you stupid? Swich to English!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
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

            orderArr = orderArr.Filter(id, comboBox_Client.SelectedItem as Client, from, to, false.ToString());
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Orders.DataSource = orderArr;
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
        public void ClientArrToForm(Client curClient = null)
        {
            ClientArr clientArr = new ClientArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Client clientDefault = new Client();
            clientDefault.Id = -1;
           
           
            
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

        private void OrderArrToForm()
        {

            //ממירה את הטנ "מ אוסף מוצרים לטופס

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();
            listBox_Orders.DataSource = orderArr;

        }

        private void ProductArrCountToForm(OrderProductArr curOrderproductArr)
        {
            listBox_ProductsInOrderCount.Items.Clear();
            for (int i = 0; i < curOrderproductArr.Count; i++)
            {
                listBox_ProductsInOrderCount.Items.Add(
                (curOrderproductArr[i] as OrderProduct).Count);
            }
            //כדי לסמן את השורה הראשונה ישר בהתחלה )אם יש כזאת(

            if (listBox_ProductsInOrderCount.Items.Count > 0)
                listBox_ProductsInOrderCount.SelectedIndex = 0;
        }

        private void ListBox_Orders_DoubleClick(object sender, EventArgs e)
        {
            Order order = listBox_Orders.SelectedItem as Order;

            //הצגת חלקי ההזמנה בלשוניות השונות
            //לשונית פרטי הזמנה

            OrderToForm(order);

           

            //לשונית פריטים להזמנה
            //תיבת רשימה - פריטים בהזמנה
            //מוצאים את הפריטים בהזמנה הנוכחית
            //כל הזוגות פריט-הזמנה

            OrderProductArr orderProductArr = new OrderProductArr();
            orderProductArr.Fill();

            //סינון לפי הזמנה נוכחית

            orderProductArr = orderProductArr.FilterByOrder(order);

            //רק אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            ProductArr productArrInOrder = orderProductArr.GetProductArr();
            ProductArrToForm(listBox_ProductsInOrder, productArrInOrder);
         

           
            ProductArrCountToForm(orderProductArr);
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

        private void OrderToForm(Order order)
        {

            //ממירה את המידע בטנ"מ לקוח לטופס


            if (order != null)
            {
                label_ChosenId.Text = order.Id.ToString();                
                label_ChosenDate.Text = order.Date.ToShortDateString();
                label1_ChosenClient.Text = order.Client.FirstName + " " + order.Client.LastName;


            }
            else
            {

                ResetForm();

            }
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Order order = new Order();
                order = listBox_Orders.SelectedItem as Order;
                order.Return = true;

                OrderProductArr orderProductArr = new OrderProductArr();
                orderProductArr.Fill();
                OrderProductArr curOrderProductArr = orderProductArr.FilterByOrder(order);

                for (int i = 0; i < curOrderProductArr.Count; i++)
                {
                    OrderProduct orderProduct = curOrderProductArr[i] as OrderProduct;
                    Product product = orderProduct.Product;
                    product.Count += orderProduct.Count;
                    product.UpdateCount();
                }
                if (order.Update())
                    MessageBox.Show("Successfully returned");
                else
                    MessageBox.Show("Eror returning");

                OrderArrToForm();
                ResetForm();
            }
                
        }
      
     
       
        private void listBox_ProductsInOrderCount_Click(object sender, EventArgs e)
        {
            listBox_ProductsInOrder.SelectedIndex = listBox_ProductsInOrderCount.SelectedIndex;
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        /* private void button_Return_Click(object sender, EventArgs e)
{
    if (listBox_ProductsInOrderCount.SelectedIndex >= 0)
    {
        // חיסור לכמות של פריט-הזמנה

        //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה

        int k = listBox_ProductsInOrderCount.SelectedIndex;
        if ((int)listBox_ProductsInOrderCount.Items[k] >= 1)
        {

            //הוספה להמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
            ProductArr productArr = listBox_ProductsInOrder.DataSource as ProductArr;
            Product product = listBox_ProductsInOrder.SelectedItem as Product;
            product.Count += (int)listBox_ProductsInOrderCount.Items[k];
            listBox_ProductsInOrderCount.Items[k] = 0;
            productArr.UpdateProduct(product);
            ProductArrToForm(listBox_ProductsInOrder, productArr);
        }



    }
    Product curProduct = listBox_ProductsInOrder.SelectedItem as Product;
    Order order = listBox_Orders.SelectedItem as Order;
    OrderProductArr orderProductArr = new OrderProductArr();
    orderProductArr.Fill();
    OrderProduct orderProduct = orderProductArr.GetOrderProduct(order, curProduct);
    orderProduct.Returned = true;


} */

    }
       

    
}
