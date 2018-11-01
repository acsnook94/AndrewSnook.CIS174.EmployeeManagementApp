namespace AndrewSnook.CIS174.EmployeeManagementApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationAfterUnitTestAssignment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "HireDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "BirthDate", c => c.DateTime());
            AlterColumn("dbo.Employees", "HireDate", c => c.DateTime());
        }
    }
}
