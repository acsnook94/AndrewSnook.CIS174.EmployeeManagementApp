using Microsoft.AspNet.Identity.EntityFramework;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Domain
{
    public class AppRole : IdentityRole
    {
        public AppRole() : base(){ }
        public AppRole(string name) : base(name){ }
        //Put props here
    }
}