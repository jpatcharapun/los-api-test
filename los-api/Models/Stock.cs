using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    //id,productId,amount
    public class Stock
    {
        public long Id { get; set; }
        public long productId { get; set; }
        public int amount { get; set; }
    }
}
