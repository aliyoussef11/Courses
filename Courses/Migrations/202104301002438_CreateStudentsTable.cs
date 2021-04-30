namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudentsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        FirstName = c.String(maxLength: 60),
                        LastName = c.String(maxLength: 60),
                        AdmissionCodeId = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        MajorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdmissionTermCodes", t => t.AdmissionCodeId, cascadeDelete: true)
                .ForeignKey("dbo.Majors", t => t.MajorId, cascadeDelete: true)
                .Index(t => t.AdmissionCodeId)
                .Index(t => t.MajorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "MajorId", "dbo.Majors");
            DropForeignKey("dbo.Students", "AdmissionCodeId", "dbo.AdmissionTermCodes");
            DropIndex("dbo.Students", new[] { "MajorId" });
            DropIndex("dbo.Students", new[] { "AdmissionCodeId" });
            DropTable("dbo.Students");
        }
    }
}
