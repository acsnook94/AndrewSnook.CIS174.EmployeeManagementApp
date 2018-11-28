namespace AndrewSnook.CIS174.EmployeeManagementApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedErrorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ErrorDateTime = c.DateTime(),
                        ErrorMessage = c.String(),
                        StackTrace = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Errors");
        }
    }
}
