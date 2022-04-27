using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Illy_Project.DAL
{
    class Order_Dal
    {

        public static bool Insert(DateTime date, int client, string comment,bool returned)
        {
            
                
            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Order"
            + "("
            + "[Date],[Client],[Comment],[Return]"
            + ")"
            + " VALUES "
            + "("
            + $"'{date:yyyy-MM-dd}',{client},'{comment}','{returned}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Order"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Order");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            DataRelation dataRelation = null;
            
            
            
            Client_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "OrderClient"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Client"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Order"].Columns["Client"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);

            
        }
        public static bool Update(int id, DateTime date, int client, string comment, bool returned)
        {

            //מעדכנת את ההזמנה במסד הנתונים

            string str = "UPDATE Table_Order SET"
            + $" [Date] = '{date:yyyy-MM-dd}'"
            + $",[Client] = {client}"
            + $",[Comment] = '{comment}'"
            + $",[Return] = '{returned}'"

            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Order WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}
