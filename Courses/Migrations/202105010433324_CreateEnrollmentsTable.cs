namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEnrollmentsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        AdmissionCodeId = c.Int(nullable: false),
                        CourseId = c.Byte(nullable: false),
                        MajorId = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                        EnrolledIndicator = c.Boolean(nullable: false),
                        PaymentIndicator = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdmissionTermCodes", t => t.AdmissionCodeId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Majors", t => t.MajorId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.AdmissionCodeId)
                .Index(t => t.CourseId)
                .Index(t => t.MajorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "Id", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "MajorId", "dbo.Majors");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Enrollments", "AdmissionCodeId", "dbo.AdmissionTermCodes");
            DropIndex("dbo.Enrollments", new[] { "MajorId" });
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            DropIndex("dbo.Enrollments", new[] { "AdmissionCodeId" });
            DropIndex("dbo.Enrollments", new[] { "Id" });
            DropTable("dbo.Enrollments");
        }
    }
}
