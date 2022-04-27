using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Illy_Project.DAL
{
    class Product_Dal
    {

        public static bool Insert(string name, int company, int category, int count)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Product"
            + "("
            + "[Name],[Company],[Category],[Count]"
            + ")"
            + " VALUES "
            + "("
            + $"'{name}',{company},{category},{count}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Product"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Product", "[Name]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            DataRelation dataRelation = null;
            
            
            
            Company_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "ProductCompany"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Company"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Product"].Columns["Company"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);

            Category_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "ProductCategory"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Category"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Product"].Columns["Category"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);


        }
        public static bool Update(int id, string name, int company, int category, int count)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Product SET"
            + $" [Name] = '{name}'"
            + $",[Company] = {company}"
            + $",[Category] = {category}"
            + $",[Count] = {count}"

            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Product WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
        public static bool UpdateCount(int id, int count)
        {

            // מעדכנת את מלאי המוצר במסד הנתונים
            string str = $"UPDATE Table_Product SET [Count] = {count} WHERE ID = {id}";
            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}
