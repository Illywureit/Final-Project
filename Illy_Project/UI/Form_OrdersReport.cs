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
    public partial class Form_OrdersReport : Form
    {
        Bitmap m_bitmap;
        private int m_LastColumnSortBy = -1;
        private SortOrder m_LastSortOrder = SortOrder.Ascending;
        public Form_OrdersReport()
        {
            InitializeComponent();
            FillListView();
            ClientArrToForm();
        }
        private void FillListView()
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            //מסננים את אוסף ההזמנות לפי שדות הסינון שרשם המשתמש

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
            if (comboBox_Returned.Text == "Returned")
                returned = true.ToString();
            else if (comboBox_Returned.Text == "Unreturned")
                returned = false.ToString();
            else
                returned = "";

            orderArr = orderArr.Filter(0, comboBox_Client.SelectedItem as Client, from, to, returned);

            Order p;
            ListViewItem listViewItem;
           
            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            listViewOrders.Items.Clear();
            for (int i = 0; i < orderArr.Count; i++)
            {
                p = orderArr[i] as Order;
                string isReturned;
                if (p.Return)
                    isReturned = "Returned";
                else
                    isReturned = "Not Returned";
                    //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.Client.ToString(), p.Date.ToString(),isReturned});
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listViewOrders.Items.Add(listViewItem);
            }
        }       
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            FillListView(); 
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
        private void button_clear_Click(object sender, EventArgs e)
        {
            FillListView();
            ClientArrToForm();
            dateTimePicker_From.Checked = false;
            dateTimePicker_From.Value = DateTime.Today;
            dateTimePicker_To.Checked = false;
            dateTimePicker_To.Value = DateTime.Today;
            comboBox_Returned.Text = "All";
        }
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, 100, 100);
        }

        private void CaptureScreen()
        {

            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות

            int addAboveListView = 100;
            int moveLeft = 20;
            Graphics graphics = listViewOrders.CreateGraphics();
            Size curSize = listViewOrders.Size;
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(listViewOrders.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y - addAboveListView,
            moveLeft, 0, curSize);
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Width = 600; printPreviewDialog1.Height = 800;
            printPreviewDialog1.ShowDialog();
        }
        private void listView_Products_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listViewOrders.ListViewItemSorter = sorter;
            sorter = listViewOrders.ListViewItemSorter as ListViewSorter;
            sorter.ByColumn = e.Column;

            // אם לחצו שוב על אותה עמודה - המיון יהיה בסדר הפוך לקודם

            if (m_LastColumnSortBy == e.Column)
                if (m_LastSortOrder == SortOrder.Ascending)
                    sorter.SortOrder = SortOrder.Descending;
                else
                    sorter.SortOrder = SortOrder.Ascending;

            // אחרת - זוהי עמודה חדשה - המיון יהיה בסדר עולה

            else
                sorter.SortOrder = SortOrder.Ascending;
            listViewOrders.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
