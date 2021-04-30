namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStudentsTable : DbMigration
    {
        public override void Up()
        {
     
            //Seeding the Students Table
            Sql("insert into Students(Id, FirstName, LastName, AdmissionCodeId, DateOfBirth, MajorId) " +
                "values (1, 'Ali', 'Youssef', 2,'1/1/2000', 1)");
            Sql("insert into Students(Id, FirstName, LastName, AdmissionCodeId, DateOfBirth, MajorId) " +
                "values (2, 'Amir', 'Youssef', 1,'1/1/1999', 2)");
        }
        
        public override void Down()
        {
        }
    }
}
