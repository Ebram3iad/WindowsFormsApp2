using Dapper;
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
  public class OrderDetail
    {

        public int OrderID { get; set; }
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        [Display(Name ="Unit Price")]
        public decimal UnitPrice { get; set; }
        public decimal Total
        {
            get
            {
                return Quantity * UnitPrice - Quantity * UnitPrice * (Discount/100);
            }
        }

        //Get List<OrdersDetails> by Order Id 
        public static List<OrderDetail> GetOrderDetailsById(int id)
        {
            List<OrderDetail> OrderDetailsList = null;
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    //string query = "select d.OrderID,p.ProductName,d.Quantity,d.Discount,d.UnitPrice from [Order Details] d inner join Products p on d.ProductID = p.ProductID " +
                    //    $"where d.OrderID = '{id}'";
                    string query = "select d.OrderID,d.ProductID,p.ProductName,d.Quantity,d.UnitPrice,d.Discount*100 as Discount from [Order Details] d inner join Products p on d.ProductID = p.ProductID " +
                                     $"where d.OrderID = {id}";
                    OrderDetailsList = db.Query<OrderDetail>(query, commandType: CommandType.Text).ToList();                   
                }
            }
            return OrderDetailsList;
        }

        public bool Insert()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {               
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {

                        String cmd = $"insert into [Order Details] (OrderID,ProductID,Quantity,UnitPrice,Discount) values(" + Orders.GetOrderId() + ",@ProductID,@Quantity,@UnitPrice,@Discount/100 )";
                            
                        db.Execute(cmd, this);
                    }
                    return true;
                }
                catch (Exception err)
                {
                    string message = err.Message;
                    return false;
                }
            }
        }
        //public int GetOrderId()
        //{
        //    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
        //    {
        //        if (db.State == ConnectionState.Closed)
        //        {
        //            //String cmd ="select max(OrderID) from orders";
        //            String cmd = @"SELECT IDENT_CURRENT('orders')";

        //            string Id = db.Query<Orders>(cmd, commandType: CommandType.Text).Single().ToString();
        //            int orderId = int.Parse(Id);
        //            return orderId + 1;

        //        }
        //        return -1;
        //    }
        //}

        //public int GetProductId()
        //{
        //    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
        //    {
        //        if (db.State == ConnectionState.Closed)
        //        {
        //            String cmd = $"select max(OrderID) from orders";

        //            int productId = db.Query<Orders>(cmd, commandType: CommandType.Text).FirstOrDefault().OrderId;
        //            return productId;

        //        }
        //        return -1;
        //    }
        public bool Update(int orderId)
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
           
                try
            {
                if (db.State == ConnectionState.Closed)
                {
                    String cmd = $"update   [Order Details] set ProductID=@ProductID, OrderID=@OrderID,Quantity=@Quantity, UnitPrice=@UnitPrice,Discount=@Discount/100 where OrderID="+orderId + " and ProductID=@ProductID ";


        db.Execute(cmd, this);

        }
                return true;
            }
            catch (Exception err)
            {
                string message = err.Message;
                return false;
            }

        }
    }
}
