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

            return View(listObj);
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

        public ActionResult GetSingleEmpData()
        {
            Employee obj = new Models.Employee();
            obj.EmpId = 1;
            obj.EmpName = "Harini";
            obj.EmpSalary = 210000;

            return View(obj);
        }

        public ActionResult GetMultipeEmpData()
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


         

            return View(listObj);
        }

        public ViewResult GetView()
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

            return View("GetMultipeEmpData", listObj);
        }

        public RedirectResult Goto()
        {
            return Redirect("~/home/GetView");
        }

        public RedirectToRouteResult Gone()
        {

            return RedirectToAction("EmployeeIndex", "Employee",new {it=1,name="Shiva"});
        }

        public RedirectToRouteResult Gone2()
        {
            return RedirectToRoute("Shiva");
        }

        public ActionResult getpartial() {

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

            return View(listObj);
        }

        public PartialViewResult GetPartialView()
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

            return PartialView("_MyPartialView", listObj);

        }

        public FileResult GetFile()
        {
            return File("~/Web.config","application/xml", "Web.config");
        }

        public JsonResult GetJsonData() {
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
            return Json(listObj,JsonRequestBehavior.AllowGet);

        }

        public ContentResult GetContentData(int? id) {
            if (id == 1)
            {
                return Content("Record is inserted");//string
            }
            else if (id == 2) {
                return Content("<script>alert('Record is Inserted')</script>");//javascript
            }
            else
            {
                return Content("<p style=color:red>Record is Inserted</p>");//css style 

            }
        }

        public ActionResult HtmlHelperExample()
        {
            EmployeeEntities db = new EmployeeEntities();
            ViewBag.Employee = new SelectList(db.employeeDetails, "EmpName", "EmpName");
            return View();
        }
    }
}