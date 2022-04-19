using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using hontashvili_family.BL;
using hontashvili_family.DAL;

namespace hontashvili_family.UI
{
    public partial class Form_OrdersByMonthReport : Form
    {
        public Form_OrdersByMonthReport()
        {
            InitializeComponent();
            DataToChart();
        }
        public void DataToChart()
        {
          
            //פלטת הצבעים - אפשר גם להגדיר מראש במאפיינים
            
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution of orders by month");
            OrderArr curOrderArr = new OrderArr();
            curOrderArr.Fill();
           
            Dictionary<string, int> dictionary1 = curOrderArr.GetDictionary((int)numericUpDown1.Value);
            Dictionary<string, int> dictionary2 = curOrderArr.GetDictionary((int)numericUpDown2.Value);


            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2
          
            Series series1 = new Series("Number of orders in year " + numericUpDown1.Value.ToString());

            //סוג הגרף

            series1.ChartType = SeriesChartType.Column;

            //המידע שיוצג לכל רכיב ערך בגרף - 3


            series1.Label = "#VALX [#VAL = #PERCENT{P0}]";

            series1.Points.DataBindXY(dictionary1.Keys, dictionary1.Values);
            //מחיקת סדרות קיימות - אם יש ולא בכוונה

            chart1.Series.Clear();

            //הוספת הסדרה לפקד הגרף

            chart1.Series.Add(series1);
           
            Series series2 = new Series("Number of orders in year" + numericUpDown2.Value.ToString());

            //סוג הגרף

            series2.ChartType = SeriesChartType.Column;

            //המידע שיוצג לכל רכיב ערך בגרף - 3


            series2.Label = "#VALX [#VAL = #PERCENT{P0}]";

            series2.Points.DataBindXY(dictionary2.Keys, dictionary2.Values);
            //מחיקת סדרות קיימות - אם יש ולא בכוונה

            

            //הוספת הסדרה לפקד הגרף

            chart1.Series.Add(series2);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            DataToChart();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
