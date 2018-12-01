using System;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels
{
    public class SingleEmpViewModel
    {
        public string EmpFirst {get; set; }
        public string EmpMiddle {get; set; }
        public string EmpLast {get; set; }
        public DateTime? EmpBirthDate {get; set;}
        public string EmpDept {get; set; }
    }
}
