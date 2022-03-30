using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hontashvili_family.DAL;
using System.Data;


namespace hontashvili_family.BL
{
    public class OrderProduct
    {
        private int m_Id;
        private Order m_Order;
        private Product m_Product;
        private int m_Count;
       

        public int Id { get => m_Id; set => m_Id = value; }        
        public Order Order { get => m_Order; set => m_Order = value; }
        public Product Product { get => m_Product; set => m_Product = value; }
        public int Count { get => m_Count; set => m_Count = value; }
        

        public bool Insert()
        {
            return OrderProduct_Dal.Insert(m_Order.Id, m_Product.Id, m_Count);
        }
        public OrderProduct() { }

        public OrderProduct(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_Id = (int)dataRow["ID"];
            m_Order = new Order(dataRow.GetParentRow("OrderProductOrder"));
            m_Product = new Product(dataRow.GetParentRow("OrderProductProduct"));
            m_Count = (int)dataRow["Count"];
           
        }
        public override string ToString()
        { return $"{m_Id}"; }

        public bool Update()
        {
            return OrderProduct_Dal.Update(m_Id, m_Order.Id, m_Product.Id, m_Count);
        }
        public bool Delete()
        {
            return OrderProduct_Dal.Delete(m_Id);
        }

    }
   
}
