using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
  
    public  class product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public decimal FirstPrice { get; set; }
        public decimal SecondPrice { get; set; }
        public static List<product> products = new List<product> { new product() { Id = 1, Name = "p1",price =10, SecondPrice = 20, FirstPrice = 15 } };
    }

}
