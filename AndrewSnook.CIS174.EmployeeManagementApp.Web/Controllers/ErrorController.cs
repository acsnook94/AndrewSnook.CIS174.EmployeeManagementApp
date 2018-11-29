using System;
using System.Web.Mvc;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Web.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult AppError()
        {
            Exception ex = HttpContext.Server.GetLastError();
            return View();
        }
    }
}