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
    public partial class Form_ProductsInOrdersReport : Form
    {
        public Form_ProductsInOrdersReport()
        {
            InitializeComponent();
            DataToChart();  
        }
        public void DataToChart()
        {
            //פלטת הצבעים - אפשר גם להגדיר מראש במאפיינים
            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution of products by orders");
            OrderProductArr curOrderProductArr = new OrderProductArr();
            curOrderProductArr.Fill();
            Dictionary<string, int> dictionary = curOrderProductArr.GetDictionary();
            SortDictionaryByValue(ref dictionary);
            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2

            Series series = new Series("Number of orders");

            //סוג הגרף

            series.ChartType = SeriesChartType.Column;

            //המידע שיוצג לכל רכיב ערך בגרף - 3


            series.Label = "#VALX [#VAL = #PERCENT{P0}]";
                    
                series.Points.DataBindXY(dictionary.Keys, dictionary.Values);
                    //מחיקת סדרות קיימות - אם יש ולא בכוונה

                    chart1.Series.Clear();

                    //הוספת הסדרה לפקד הגרף

                    chart1.Series.Add(series);
        }
        public void SortDictionaryByValue(ref Dictionary<string, int> dictionary)
        {
            //ממיינת את המשתנה מסוג מילון לפי הערכים 
            Dictionary<string, int> tempDictionary = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> pair in dictionary.OrderBy(key => key.Value))
                tempDictionary.Add(pair.Key, pair.Value);
            dictionary = tempDictionary;
        }

    }
}
