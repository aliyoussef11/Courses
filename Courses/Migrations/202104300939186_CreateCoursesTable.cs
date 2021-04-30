namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCoursesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Byte(nullable: false),
                        CourseName = c.String(),
                        Credits = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropTable("dbo.Courses");
        }
    }
}
