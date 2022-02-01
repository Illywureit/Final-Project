﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

namespace hontashvili_family.DAL
{
    class Category_Dal
    {

        public static bool Insert(string Name)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Category"
            + "("
            + "[Name]"
            + ")"
            + " VALUES "
            + "("
            + $"'{Name}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Category"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            if (!dataSet.Tables.Contains("Table_Category"))
            {
                Dal.FillDataSet(dataSet, "Table_Category", "[Name]");
            }
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...

        }
        public static bool Update(int id, string Name)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Category SET"
            + $" [Name] = '{Name}'"
            

            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Category WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }  
    }
}
