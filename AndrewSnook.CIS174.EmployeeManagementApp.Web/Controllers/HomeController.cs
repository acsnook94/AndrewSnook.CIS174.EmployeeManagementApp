using System.Web.Mvc;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //GET: AppError
        public ActionResult AppError()
        {
            return View();
        }
    }
}