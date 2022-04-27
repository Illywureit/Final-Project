using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Illy_Project.DAL;


namespace Illy_Project.BL
{

    public class OrderProductArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = OrderProduct_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            OrderProduct curOrderProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrderProduct = new OrderProduct(dataRow);
                this.Add(curOrderProduct);
            }
        }
        public OrderProductArr FilterByOrder(Order order)
        {
            OrderProductArr orderProductArr = new OrderProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                OrderProduct orderProduct = (this[i] as OrderProduct);
                if
                (
                              
                //סינון לפי הזמנה
                 (orderProduct.Order.Id == order.Id)
                               
                )

                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }
        public OrderProductArr FilterByProduct(Product product)
        {
            OrderProductArr orderProductArr = new OrderProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                OrderProduct orderProduct = (this[i] as OrderProduct);
                if(
                 //סינון לפי מוצר
                 (orderProduct.Product.Id == product.Id)
                )


                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    orderProductArr.Add(orderProduct);
            }
        
            return orderProductArr;
        }
        public OrderProductArr FilterByProductArr(ProductArr productArr)
        {
            OrderProductArr orderProductArr = new OrderProductArr();

            for (int i = 0; i < this.Count; i++)
            {
                for (int j = 0; j < productArr.Count; j++)
                {
                    //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                    OrderProduct orderProduct = (this[i] as OrderProduct);
                    if (
                     //סינון לפי מוצר
                     (orderProduct.Product.Id == (productArr[j] as Product).Id)
                    )


                        //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                        orderProductArr.Add(orderProduct);
                }

               
            }

            return orderProductArr;
        }





        public OrderProduct GetOrderProduct(Order order, Product product)
        {
            for (int i = 0; i < this.Count; i++)
                if (((this[i] as OrderProduct).Order.Id == order.Id) && (this[i] as OrderProduct).Product.Id == product.Id)
                    return this[i] as OrderProduct;
            return null;
                
        }

        public bool DoesProductExist(Product curProduct)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as OrderProduct).Product.Id == curProduct.Id)
                    return true;

            return false;
        }

        public bool Insert()
        {

            // מוסיפה את אוסף המוצרים להזמנה למסד הנתונים

            OrderProduct orderProduct = null;
            for (int i = 0; i < this.Count; i++)
            {
                orderProduct = (this[i] as OrderProduct);
                if (!orderProduct.Insert())
                    return false;
            }
            return true;
        }

        public ProductArr GetProductArr()
        {

            //מחזירה את אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            ProductArr productArr = new ProductArr();
            for (int i = 0; i < this.Count; i++)
            {
                if (!(productArr.DoesProductExist((this[i] as OrderProduct).Product as Product)))
                productArr.Add((this[i] as OrderProduct).Product);
            }
                
            return productArr;
        }

        public bool Delete()
        {

            //מוחקת את אוסף המוצרים להזמנה ממסד הנתונים

            for (int i = 0; i < this.Count; i++)
                (this[i] as OrderProduct).Delete();
            return true;
        }

        public Dictionary<string, int> GetDictionary()
        {

            // מחזירה משתנה מסוג מילון ממוין עם ערכים רלוונטיים לדוח
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            ProductArr ordersProductArr = this.GetProductArr();
            foreach (Product curProduct in ordersProductArr)
                dictionary.Add(curProduct.Name, this.FilterByProduct(curProduct).Count);
            return dictionary;
        }
        
    }

}
