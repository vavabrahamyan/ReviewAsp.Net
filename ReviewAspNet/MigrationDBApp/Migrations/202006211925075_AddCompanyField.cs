namespace MigrationDBApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Company_Id", c => c.Int());
            CreateIndex("dbo.Users", "Company_Id");
            AddForeignKey("dbo.Users", "Company_Id", "dbo.Companies", "Id");
            DropColumn("dbo.Users", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Age", c => c.Int(nullable: false));
            DropForeignKey("dbo.Users", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Users", new[] { "Company_Id" });
            DropColumn("dbo.Users", "Company_Id");
        }
    }
}
