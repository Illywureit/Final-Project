using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Illy_Project.DAL;
using System.Data;


namespace Illy_Project.BL
{
    public class Client
    {
        private int m_Id;
        private string m_FirstName;
        private string m_LastName;
        private string m_Mail;
        private string m_Phone;
        private City m_City;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public string Mail { get => m_Mail; set => m_Mail = value; }
        public string Phone { get => m_Phone; set => m_Phone = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        public City City { get => m_City; set => m_City = value; }

        public bool Insert()
        {
            return Client_Dal.Insert(m_FirstName, m_LastName, m_Mail, m_Phone, m_City.Id);
        }
        public Client() { }

        public Client(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_Id = (int)dataRow["ID"];
            m_FirstName = dataRow["FirstName"].ToString();
            m_LastName = dataRow["LastName"].ToString();
            m_Mail = dataRow["Mail"].ToString();
            m_Phone = dataRow["PhoneNumber"].ToString();
            m_City = new City(dataRow.GetParentRow("ClientCity"));
        }
        public override string ToString()
        { return $"{m_LastName} {m_FirstName}"; }

        public bool Update()
        {
            return Client_Dal.Update(m_Id, m_FirstName, m_LastName, m_Mail, m_Phone, m_City.Id);
        }
        public bool Delete()
        {
            return Client_Dal.Delete(m_Id);
        }

    }
   
}
