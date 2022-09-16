using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    [Route(template:"deneme")]
    public class CustomerController : Controller
    {
        private ILogger _logger;
        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }
        //Http GET
        [Route(template:"index")]
        [Route(template:"")]
        [Route(template:"~/anasayfa")]
        public IActionResult Index3()
        {
           //_logger.Log("");
            List<Customer> customers = new List<Customer>()
            {
                new Customer{Id=1, FirstName="Merve", LastName="Bayındır", City="Yozgat" },
                new Customer{Id=2, FirstName="Zümra", LastName="Bayındır", City="Yozgat" },
                new Customer{Id=3, FirstName="Merve", LastName="Bayındır", City="Yozgat" },
            };
            List<string> shops = new List<string> { "Ankara", "İstanbul", "İzmir" };
             
            var model = new CustomerListViewModel
            {
                Customers = customers,
                //Shops = shops
            };
            return View(model);
        }
        [HttpGet]
        [Route(template:"save")]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel
            {
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text="Antalya", Value="07"},
                    new SelectListItem{Text="Yozgat", Value="66"},
                    new SelectListItem{Text="Ankara", Value="06"}
                }
            });
        }
        [HttpPost]
        [Route(template: "save")]
        public string SaveCustomer(Customer customer) 
        {
            return "Kaydedildi.";
        }
    }
}
