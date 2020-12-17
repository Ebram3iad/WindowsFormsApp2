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
    public class Orders
    {
        public int OrderID { get; set; }
        public int CustmoerId { get; set; }
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }
        public string Address { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime OrderDate { get; set; }
        public Decimal Total { get; set; }
        public Decimal Freight { get; set; }
        public Decimal Paid { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public Decimal Remain { get; set; }

        public bool Insert()
        {


            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
           
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {

                        String cmd = $"insert into Orders (OrderDate,CustomerID , Freight, ShipCity,ShipCountry) values(@OrderDate,'ANTON',@Total,@Remain,@Paid)";


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
        public static int GetOrderId()
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    string cmd = $"select max(OrderID) from orders";
                    SqlCommand sqlQuery = new SqlCommand(cmd, db);
                    db.Open();
                    int orderId = Convert.ToInt32(sqlQuery.ExecuteScalar());
                    return orderId;

                }
                return -1;
            }
        }

        public List<Orders> GetOrders()
        {
            List<Orders> OrdersList = new List<Orders>();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    string cmd = $"select * from orders";
                    OrdersList = db.Query<Orders>(cmd, commandType: CommandType.Text).ToList();
                    //return OrdersList;
                }
               

            }
            return OrdersList;
        }

        public Orders GetOrderById(int id)
        {
            Orders order =new Orders();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    string cmd = $"select * from orders where OrderId = {id}";
                    order = db.Query<Orders>(cmd, commandType: CommandType.Text).FirstOrDefault();
                  

                }
                  return order;//return null;
            }
        }

        public bool Update()
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
           
                try
            {
                if (db.State == ConnectionState.Closed)
                {

                    String cmd = $"update Orders set OrderDate=@OrderDate, Freight=@Total, ShipCity=@Remain,ShipCountry=@Paid where OrderID= @OrderID ";


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

        public bool Delete()
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

            try
            {
                if (db.State == ConnectionState.Closed)
                {

                    String cmd = $"delete from [Order Details] where OrderID = @OrderID ; delete from [Orders] where OrderID =  @OrderID; ";
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
