using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hontashvili_family.DAL;
using System.Data;


namespace hontashvili_family.BL
{
    public class Product
    {
        private int m_Id;
        private string m_Name;
        private Company m_Company;
        private Category m_Category;
        private int m_Count;


        public string Name { get => m_Name; set => m_Name = value; }        
        public int Id { get => m_Id; set => m_Id = value; }        
        public Company Company { get => m_Company; set => m_Company = value; }
        public Category Category { get => m_Category; set => m_Category = value; }
        public int Count { get => m_Count; set => m_Count = value; }

        public bool Insert()
        {
            return Product_Dal.Insert(m_Name, m_Company.Id, m_Category.Id, m_Count);
        }
        public Product() { }

        public Product(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_Id = (int)dataRow["ID"];
            m_Count = (int)dataRow["Count"];
            m_Name = dataRow["Name"].ToString();
            m_Company = new Company(dataRow.GetParentRow("ProductCompany"));
            m_Category = new Category(dataRow.GetParentRow("ProductCategory"));

        }
        public override string ToString()
        {
            if (m_Count > 0)
                return $"{m_Name} [{m_Company.Name}] ({m_Count} In stock)";
            else
                return $"{m_Name} [{m_Company.Name}] (Out of stock)";
        }

        public bool Update()
        {
            return Product_Dal.Update(m_Id, m_Name, m_Company.Id, m_Category.Id, m_Count);
        }
        public bool Delete()
        {
            return Product_Dal.Delete(m_Id);
        }
        public bool UpdateCount()
        { return Product_Dal.UpdateCount(m_Id, m_Count); }

    }
   
}
