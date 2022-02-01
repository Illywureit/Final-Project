using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hontashvili_family.DAL;
using System.Data;


namespace hontashvili_family.BL
{
    public class Category
    {
        private int m_Id;
        private string m_Name;
       
        
        public string Name { get => m_Name; set => m_Name = value; }
      
        public int Id { get => m_Id; set => m_Id = value; }

        public bool Insert()
        {
            return Category_Dal.Insert(m_Name);
        }
        public Category() { }

        public Category(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_Id = (int)dataRow["ID"];
            m_Name = dataRow["Name"].ToString();
            
        }
        public override string ToString()
        { return $"{m_Name}"; }

        public bool Update()
        {
            return Category_Dal.Update(m_Id, m_Name);
        }
        public bool Delete()
        {
            return Category_Dal.Delete(m_Id);
        }

    }
   
}
