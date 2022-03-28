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
    public partial class Form_OrderMonthReport : Form
    {
        public Form_OrderMonthReport()
        {
            InitializeComponent();
            FillListView();
        }
        public void FillListView()
        {
            OrderArr curOrderArr = new OrderArr();
            curOrderArr.Fill();
            Dictionary<string, int> dictionary = curOrderArr.GetDictionary(2022);

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            ListViewItem listViewItem;
            foreach (KeyValuePair<string, int> item in dictionary)
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { item.Key, item.Value.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                listView_Orders.Items.Add(listViewItem);
            }
        }
    }
}
