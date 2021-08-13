using CustomModelBinderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomModelBinderApp.Controllers
{
    public class EmployeeController : Controller
    {
         
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEmployee( [ModelBinder(typeof(CustomModelBinder))]Employee employee)
        {

            //Response.Write($" Employee Address - { employee.Address} ");

            return Content($" Employee Address - { employee.Address} ");
        }
    }
}