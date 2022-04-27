using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Illy_Project.DAL;
using System.Data;


namespace Illy_Project.BL
{
    public class Order
    {
        private int m_Id;
        private string m_Comment;
        private Client m_Client;
        private DateTime m_Date;
        private bool m_Return;

        public string Comment { get => m_Comment; set => m_Comment = value; }        
        public int Id { get => m_Id; set => m_Id = value; }        
        public Client Client { get => m_Client; set => m_Client = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }
        public bool Return { get => m_Return; set => m_Return = value; }

        public bool Insert()
        {
            return Order_Dal.Insert(m_Date, m_Client.Id, m_Comment, m_Return);
        }
        public Order() { }

        public Order(DataRow dataRow)
        {

            
            m_Id = (int)dataRow["ID"];
            m_Comment = dataRow["Comment"].ToString();
            m_Client = new Client(dataRow.GetParentRow("OrderClient"));
            m_Date = (DateTime) dataRow["Date"];
            m_Return = (bool)dataRow["Return"];
        }
        public override string ToString()
        {
            string returned;
            if (m_Return)
                returned = "[R]";
            else
                returned = "[N-R]";
            string date ="{" + m_Date.ToShortDateString() + "}";
            
            return $" {returned} {m_Client.FirstName} {m_Client.LastName} {date}";
        }

        public bool Update()
        {
            return Order_Dal.Update(m_Id, m_Date, m_Client.Id, m_Comment, m_Return);
        }
        public bool Delete()
        {   
            return Order_Dal.Delete(m_Id);
        }

    }
   
}
