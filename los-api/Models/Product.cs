using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    //id,name,imageUrl,price
    public class Product
    {
        public long id { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public double price { get; set; }
    }
}
