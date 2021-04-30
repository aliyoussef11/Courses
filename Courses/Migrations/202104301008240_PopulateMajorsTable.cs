namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMajorsTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Majors ON");

            //Seeding the Majors Table
            Sql("insert into Majors(MajorId, Name) values (1, 'Computing')");
            Sql("insert into Majors(MajorId, Name) values (2, 'Security')");
        }
        
        public override void Down()
        {
        }
    }
}
