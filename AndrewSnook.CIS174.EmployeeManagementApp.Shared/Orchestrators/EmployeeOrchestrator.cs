﻿/** =========================================================

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


using AndrewSnook.CIS174.EmployeeManagementApp.Domain;
using AndrewSnook.CIS174.EmployeeManagementApp.Domain.Entities;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators.Interfaces;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators
{
    public class EmployeeOrchestrator : IEmployeeOrchestrator
    {
        private EmployeeContext _employeeContext;

        public EmployeeOrchestrator()
        {
            _employeeContext = new EmployeeContext();
        }

        public async Task<int> CreateEmployee(EmployeeViewModel employee)
        {
            _employeeContext.Employees.Add(new Employee
            {
                FirstName = employee.FirstName,
                MiddleInitial = employee.MiddleInitial,
                LastName = employee.LastName,
                HireDate = employee.HireDate,
                BirthDate = employee.BirthDate,
                Salary = employee.Salary,
                SalaryType = employee.SalaryType,
                EmployeeId=employee.EmployeeId,
                JobTitle = employee.JobTitle,
                Department = employee.Department,
                AvailableHours = employee.AvailableHours

            });

            return await _employeeContext.SaveChangesAsync();
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeContext.Employees.Select(x => new EmployeeViewModel
            {
                FirstName = x.FirstName,
                MiddleInitial = x.MiddleInitial,
                LastName = x.LastName,
                HireDate = x.HireDate,
                BirthDate = x.BirthDate,
                Salary = x.Salary,
                SalaryType = x.SalaryType,
                EmployeeId=x.EmployeeId,
                JobTitle = x.JobTitle,
                Department = x.Department,
                AvailableHours = x.AvailableHours
            }).ToListAsync();

            return employees;
        }
    }
}
