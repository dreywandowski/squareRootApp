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
            double sqrtA = Math.Sqrt(a);
            double sqrtB = Math.Sqrt(b);
             
             if (sqrtA > sqrtB){
                ViewBag.Result = "The number  " + a +"  with a square root of   "+ sqrtA+"   has a higher square root than  "+ b+"  which has a square root of  "+ sqrtB;
             }

              else if (sqrtB > sqrtA){
                ViewBag.Result = "The number  " + b +"  with a square root of   "+ sqrtB+"   has a higher square root than  "+ a+"  which has a square root of  "+ sqrtA;

             }

             else if (sqrtA == sqrtB){
                ViewBag.Result = "The square roots of both numbers are the same. Kindly enter new sets of numbers";
             }
            
            else if ((a < 0 ) && (b < 0)){
             ViewBag.Result = "We cannot accept negative values. Enter a positive value please";
            }

            else if ((a < 0) || (b < 0)){
               ViewBag.Result = "We cannot accept negative values. Enter a positive value please";  
            }

            else{
                
            }

          

            return View();
        }
      
    }
}
