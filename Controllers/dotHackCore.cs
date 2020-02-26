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
    public class dotHack : Controller
    {
        private static LightYearContext dbContext;
        public dotHack(LightYearContext context)
        {
            dbContext = context;
        }

        public static void TesterX(){
            System.Console.WriteLine("Testing testing! *****************************************");
        }

        
    }
}