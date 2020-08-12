using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC8amMorningBatch.ServiceReference1;
using MVC8amMorningBatch.Filters;
namespace MVC8amMorningBatch.Controllers
{
    [MyFilter]
    public class EmployeeController : Controller
    {
        // GET: Employee
      
        public string EmployeeIndex(int? it)
        {
           
            return "Hello World "+ it;
        }
        public ActionResult GetDigitalCalculator()
        {
            // CalculatorSoapClient obj = new CalculatorSoapClient();
            //ViewBag.result= obj.DigitalCalculator('+', 10, 20);
            ServiceReference2.Service1Client obj = new ServiceReference2.Service1Client();
            ViewBag.result=obj.GetService('*', 20, 2);

            return View();
        }
        public ActionResult GetPlayer()
        {
            ViewBag.Player = "Rahul Dravid";
            return View();
        } 

    }
}

