namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDAdmissionCodesTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT AdmissionTermCodes ON");

            //Seeding the AdmissionTermCodes Table
            Sql("insert into AdmissionTermCodes(AdmissionCodeId, Semester) values (202110, 'Fall of 2021')");
            Sql("insert into AdmissionTermCodes(AdmissionCodeId, Semester) values (202120, 'Spring of 2021')");
        }
        
        public override void Down()
        {
        }
    }
}
