using AndrewSnook.CIS174.EmployeeManagementApp.Web.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }

    }
}
