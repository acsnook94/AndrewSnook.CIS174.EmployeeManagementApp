using Microsoft.AspNet.Identity.EntityFramework;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Web
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
    }
}