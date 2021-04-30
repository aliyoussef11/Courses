namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HelperMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 60));
            AlterColumn("dbo.Students", "FirstName", c => c.String(maxLength: 60));
        }
    }
}
