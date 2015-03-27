using CarDealer.Models;
using CarDealer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarDealer.Controllers
{
    public class DealerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult MenuItem()
        {
            var cList = new CarMenuViewModel() { carList = new List<Car>() { 
                new Car(){ Brand="BMW"},
                new Car(){ Brand="Lexux"},
                new Car(){ Brand="Honda"},
                new Car(){ Brand="Chevy"},
                new Car(){ Brand="Pursha"}
            } };

            
            return PartialView(cList);
        }


        public ActionResult Browse(string brand)
        {
            ViewBag.brand = brand;
            var InventoryViewModel = new InventoryViewModel()
            {
                Brand = brand,
                model = new List<string>() { brand + " brand 1", brand + " brand 2", brand + " brand 3", brand + " brand 4" }
            };

            return View(InventoryViewModel);
        }

     
    }
}