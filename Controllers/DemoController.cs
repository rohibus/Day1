using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using assignment.Models;

namespace assignment.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        
        public ActionResult greet()
        {

            return View();
        }


        public static List<Product> list = new List<Product>()
        {
            new Product(){Pid = 10, Pname = "abc", Price = 100, Stock = 10},
            new Product(){Pid = 20, Pname = "def", Price = 200, Stock = 13},
            new Product(){Pid = 30, Pname = "hij", Price = 400, Stock = 8},
            new Product(){Pid = 40, Pname = "klo", Price = 600, Stock = 7}
        };

        public ActionResult getlist()
        {
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        

        [HttpPost]
        public ActionResult Create(int Pid, string Pname,int Price, int Stock )
        {
            //adding project data to list
            Product p = new Product() { Pid = Pid, Pname = Pname, Price = Price, Stock = Stock };
            list.Add(p);
            ViewData["1"] = Pid;
            ViewData["2"] = Pname;
            ViewData["3"] = Price;
            ViewData["4"] = Stock;
            return View("details");
        }

        public ActionResult details()
        {
            //adding project data to list
            
            return View();
        }

    }
}
