using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Index2(int id)
        {
            return id.ToString();
        }
        public IActionResult Index3()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1, FirstName="Merve", LastName="Bayındır", City="Antalya" },
                new Customer{Id=2, FirstName="Zümre", LastName="Bayındır", City="Mersin" },
                new Customer{Id=3, FirstName="Kutluhan", LastName="Bayındır", City="Yozgat"}
            };
            List<string> shops = new List<string> { "Ankara", "Yozgat", "Antalya" };
            var model = new CustomerListViewModel
            {
                Customers = customers,
                //Shops = shops,
            };
            return View(customers);
        }
        [HttpGet]
        public IActionResult SaveCustomer()
        {
            return View();
        }
        [HttpPost]
        public string SaveCustomer(Customer customer)
        {
            return "Kayededildi";
        }
    }
}
