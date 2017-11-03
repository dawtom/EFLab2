namespace ConsoleApp3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinishPt31 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CompanyName = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CompanyName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
