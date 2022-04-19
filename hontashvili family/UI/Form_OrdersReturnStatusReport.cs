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
using System.Windows.Forms.DataVisualization.Charting;

namespace hontashvili_family.UI
{
    public partial class Form_OrdersReturnStatusReport : Form
    {
        public Form_OrdersReturnStatusReport()
        {
            InitializeComponent();
            DataToChart();
            ClientArrToForm();
           
        }
        public void DataToChart()
        {

            //פלטת הצבעים - אפשר גם להגדיר מראש במאפיינים

            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart1.Titles.Clear();
            chart1.Titles.Add("Return status of orders");
            OrderArr curOrderArr = new OrderArr();
            curOrderArr.Fill();

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

            
            curOrderArr = curOrderArr.Filter(0, comboBox_Client.SelectedItem as Client, from, to,"");




            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2

            Series series1 = new Series("Return status of orders");

            //סוג הגרף

            series1.ChartType = SeriesChartType.Pie;

            //המידע שיוצג לכל רכיב ערך בגרף - 3


            series1.Label = "#VALX [#VAL = #PERCENT{P0}]";
           // series1.

            series1.Points.AddXY("Number of returned orders ", curOrderArr.GetNumberOfReturned());
            series1.Points.AddXY("Number of unreturned orders", (curOrderArr.Count - curOrderArr.GetNumberOfReturned()));
            //מחיקת סדרות קיימות - אם יש ולא בכוונה

            chart1.Series.Clear();

            //הוספת הסדרה לפקד הגרף

            chart1.Series.Add(series1);

           
        }

        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            DataToChart();
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
            DataToChart();
            ClientArrToForm();
            dateTimePicker_From.Checked = false;
            dateTimePicker_From.Value = DateTime.Today;
            dateTimePicker_To.Checked = false;
            dateTimePicker_To.Value = DateTime.Today;
           
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
