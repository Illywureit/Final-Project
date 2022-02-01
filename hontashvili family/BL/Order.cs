using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hontashvili_family.DAL;
using System.Data;


namespace hontashvili_family.BL
{
    public class Order
    {
        private int m_Id;
        private string m_Comment;
        private Client m_Client;
        private DateTime m_Date;

        public string Comment { get => m_Comment; set => m_Comment = value; }        
        public int Id { get => m_Id; set => m_Id = value; }        
        public Client Client { get => m_Client; set => m_Client = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }

        public bool Insert()
        {
            return Order_Dal.Insert(m_Date, m_Client.Id, m_Comment);
        }
        public Order() { }

        public Order(DataRow dataRow)
        {

            
            m_Id = (int)dataRow["ID"];
            m_Comment = dataRow["Comment"].ToString();
            m_Client = new Client(dataRow.GetParentRow("OrderClient"));
            m_Date = (DateTime) dataRow["Date"];
        }
        public override string ToString()
        { return $"{m_Id} {m_Client.FirstName} {m_Client.LastName}"; }

        public bool Update()
        {
            return Order_Dal.Update(m_Id, m_Date, m_Client.Id, m_Comment);
        }
        public bool Delete()
        {   
            return Order_Dal.Delete(m_Id);
        }

    }
   
}
