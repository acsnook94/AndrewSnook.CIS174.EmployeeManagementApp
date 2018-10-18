using AndrewSnook.CIS174.EmployeeManagementApp.Domain.Entities;
using System.Data.Entity;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Domain
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
