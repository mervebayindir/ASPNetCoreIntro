using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    public class SessionDemoController:Controller
    {
        
        public string Index1()
        {
            Customer customer = new Customer { Id = 1, FirstName = "Merve" };
            HttpContext.Session.SetString("isim","Zümra");
            HttpContext.Session.SetObject(key:"musteri", customer);
            return "Session oluştu";
        }
        public string Index2()
        {
            var customer= HttpContext.Session.GetObject<Customer>(key:"musteri");
            return customer.FirstName;
        }
    }
}
