using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework1.Models
{
    public class OrdersHistory
    {
        public List<ProductInfo> products { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class ProductInfo
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public decimal Price { get; set; }
    }
}