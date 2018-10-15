﻿using AndrewSnook.CIS174.EmployeeManagementApp.Domain.Entities;
using System;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Web.Models
{
    public class CreateEmployeeModel
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