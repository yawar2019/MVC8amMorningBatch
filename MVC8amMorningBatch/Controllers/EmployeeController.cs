using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amMorningBatch.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string EmployeeIndex(int? it)
        {
            return "Hello World "+ it;
        }
    }
}