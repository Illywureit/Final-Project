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

    public class ProductArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Product_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Product curProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curProduct = new Product(dataRow);
                this.Add(curProduct);
            }
        }
        public ProductArr Filter(string name, Company company, Category category)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Product product = (this[i] as Product);
                if
                (

                //סינון לפי שם המוצר

                product.Name.StartsWith(name)

                //סינון לפי החברה
                && (company == null || company.Id == -1 || product.Company.Id == company.Id)
                //סינון לפי קטגוריה
                && (category == null || category.Id == -1 || product.Category.Id == category.Id)
                )

                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    productArr.Add(product);
            }
            return productArr;
        }


        public bool DoesCompanyExist(Company curCompany)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Company.Id == curCompany.Id)
                    return true;

            return false;
        }

        public bool DoesCategoryExist(Category curCategory)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Category.Id == curCategory.Id)
                    return true;

            return false;
        }
    }

}