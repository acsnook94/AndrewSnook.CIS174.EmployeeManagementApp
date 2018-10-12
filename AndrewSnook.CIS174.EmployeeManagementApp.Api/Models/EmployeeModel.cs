using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Api.Models
{
    public enum SalaryType
    {
        Hourly,
        Annual
    };

    public class EmployeeModel
    {
        public Guid EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal Salary { get; set; }
        public SalaryType SalaryType { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string AvailableHours { get; set; }
    }
}