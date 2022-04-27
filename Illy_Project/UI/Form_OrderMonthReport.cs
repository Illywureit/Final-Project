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
    public partial class Form_OrderMonthReport : Form
    {
        Bitmap m_bitmap;
        public Form_OrderMonthReport()
        {
            InitializeComponent();
            FillListView(2022);
        }
        public void FillListView(int year)
        {
            OrderArr curOrderArr = new OrderArr();
            curOrderArr.Fill();
            Dictionary<string, int> dictionary = curOrderArr.GetDictionary(year);

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            ListViewItem listViewItem;
            foreach (KeyValuePair<string, int> item in dictionary)
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { item.Key, item.Value.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                listViewOrders.Items.Add(listViewItem);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listViewOrders.Items.Clear();
            FillListView((int)numericUpDown1.Value);
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

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
