using AndrewSnook.CIS174.EmployeeManagementApp.Api;
using AndrewSnook.CIS174.EmployeeManagementApp.Web.App_Start;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }

    }
}
