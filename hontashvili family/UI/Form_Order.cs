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
            label_ChosenClient.ForeColor = Color.Black;
            label_chosenFirst.Text = "";
            label_ChosenLast.Text = "";
            label_chosenMail.Text = "";
            label_chosenPhone.Text = "";
            label_Filter_Name.Text = "";
            label_chosenCity.Text = "";
            comboBox_Returned.Text = "";
            textBox_Id.Text = "";
            dateTimePicker_Date.Checked = false;
            dateTimePicker_From.Checked = false;
            dateTimePicker_To.Checked = false;
            dateTimePicker_Date.Value = DateTime.Today;
            dateTimePicker_From.Value = DateTime.Today;
            dateTimePicker_To.Value = DateTime.Today;
            numericUpDown2.Value = 0;
            checkBox_Return.Checked = false;    

            listBox_ProductsInOrder.DataSource = null;
            listBox_ProductsInOrderCount.Items.Clear();
            labelCat.Text = "";
            labelCom.Text = "";
            labelN.Text = "";
            label_ChosenQuantity.Text = "";
            CategoryArrToForm(comboBox_Filter_Category, false);
            CompanyArrToForm(comboBox_Filter_Company, false);
            ProductArrToForm(listBox_PotentialsProducts);
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


            if (listBox_Clients.SelectedIndex == -1 || label_ChosenClient.Text == "None chosen")
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
            if ((listBox_Orders.SelectedItem as Order).Return && label_Id.Text != "0")
            {

                if (flag)
                    MessageBox.Show("You can not change an order that has already been returned!", "Coose an Order", MessageBoxButtons.OK);

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
                order.Return = false;
                
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
                        //מעדכנים את מלאי הפריטים שהוזמנו

                        (listBox_ProductsInOrder.DataSource as ProductArr).UpdateCount();

                        //מוסיפים את הפריטים החדשים להזמנה

                        if (orderProductArr_New.Insert())
                            MessageBox.Show("Successfully saved");
                        else
                            MessageBox.Show("Error in insert");
                        OrderArrToForm();
                        ResetForm();
                        //לא לשכוח כאן לנקות את הטופס ולטעון מחדש ערכים לתיבת הרשימה של ההזמנות

                    }

                }
                else
                {
                    if (order.Update())
                    {

                        //מוחקים את הפריטים הקודמים של ההזמנה
                        //אוסף כלל הזוגות - הזמנה-פריט

                        OrderProductArr orderProductArr_Old = new OrderProductArr();
                        orderProductArr_Old.Fill();

                        //סינון לפי ההזמנה הנוכחית

                        orderProductArr_Old = orderProductArr_Old.FilterByOrder(order);

                        //מחיקת כל הפריטים באוסף ההזמנה-פריט של ההזמנה הנוכחית

                        orderProductArr_Old.Delete();

                        //מוסיפים את הפריטים לפי העדכני להזמנה

                        orderProductArr_New = FormToOrderProductArr(order);
                        orderProductArr_New.Insert();
                        //מעדכנים את מלאי הפריטים, אלו שהוזמנו ואלו שבפוטנציאל

                        (listBox_ProductsInOrder.DataSource as ProductArr).UpdateCount();
                        (listBox_PotentialsProducts.DataSource as ProductArr).UpdateCount();
                        MessageBox.Show("Updated successfully");
                        OrderArrToForm();


                        ResetForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {

            
            Order order = FormToOrder();
            



            if (order.Id == 0)
                MessageBox.Show("You need to choose an order!");
            else
            {
               
                if (order.Return)
                {
                    //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                    if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                    System.Windows.Forms.DialogResult.Yes)
                    {
                        OrderProductArr orderProductArr = new OrderProductArr();
                        orderProductArr.Fill();
                        orderProductArr = orderProductArr.FilterByOrder(order);
                        if (order.Delete())
                        {
                            MessageBox.Show("Successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            orderProductArr.Delete();
                        }
                        else
                        {
                            MessageBox.Show("not deleted!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        OrderToForm(null);
                        OrderArrToForm();

                    }
                }
                else
                {
                    MessageBox.Show("You can't delete an order before returning it!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                checkBox_Return.Checked = order.Return;

            }
            else
            {

                ResetForm();

            }
        }
        private Order FormToOrder()
        {
            Order order = new Order();
            order.Id = int.Parse(label_Id.Text);
            order.Date = dateTimePicker_Date.Value;
            order.Comment = textBox_Comment.Text;
            order.Client = listBox_Clients.SelectedItem as Client;
            order.Return = checkBox_Return.Checked;
            
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
            Order order = listBox_Orders.SelectedItem as Order;

            //הצגת חלקי ההזמנה בלשוניות השונות
            //לשונית פרטי הזמנה

            OrderToForm(order);

            ClientToForm(order.Client);
            listBox_Clients.SelectedValue = order.Client.Id;

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
            //תיבת רשימה - פריטים פוטנציאלים
            //כל הפריטים - פחות אלו שכבר נבחרו

            ProductArr productArrNotInOrder = new ProductArr();
            productArrNotInOrder.Fill();

            //הורדת הפריטים שכבר קיימים בהזמנה

            productArrNotInOrder.Remove(productArrInOrder);
            ProductArrToForm(listBox_PotentialsProducts, productArrNotInOrder);
            ProductArrCountToForm(orderProductArr);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            OrderToForm(null);
        }

      

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

            string returned;
            if (comboBox_Returned.Text == "True")
                returned = true.ToString();
            else if (comboBox_Returned.Text == "False")
                returned = false.ToString();
            else
                returned = "";

            orderArr = orderArr.Filter(id, comboBox_Client.SelectedItem as Client, from, to, returned);
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
                listBox_Clients.ValueMember = "ID";
                listBox_Clients.DisplayMember = "";
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

        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To, bool isToOrder)
        {
            ProductArr arrList = null;

            //מוצאים את הפריט הנבחר

            Product selectedItem = listBox_From.SelectedItem as Product;
            //עדכון הכמות במלאי של הפריט
            if (isToOrder)
            //ההעברה היא אל הרשימה של הפריטים בהזמנה
            {
                selectedItem.Count--;
                listBox_ProductsInOrderCount.Items.Add(1);
            }
            else
            {
                selectedItem.Count += (int)listBox_ProductsInOrderCount.SelectedItem;
                listBox_ProductsInOrderCount.Items.RemoveAt(listBox_ProductsInOrderCount.SelectedIndex);
            }
            //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
            //אם כבר יש פריטים ברשימת הפוטנציאליים

            if (listBox_To.DataSource != null)
                arrList = listBox_To.DataSource as ProductArr;
            else
                arrList = new ProductArr();
            arrList.Add(selectedItem);
            ProductArrToForm(listBox_To, arrList);
            ///הסרת הפריט הנבחר מרשימת הפריטים הנבחרים

            arrList = listBox_From.DataSource as ProductArr;
            arrList.Remove(selectedItem);
            ProductArrToForm(listBox_From, arrList);
            //בסוף הפעולה
            //אם זאת הוספה לתיבת המוצרים בהזמנה - סימון שתי השורה האחרונה בה וגם בתיבת הרשימה של הכמויות

            if (isToOrder)
            {
                int k = listBox_To.Items.Count - 1;
                listBox_To.SelectedIndex = k;
                listBox_ProductsInOrderCount.SelectedIndex = k;
            }
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
                //כמות מוצר נוכחי לזוג הזמנה-מוצר
                orderProduct.Count = (int)listBox_ProductsInOrderCount.Items[i];
                //הוספת הזוג הזמנה -מוצר לאוסף
               


                orderProductArr.Add(orderProduct);
            }

            return orderProductArr;
        }

        private void listBox_PotentialsProducts_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listBox_PotentialsProducts, listBox_ProductsInOrder, true);
        }
        private void listBox_ProductsInOrder_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listBox_ProductsInOrder, listBox_PotentialsProducts, false);
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
            comboBox_Filter_Category.SelectedItem as Category, (int)numericUpDown2.Value, false);



            if (listBox_ProductsInOrder.DataSource != null)
                productArr.Remove(listBox_ProductsInOrder.DataSource as ProductArr);
            //מציבים בתיבת הרשימה
            ProductArrToForm(listBox_PotentialsProducts, productArr);
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
                label_ChosenQuantity.Text = product.Count.ToString();
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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SetProductByFilter();
        }

        private void listBox_ProductsInOrder_Click(object sender, EventArgs e)
        {
            listBox_ProductsInOrderCount.SelectedIndex = listBox_ProductsInOrder.SelectedIndex;
        }
        private void listBox_ProductsInOrderCount_Click(object sender, EventArgs e)
        {
            listBox_ProductsInOrder.SelectedIndex = listBox_ProductsInOrderCount.SelectedIndex;
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {

            //הגדלת הכמות של המוצר בהזמנה באחד
            //בדיקה שמסומנת השורה של הכמויות

            if (listBox_ProductsInOrderCount.SelectedIndex >= 0)
                if ((listBox_ProductsInOrder.SelectedItem as Product).Count > 0)
                {
                    // הוספה לכמות של פריט-הזמנה

                    //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה

                    int k = listBox_ProductsInOrderCount.SelectedIndex;
                    listBox_ProductsInOrderCount.Items[k] = (int)listBox_ProductsInOrderCount.Items[k] + 1;

                    //הורדה מהמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
                    ProductArr productArr = listBox_ProductsInOrder.DataSource as ProductArr;
                    Product product = listBox_ProductsInOrder.SelectedItem as Product;
                    product.Count--;
                    productArr.UpdateProduct(product);
                    ProductArrToForm(listBox_ProductsInOrder, productArr);
                }
                //אם לא הודעה מתאימה
                else
                    MessageBox.Show("There are no more items left", "out of stock", MessageBoxButtons.OK);
        }
        private void button_Minus_Click(object sender, EventArgs e)
        {
            //הקטנת הכמות של המוצר בהזמנה באחד
            //בדיקה שמסומנת השורה של הכמויות

            if (listBox_ProductsInOrderCount.SelectedIndex >= 0)
            {
                // חיסור לכמות של פריט-הזמנה

                //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה

                int k = listBox_ProductsInOrderCount.SelectedIndex;
                if ((int)listBox_ProductsInOrderCount.Items[k] > 1)
                {
                    listBox_ProductsInOrderCount.Items[k] = (int)listBox_ProductsInOrderCount.Items[k] - 1;
                    //הוספה להמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
                    ProductArr productArr = listBox_ProductsInOrder.DataSource as ProductArr;
                    Product product = listBox_ProductsInOrder.SelectedItem as Product;
                    product.Count++;
                    productArr.UpdateProduct(product);
                    ProductArrToForm(listBox_ProductsInOrder, productArr);
                }

                else
                    MoveSelectedItemBetweenListBox(listBox_ProductsInOrder, listBox_PotentialsProducts, false);

            }

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

        private void button_Home_Click(object sender, EventArgs e)
        {
            //Form_MainPage form_mainPage = new Form_MainPage();
            // form_mainPage.Show();
            this.Hide();
        }
    }



}











