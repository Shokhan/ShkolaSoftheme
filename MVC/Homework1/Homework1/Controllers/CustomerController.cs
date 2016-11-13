using Homework1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers
{
    [RoutePrefix("Customers")]
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("Info")]
        public ActionResult DisplayCustomers()
        {
            using (var db = new TestSQLDB2014Entities1())
            {
                var customers = from cust in db.Customers
                                select cust;
                return View(customers);
            }
        }
        [HttpGet]
        [Route("orders/{id:int?}")]
        public ActionResult Orders(int? id)
        {
            
            using (var db = new TestSQLDB2014Entities1())
            {
                var orders = from o in db.Orders
                             where o.CustomerId == id
                             select new
                             {
                                 Name = db.Customers.Where(c => c.CustomerId == id)
                                 .Select(c => c.ContactName).Take(1),

                                 OrderedProducts = db.OrderDetails.Where(d => d.OrderId == o.OrderId)
                                 .Select(d => d.)
                             }
            }

            return View();
        }
    }
}