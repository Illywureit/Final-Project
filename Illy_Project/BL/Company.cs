using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Illy_Project.DAL;
using System.Data;


namespace Illy_Project.BL
{
    public class Company
    {
        private int m_Id;
        private string m_Name;
       
        
        public string  Name { get => m_Name; set => m_Name = value; }
      
        public int Id { get => m_Id; set => m_Id = value; }

        public bool Insert()
        {
            return Company_Dal.Insert(m_Name);
        }
        public Company() { }

        public Company(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_Id = (int)dataRow["ID"];
            m_Name = dataRow["Name"].ToString();
            
        }
        public override string ToString()
        { return $"{m_Name}"; }

        public bool Update()
        {
            return Company_Dal.Update(m_Id, m_Name);
        }
        public bool Delete()
        {
            return Company_Dal.Delete(m_Id);
        }

    }
   
}
