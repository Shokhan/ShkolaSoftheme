using Homework1.Filters;
using Homework1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers
{
    [RoutePrefix("Customers")]
    [Culture]
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("Info")]
        public ActionResult DisplayCustomers()
        {
            using (var db = new TestSQLDB2014Entities1())
            {
                var customers = (from cust in db.Customers
                                select cust).ToList();
                return View(customers);
            }
        }

        [HttpGet]
        [Route("orders/{id:int?}")]
        public ActionResult Orders(int? id)
        {

            using (var db = new TestSQLDB2014Entities1())
            {
                var orders = (from o in db.Orders
                             where o.CustomerId == id
                             select new OrdersHistory
                             {
                                 products = (from p in db.Products
                                                    from od in db.OrderDetails
                                                    where od.OrderId == o.OrderId && p.ProductId == od.ProductId
                                                    select new ProductInfo
                                                    {
                                                        Name = p.ProductName,
                                                        Number = od.Quantity,
                                                        Price = od.UnitPrice
                                                    }).ToList(),

                                 OrderDate = o.OrderDate
                             }).ToList();

                return View(orders);
            }

            return View();
        }
    }
}