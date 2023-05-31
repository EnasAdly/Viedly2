using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viedly2.Models;

namespace Viedly2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        public ActionResult Index()
        {

            var customers = GetCustomers();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        private IEnumerable<Customers> GetCustomers()
        {
            return new List<Customers>
            {
                new Customers { Id = 1, Name = "John Smith" },
                new Customers { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}