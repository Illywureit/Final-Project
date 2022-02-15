﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using hontashvili_family.DAL;

namespace hontashvili_family.BL
{
    
        public class ClientArr : ArrayList
        {
            public void Fill()
            {

                //להביא מה-DAL טבלה מלאה בכל הלקוחות

                DataTable dataTable = Client_Dal.GetDataTable();

                //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
                //להעביר כל שורה בטבלה ללקוח

                DataRow dataRow;
                Client curClient;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataRow = dataTable.Rows[i];
                    curClient = new Client(dataRow);
                    this.Add(curClient);
                }
            }
            public ClientArr Filter(string firstName, string lastName)
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                client = (this[i] as Client);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                 
                 client.FirstName.ToLower().StartsWith(firstName.ToLower()) 
                && client.LastName.ToLower().StartsWith(lastName.ToLower())
)                

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    clientArr.Add(client);
            }
            return clientArr;
        }
            public bool DoesExist(City curCity)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Client).City.Id == curCity.Id)
                    return true;

            return false;
        }
        }

}
