using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
   public class priceType
    {
        public int id { get; set; }
        public string Name { get; set; }

        public static List<priceType> PriceTypeList = new List<priceType>() { new priceType() { id = 1, Name = "type 1" }, new priceType() { id = 2, Name = "type 2" } }; 
    }
}
