using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// session
using Microsoft.AspNetCore.Http;
// models
using LightYear.Models;
// .include
using Microsoft.EntityFrameworkCore;


namespace LightYear.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("TurnNumber") == null){
                HttpContext.Session.SetInt32("TurnNumber", 1);
            }
            // System.Console.WriteLine("*****************************************************************");
            int? tester = HttpContext.Session.GetInt32("TurnNumber");
            return View();
        }


        public IActionResult Test()
        {   
            if(HttpContext.Session.GetInt32("TurnNumber") == null){
                HttpContext.Session.SetInt32("TurnNumber", 1);
            }
            int turn = (int)HttpContext.Session.GetInt32("TurnNumber");
            turn++;
            HttpContext.Session.SetInt32("TurnNumber", turn);
            return RedirectToAction("Index");
        }

        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        //
        public IActionResult Privacy()
        {
            return View();
        }
        //
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
