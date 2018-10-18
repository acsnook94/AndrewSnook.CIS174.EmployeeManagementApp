namespace AndrewSnook.CIS174.EmployeeManagementApp.Domain.Migrations
{
    using AndrewSnook.CIS174.EmployeeManagementApp.Domain.Entities;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AndrewSnook.CIS174.EmployeeManagementApp.Domain.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AndrewSnook.CIS174.EmployeeManagementApp.Domain.EmployeeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Employees.AddOrUpdate(x => x.EmployeeId,
                new Employee()
                {
                    FirstName = "Andrew",
                    MiddleInitial = "C",
                    LastName = "Snook",
                    HireDate = new DateTime(2018, 05, 23),
                    BirthDate = new DateTime(1994, 08, 18),
                    Salary = 18,
                    SalaryType = SalaryType.Hourly,
                    EmployeeId = Guid.Parse("ed229a89-f8b0-4bfa-9083-af1105fb651b"),
                    JobTitle = "Intern",
                    Department = "IT",
                    AvailableHours = "M-F 12:00AM-11:59PM"
                });
        }
    }
}
