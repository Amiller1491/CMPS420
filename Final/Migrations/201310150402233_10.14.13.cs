namespace Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _101413 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CourseModels", "SemesterModel_SemID", "dbo.SemesterModels");
            DropIndex("dbo.CourseModels", new[] { "SemesterModel_SemID" });
            RenameColumn(table: "dbo.CourseModels", name: "SemesterModel_SemID", newName: "SemesterModel_Term_ID");
            AddColumn("dbo.CourseModels", "Subject", c => c.String());
            AddColumn("dbo.CourseModels", "Catalog_Nbr", c => c.Int(nullable: false));
            AddColumn("dbo.CourseModels", "Enroll_Cap", c => c.Int(nullable: false));
            AddColumn("dbo.CourseModels", "Total_Enroll", c => c.Int(nullable: false));
            AddColumn("dbo.CourseModels", "CLass_Stat", c => c.String());
            AddColumn("dbo.RoomModels", "Description", c => c.String());
            AddColumn("dbo.RoomModels", "RoomCap", c => c.Int(nullable: false));
            AddColumn("dbo.TeacherModels", "Instructor_FName", c => c.String());
            AddColumn("dbo.TeacherModels", "Instructor_LName", c => c.String());
            AddColumn("dbo.SemesterModels", "Name", c => c.String());
            AddColumn("dbo.SemesterModels", "Year", c => c.Int(nullable: false));

            DropPrimaryKey("dbo.CourseModels", new[] { "C_Num" });
            DropColumn("dbo.CourseModels", "C_Num");
            AddColumn("dbo.CourseModels", "Class_Nbr", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CourseModels", "Class_Nbr");
           

            DropPrimaryKey("dbo.RoomModels", new[] { "R_ID" });
            DropColumn("dbo.RoomModels", "R_ID");
            AddColumn("dbo.RoomModels", "Room_ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.RoomModels", "Room_ID");


            DropPrimaryKey("dbo.TeacherModels", new[] { "T_ID" });
            DropColumn("dbo.TeacherModels", "T_ID");
            AddColumn("dbo.TeacherModels", "Instructor_ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TeacherModels", "Instructor_ID");


            DropPrimaryKey("dbo.SemesterModels", new[] { "SemID" });
            DropColumn("dbo.SemesterModels", "SemID");
            AddColumn("dbo.SemesterModels", "Term_ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.SemesterModels", "Term_ID");


            AddForeignKey("dbo.CourseModels", "SemesterModel_Term_ID", "dbo.SemesterModels", "Term_ID");
            CreateIndex("dbo.CourseModels", "SemesterModel_Term_ID");
           
            DropColumn("dbo.CourseModels", "C_Name");
            DropColumn("dbo.CourseModels", "C_Section");
            DropColumn("dbo.RoomModels", "R_Name");
            DropColumn("dbo.TeacherModels", "T_FName");
            DropColumn("dbo.TeacherModels", "T_LName");
            DropColumn("dbo.SemesterModels", "SemName");
            DropColumn("dbo.SemesterModels", "SemYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SemesterModels", "SemYear", c => c.Int(nullable: false));
            AddColumn("dbo.SemesterModels", "SemName", c => c.String());
            AddColumn("dbo.SemesterModels", "SemID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.TeacherModels", "T_LName", c => c.String());
            AddColumn("dbo.TeacherModels", "T_FName", c => c.String());
            AddColumn("dbo.TeacherModels", "T_ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.RoomModels", "R_Name", c => c.String());
            AddColumn("dbo.RoomModels", "R_ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CourseModels", "C_Section", c => c.Int(nullable: false));
            AddColumn("dbo.CourseModels", "C_Name", c => c.String());
            AddColumn("dbo.CourseModels", "C_Num", c => c.Int(nullable: false, identity: true));
            DropIndex("dbo.CourseModels", new[] { "SemesterModel_Term_ID" });
            DropForeignKey("dbo.CourseModels", "SemesterModel_Term_ID", "dbo.SemesterModels");
            DropPrimaryKey("dbo.SemesterModels", new[] { "Term_ID" });
            AddPrimaryKey("dbo.SemesterModels", "SemID");
            DropPrimaryKey("dbo.TeacherModels", new[] { "Instructor_ID" });
            AddPrimaryKey("dbo.TeacherModels", "T_ID");
            DropPrimaryKey("dbo.RoomModels", new[] { "Room_ID" });
            AddPrimaryKey("dbo.RoomModels", "R_ID");
            DropPrimaryKey("dbo.CourseModels", new[] { "Class_Nbr" });
            AddPrimaryKey("dbo.CourseModels", "C_Num");
            DropColumn("dbo.SemesterModels", "Year");
            DropColumn("dbo.SemesterModels", "Name");
            DropColumn("dbo.SemesterModels", "Term_ID");
            DropColumn("dbo.TeacherModels", "Instructor_LName");
            DropColumn("dbo.TeacherModels", "Instructor_FName");
            DropColumn("dbo.TeacherModels", "Instructor_ID");
            DropColumn("dbo.RoomModels", "RoomCap");
            DropColumn("dbo.RoomModels", "Description");
            DropColumn("dbo.RoomModels", "Room_ID");
            DropColumn("dbo.CourseModels", "CLass_Stat");
            DropColumn("dbo.CourseModels", "Total_Enroll");
            DropColumn("dbo.CourseModels", "Enroll_Cap");
            DropColumn("dbo.CourseModels", "Catalog_Nbr");
            DropColumn("dbo.CourseModels", "Subject");
            DropColumn("dbo.CourseModels", "Class_Nbr");
            RenameColumn(table: "dbo.CourseModels", name: "SemesterModel_Term_ID", newName: "SemesterModel_SemID");
            CreateIndex("dbo.CourseModels", "SemesterModel_SemID");
            AddForeignKey("dbo.CourseModels", "SemesterModel_SemID", "dbo.SemesterModels", "SemID");
        }
    }
}
