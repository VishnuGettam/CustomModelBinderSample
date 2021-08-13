using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomModelBinderApp.Models
{
    public class CustomModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            int EmpId = Convert.ToInt32(controllerContext.HttpContext.Request.Form["Id"]);
            string Name = controllerContext.HttpContext.Request.Form["Name"];
            string DoorNum = controllerContext.HttpContext.Request.Form["DoorNum"];
            string Street = controllerContext.HttpContext.Request.Form["Street"];
            string Place = controllerContext.HttpContext.Request.Form["Place"];

             

            Employee employee = new Employee()
            {
                Id = EmpId,
                Name = Name,
                Address = DoorNum + "," + Street + "," + Place

            };

            return employee;
        }
    }
}
