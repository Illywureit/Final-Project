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
using Illy_Project.BL;
using Illy_Project.DAL;


namespace Illy_Project.UI
{
    public partial class Form_ProductsInOrdersReport : Form
    {
        public Form_ProductsInOrdersReport()
        {
            InitializeComponent();
            DataToChart();
            CompanyArrToForm(comboBox_Filter_Company, false);
            CategoryArrToForm(comboBox_Filter_Category, false);
        }
        public void DataToChart()
        {
            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(textBox_Name_Filter.Text,
            comboBox_Filter_Company.SelectedItem as Company,
            comboBox_Filter_Category.SelectedItem as Category, (int)numericUpDown2.Value, true);
            //פלטת הצבעים - אפשר גם להגדיר מראש במאפיינים
            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution of products by orders");
            OrderProductArr curOrderProductArr = new OrderProductArr();
            curOrderProductArr.Fill();
            curOrderProductArr = curOrderProductArr.FilterByProductArr(productArr);
            Dictionary<string, int> dictionary = curOrderProductArr.GetDictionary();
            SortDictionaryByValue(ref dictionary);
            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2

            Series series = new Series("Number of orders");

            //סוג הגרף

            series.ChartType = SeriesChartType.Column;

            //המידע שיוצג לכל רכיב ערך בגרף - 3


            series.Label = "[#VAL = #PERCENT{P0}]";
                    
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
        private void textBox_ProductFilter_KeyUp(object sender, KeyEventArgs e)
        {
            DataToChart();
        }
        private void comboBoxProductFilter_TextChanged(object sender, EventArgs e)
        {
            DataToChart();
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

        private void button_clear_Click(object sender, EventArgs e)
        {
            DataToChart();
            CompanyArrToForm(comboBox_Filter_Company, false);
            CategoryArrToForm(comboBox_Filter_Category, false);
            textBox_Name_Filter.Text = "";
            numericUpDown2.Value = -1;
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
