using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Illy_Project.DAL;

namespace Illy_Project.BL
{
    
        public class CategoryArr : ArrayList
        {
            public void Fill()
            {

                //להביא מה-DAL טבלה מלאה בכל הלקוחות

                DataTable dataTable = Category_Dal.GetDataTable();

                //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
                //להעביר כל שורה בטבלה ללקוח

                DataRow dataRow;
                Category curCategory;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataRow = dataTable.Rows[i];
                    curCategory = new Category(dataRow);
                    this.Add(curCategory);
                }
            }
       
        public bool IsContains(string cityName)
        {

            //בדיקה האם יש ישוב עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Category).Name == cityName)
                    return true;
            return false;
        }
        public Category GetCategoryWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Category maxCategory = new Category();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Category).Id > maxCategory.Id)
                    maxCategory = this[i] as Category;

            return maxCategory;
        }

    }

}
