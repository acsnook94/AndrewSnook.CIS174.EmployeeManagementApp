using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AndrewSnook.CIS174.EmployeeManagementApp.Web.Startup))]
namespace AndrewSnook.CIS174.EmployeeManagementApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}