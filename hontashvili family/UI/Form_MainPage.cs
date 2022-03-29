using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hontashvili_family.UI
{
    public partial class Form_MainPage : Form
    {
        public Form_MainPage()
        {
            InitializeComponent();

        }

        private void button_Orders_Click(object sender, EventArgs e)
        {
            Form_Order form_Order = new Form_Order();
            form_Order.ShowDialog();
            
        }

        private void button_Client_Click(object sender, EventArgs e)
        {
            Form_Client form_Client = new Form_Client();
            form_Client.ShowDialog();
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            Form_Product form_Product = new Form_Product();
            form_Product.ShowDialog();
        }

        private void button_ProductReport_Click(object sender, EventArgs e)
        {
            Form_ProductReport form_ProductReport = new Form_ProductReport();
            form_ProductReport.ShowDialog();
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            Form_ReturnItems form_ReturnItems = new Form_ReturnItems();
            form_ReturnItems.ShowDialog();
        }

        private void button_OrderReport_Click(object sender, EventArgs e)
        {
            Form_OrdersReport form_OrdersReport = new Form_OrdersReport();
            form_OrdersReport.ShowDialog();
        }

        private void button_Month_Click(object sender, EventArgs e)
        {
            Form_OrderMonthReport form_OrderMonthReport = new Form_OrderMonthReport();
            form_OrderMonthReport.ShowDialog();
        }
    }
    
}
