using MVC_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id=1)
        {
            EmplyeeContext ec = new EmplyeeContext();
            Employee e = ec.Employees.Single(x => x.Id == id);
            return View(e);
        }

        public ActionResult Index()
        {
            EmplyeeContext empc = new EmplyeeContext();
            List<Employee> emp = empc.Employees.ToList();
            return View(emp);
        }
    }
}