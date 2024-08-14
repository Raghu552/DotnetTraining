using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CC_MVC.Controllers
{
    public class CodeController : Controller
    {
        public northwindEntities db = new northwindEntities();
        // GET: Code
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GermanyPeople()
        {
            var germanypeople = db.Customers
                .Where(c => c.Country == "Germany").ToList();
            return View(germanypeople);
        }

        public ActionResult GetCustomerDetails()
        {
            var customer = db.Orders
                .Where(o => o.OrderID == 10248)
                .Select(o => o.Customer)
                .FirstOrDefault();

            return View(customer);
        }
    }
}