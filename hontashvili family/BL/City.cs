using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hontashvili_family.DAL;
using System.Data;


namespace hontashvili_family.BL
{
    public class City
    {
        private int m_id;
        private string m_name;
       
        
        public string Name { get => m_name; set => m_name = value; }
      
        public int Id { get => m_id; set => m_id = value; }

        public bool Insert()
        {
            return City_Dal.Insert(m_name);
        }
        public City() { }

        public City(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_id = (int)dataRow["ID"];
            m_name = dataRow["Name"].ToString();
            
        }
        public override string ToString()
        { return $"{m_name}"; }

        public bool Update()
        {
            return City_Dal.Update(m_id, m_name);
        }
        public bool Delete()
        {
            return City_Dal.Delete(m_id);
        }

    }
   
}
