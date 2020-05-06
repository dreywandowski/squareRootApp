using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculatorWeb.Models;
using System.ComponentModel.Design;

namespace CalculatorWeb.Controllers
{
    public class calc : Controller
    {
        
   
        /**public ActionResult index()
        {
            return View();
        }**/

        // HTTP Post
        public ActionResult index(int first, int second)
        {
            int a = first;
            int b = second;
            int result = first + second;

            ViewBag.Result = result;

            return View();
        }
      
    }
}
