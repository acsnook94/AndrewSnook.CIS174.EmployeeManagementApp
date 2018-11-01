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


using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;
using System.Collections.Generic;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Web.Models
{
    public class EmployeeDisplayModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
    }
}