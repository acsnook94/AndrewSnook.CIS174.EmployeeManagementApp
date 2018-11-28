using System;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Entities
{
    public class Error
    {
        public Guid ID {get;set;}
        public DateTime? ErrorDateTime {get;set;}
        public string ErrorMessage {get;set;}
        public string StackTrace {get;set;}
    }
}
