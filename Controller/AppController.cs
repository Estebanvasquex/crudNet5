using System;
using Microsoft.AspNetCore.Mvc;

namespace crudNet5.Controller
{
    public class AppController : Microsoft.AspNetCore.Mvc.Controller
    {
           public IActionResult Index()
            {
              
                return View();
            }     


            public IActionResult Welcome()
            {
              
                return View();
            }        
    }
}