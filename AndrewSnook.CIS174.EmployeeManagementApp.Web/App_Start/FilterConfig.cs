using System.Web.Mvc;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Web.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}