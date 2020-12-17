using Dapper;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace WindowsFormsApp2
{
    public class Categories
    {
        public int CategoryID { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        // Get List of Categories ID, Name
        public static List<Categories> GetCategories()
        {
            List<Categories> Catlist = null;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    string query = "select CategoryID, CategoryName from Categories";

                    Catlist = db.Query<Categories>(query, commandType: CommandType.Text).ToList();
                }
            }
            return Catlist;
        }
    }
}
