/** =========================================================

 Andrew Snook

 Operating System: Windows 10

 Microsoft Visual Studio 2017 Enterprise

 CIS 174

 EmployeeManagement (Week 5)

 Program Description: This application allows the user to view and create database records containing employee information

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/


using AndrewSnook.CIS174.EmployeeManagementApp.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Domain
{
    public class EmployeeContext : IdentityDbContext<AppUser>
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
