﻿using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Products
    {
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Display(Name ="Category Name")]
        public int CategoryID { get; set; }
        [Display(Name = "Quantity Per Unit")]
        public string QuantityPerUnit { get; set; }
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }

        //Get Products By Id
        public  static Products getproduct(int id)
        {
            string cmd = $"select * from Products where ProductID = {id} ";
            Products prod = null;
            if (id >0)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        prod = db.Query<Products>(cmd, commandType: CommandType.Text).FirstOrDefault();

                    }

                }
                return prod;
            }

            else
                return null;               
        }

        // Get Products by matching Category Id 
        public static List<Products> GetProducts()
        {
            List<Products> list = null;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    string query = "select  ProductID,ProductName,c.CategoryID,QuantityPerUnit,UnitPrice,Discontinued FROM Products p inner join Categories c on p.CategoryID=c.CategoryID";

                    list = db.Query<Products>(query, commandType: CommandType.Text).ToList();
                }
            }
            return list;
        }

        
    }
}
