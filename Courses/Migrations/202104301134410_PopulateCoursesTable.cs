namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCoursesTable : DbMigration
    {
        public override void Up()
        {
            //Seeding the Courses Table
            Sql("insert into Courses(CourseId, CourseName, Credits, DepartmentId) values (1, 'Application Dev', 3, 1)");
            Sql("insert into Courses(CourseId, CourseName, Credits, DepartmentId) values (2, 'Marketing', 3, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
