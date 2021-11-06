using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstApplication.Models;


namespace firstApplication.Controllers
{
     public class PersonalController : Controller
     {
         public IActionResult Index()
         {
             Personal personal = new Personal();
             personal.name = "Jonathan";
             personal.lastname = "Gamez";
             personal.age = 19;
             personal.email = "eliaslarin@gmail.com";
             personal.telephone = 78019697;
             personal.Direction = "Chinameca, San Miguel";
             return View(personal);
         }
     }
}