using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework1.Models
{
    public class OrdersHistory
    {
        public string CustomerName { get; set; }
        public List<Products> products { get; set; }
        public DateTime OrderDate { get; set; }
    }
}