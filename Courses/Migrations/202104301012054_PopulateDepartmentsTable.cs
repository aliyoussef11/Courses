namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDepartmentsTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Departments ON");

            //Seeding the Departments Table
            Sql("insert into Departments(DepartmentId, DepartmentName) values (1, 'Production')");
            Sql("insert into Departments(DepartmentId, DepartmentName) values (2, 'Purchasing')");
            
        }
        
        public override void Down()
        {
        }
    }
}
