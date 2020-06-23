using MVC8amMorningBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amMorningBatch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Get() {

            return View();
        }

        public string Index()
        {
            return "hello world";
        }

        public int Index1(int id)
        {
            return  id;
        }

        public ActionResult Index2()
        {
            return View();
        }

        public string GetData(int? id,string name)
        {

            return "Employee Id: "+ id+" Name: "+name;   

        }

        public string GetData2(int? id)
        {
            string Name = Request.QueryString["name"];

            return "Employee Id: " + id + "Name: "+ Name;

        }

        public ActionResult GetLuckyData() {
            
            ViewBag.Lucky = 1;
            return View("GetData");
        }

        public ActionResult GetLuckyPersonData()
        {
            List<Employee> listObj = new List<Employee>();
            Employee objRadhika = new Employee();
            objRadhika.EmpId = 1;
            objRadhika.EmpName = "Harini";
            objRadhika.EmpSalary = 210000;

            Employee objShiva = new Employee();
            objShiva.EmpId = 2;
            objShiva.EmpName = "Shiva";
            objShiva.EmpSalary = 420000;

            listObj.Add(objRadhika);
            listObj.Add(objShiva);


            ViewBag.Lucky = listObj;




            return View("GetData");
        }

    }
}