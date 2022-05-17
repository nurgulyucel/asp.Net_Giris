using Microsoft.AspNetCore.Mvc;
using OOP_Temelleri_1.Entity;
using OOP_Temelleri_1.ProjeContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Temelleri_1.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.customers.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            if(p.CustomerName.Length>=6 && p.CustomerCity!="" && p.CustomerCity.Length>=3)
            {
                context.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                ViewBag.message = "Hatalı Kullanım";
                return View();
            }
            
        } 
        public IActionResult DeleteCustomer(int id)
        {
            var value = context.customers.Where(x => x.CustomerId == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.customers.Where(x => x.CustomerId == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            var value = context.customers.Where(x=>x.CustomerId==p.CustomerId).FirstOrDefault();
            value.CustomerCity = p.CustomerCity;
            value.CustomerName = p.CustomerName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
