namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationToCourse : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "CourseId", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Courses", "CourseId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "CourseId", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Courses", "CourseId");
        }
    }
}
