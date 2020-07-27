using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApplication.Models;
using System.Data.Entity;

namespace CodeFirstApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.EmployeeModeles.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel obj)
        {
            db.EmployeeModeles.Add(obj);
            int i = db.SaveChanges();
            if (i > 0)
            {
                RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.EmployeeModeles.Find(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            int i = db.SaveChanges();
            if (i > 0)
            {
                RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.EmployeeModeles.Find(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel emp = db.EmployeeModeles.Find(id);
            db.EmployeeModeles.Remove(emp);
            int i = db.SaveChanges();  
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