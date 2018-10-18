using System;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Domain.Entities
{
    public enum SalaryType
    {
        Hourly = 1,
        Annual = 2
    };

    public class Employee
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; } 
        public string LastName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal Salary { get; set; }
        public SalaryType SalaryType { get; set; }
        public Guid EmployeeId { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string AvailableHours { get; set; }

    }
}
