using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Illy_Project.DAL;
using System.Globalization;

namespace Illy_Project.BL
{

    public class OrderArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Order_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Order curOrder;         
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrder = new Order(dataRow);
                this.Add(curOrder);
            }
        }
        public OrderArr Filter(int id, Client client, DateTime from, DateTime to, string returned)
        {
            OrderArr orderArr = new OrderArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Order order = (this[i] as Order);
                if
                (

                //סינון לפי שם המוצר

               (id == 0 || order.Id == id)

                //סינון לפי החברה
                && (client == null || client.Id == -1 || order.Client.Id == client.Id)
                //סינון לפי קטגוריה
                && (IsDate(order, from, to))
                && ((order.Return.ToString() == returned) || returned == "")
                )

                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                   orderArr.Add(order);
            }
            return orderArr;
        }

        public bool IsDate(Order order, DateTime from, DateTime to)
        {
            if (from == DateTime.MinValue && to != DateTime.MinValue)
                return IsAfter(to, order.Date);

            else if (to == DateTime.MinValue && from != DateTime.MinValue)
                return IsAfter(order.Date, from);

            else if (to == DateTime.MinValue && from == DateTime.MinValue)
                return true;

            else
            {
                if (IsAfter(order.Date, from) && IsAfter(to, order.Date))
                    return true;
                else
                    return false;
            }
        }
        
        public bool IsAfter(DateTime from, DateTime to)
        {
            
            if (from.Year > to.Year)
                return true;
            else if (from.Year < to.Year)
                return false;

            if (from.Month > to.Month)
                return true;
            else if (from.Month < to.Month)
                return false;

            if (from.Day >= to.Day)
                return true;
            return false;
        }

        public Order GetOrderWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Order maxOrder = new Order();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).Id > maxOrder.Id)
                    maxOrder = this[i] as Order;

            return maxOrder;
        }
        public bool DoesClientExist(Client curclient)
        {

            //מחזירה האם לפחות לאחד מההזמון יש את הקליינט

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).Client.Id == curclient.Id)
                    return true;

            return false;
        }

        public OrderArr Filter(int year, int month)
        {

            //מחזירה את אוסף ההזמנות מאותה שנה ואותו חודש

            OrderArr returnArr = new OrderArr();
            foreach (Order item in this)
                if (item.Date.Year == year && item.Date.Month == month)
                    returnArr.Add(item);
            return returnArr;
        }


        public Dictionary<string, int> GetDictionary(int year)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות ההזמנות לאותו חודש

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 1; i <= 12; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                dictionary.Add(monthName, this.Filter(year, i).Count);
            }
            return dictionary;
        }

        public int GetNumberOfReturned() 
        {
            int x = 0;
            for (int i = 0; i < this.Count; i++)
            {

                if((this[i] as Order).Return)
                    x++;

            }
            return x;
        }


        

    }

}
