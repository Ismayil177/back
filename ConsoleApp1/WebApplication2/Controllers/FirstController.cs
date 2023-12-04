using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ViewState ()
        {
     /*       string[] fruits = { "Alma", "Heyva", "Nar" };*/
/*
            int[] mynumbers = { 111, 222, 333 };


            ViewBag.Fruits = mynumbers;

            *//*            Dictionary<string, string> values = new();*/
/*            Dictionary<string , string> values = new Directory<string, string>();*//*
            var values = new Dictionary<string, string>();

            *//*  dynamic x = new object();

              x.Name = "Ismayil";
              x.Surname = "Mahmudov";*/

            /*  ViewBag
              ViewData
              TempData*/

            /*            string[] prorammingLaunguages = { "C#", "Java", "Javascript" };
                        ViewData["Langs"] = prorammingLaunguages;
                        return View();*//*

            int[] numbers = { 1, 2,3 };
            ViewData["Langs"] = numbers;
            return View();*/

        }

        public IActionResult About()
        {
            string[] fruits = { "Alma", "Heyva", "Nar" }; 
            ViewBag.Fruits = fruits;

            string[] prorammingLaunguages = { "C#", "Java", "Javascript" };
            ViewData["langs"] = prorammingLaunguages;

            string[] numbers = { "bir", "iki", "uc" };
            ViewData["numbers"] = numbers;

            return RedirectToAction("ViewState");

        }

        public IActionResult Contact()
        {
            int[] fruits = { 1, 2, 3, 4 };
            return View(fruits);
        }
    }
}
