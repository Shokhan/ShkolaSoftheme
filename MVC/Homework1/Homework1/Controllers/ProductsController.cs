using Homework1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers
{
    [RoutePrefix("Products")]
    public class ProductsController : Controller
    {
        // GET: Products
        [Route("ProductsView")]
        public ActionResult ProductsView()
        {
            var db = new TestSQLDB2014Entities1();
            var products = from p in db.Products
                           select p;

            return View(products);
        }
    }
}