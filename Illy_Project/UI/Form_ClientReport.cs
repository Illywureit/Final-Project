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
    public partial class Form_ClientReport : Form
    {
        Bitmap m_bitmap;
        private int m_LastColumnSortBy = -1;
        private SortOrder m_LastSortOrder = SortOrder.Ascending;
        public Form_ClientReport()
        { 
            InitializeComponent();
            FillListView();
         
        }
        private void FillListView()
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            ClientArr ClientArr = new ClientArr();
            ClientArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            ClientArr = ClientArr.Filter(textBox_FirstName_Filter.Text,
            textBox_LastName_Filter.Text);

            Client p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            listViewClients.Items.Clear();
            for (int i = 0; i < ClientArr.Count; i++)
            {
                p = ClientArr[i] as Client;

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.FirstName, p.LastName, p.Phone, p.Mail, p.City.Name });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listViewClients.Items.Add(listViewItem);
            }
        }

        private void textBox_ClientFilter_KeyUp(object sender, KeyEventArgs e)
        {
            FillListView();
        }
       
       

        private void button_clear_Click(object sender, EventArgs e)
        {
            FillListView();
           
            textBox_FirstName_Filter.Text = "";
            textBox_LastName_Filter.Text = "";
          
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
            Graphics graphics = listViewClients.CreateGraphics();
            Size curSize = listViewClients.Size;
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(listViewClients.Location);
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
        private void listView_Clients_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listViewClients.ListViewItemSorter = sorter;
            sorter = listViewClients.ListViewItemSorter as ListViewSorter;
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
            listViewClients.Sort();

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
