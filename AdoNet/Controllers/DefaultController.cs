using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoNet.Models;
namespace AdoNet.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeModel db = new EmployeeModel();

        public ActionResult Index()
        {
            return View(db.GetEmployee());
        }

        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee obj)
        {
          int i=db.SaveEmployee(obj);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public RedirectToRouteResult Edit(int ?id)

        {
            Employee obj = db.GetEmployeeById(id);
            return RedirectToAction("index");
        }

        [HttpPost]
        public ActionResult Edit(Employee obj)
        {
            int i = db.EditEmployee(obj);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}