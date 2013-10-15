namespace Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10713 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseModels",
                c => new
                    {
                        C_Num = c.Int(nullable: false, identity: true),
                        C_Name = c.String(),
                        C_Section = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.C_Num);
            
            CreateTable(
                "dbo.DepartmentModels",
                c => new
                    {
                        D_ID = c.Int(nullable: false, identity: true),
                        D_Name = c.String(),
                    })
                .PrimaryKey(t => t.D_ID);
            
            CreateTable(
                "dbo.ProjectModels",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID)
                .ForeignKey("dbo.UserModels", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Password = c.String(),
                        RoleID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.RoleModels", t => t.RoleID)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.RoleModels",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.UATModels",
                c => new
                    {
                        UATID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Version = c.String(),
                        Intro = c.String(),
                        Started = c.DateTime(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ProjectID = c.Int(nullable: false),
                        StatusD = c.Int(),
                    })
                .PrimaryKey(t => t.UATID)
                .ForeignKey("dbo.ProjectModels", t => t.ProjectID, cascadeDelete: true)
                .ForeignKey("dbo.StatusModels", t => t.StatusD)
                .Index(t => t.ProjectID)
                .Index(t => t.StatusD);
            
            CreateTable(
                "dbo.StatusModels",
                c => new
                    {
                        StatusD = c.Int(nullable: false, identity: true),
                        StatusType = c.String(),
                    })
                .PrimaryKey(t => t.StatusD);
            
            CreateTable(
                "dbo.TestCaseModels",
                c => new
                    {
                        TestCaseID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Steps = c.String(),
                        Comments = c.String(),
                        StatusD = c.Int(),
                        UATID = c.Int(),
                    })
                .PrimaryKey(t => t.TestCaseID)
                .ForeignKey("dbo.StatusModels", t => t.StatusD)
                .ForeignKey("dbo.UATModels", t => t.UATID)
                .Index(t => t.StatusD)
                .Index(t => t.UATID);
            
            CreateTable(
                "dbo.RoomModels",
                c => new
                    {
                        R_ID = c.Int(nullable: false, identity: true),
                        R_Name = c.String(),
                    })
                .PrimaryKey(t => t.R_ID);
            
            CreateTable(
                "dbo.TeacherModels",
                c => new
                    {
                        T_ID = c.Int(nullable: false, identity: true),
                        T_FName = c.String(),
                        T_LName = c.String(),
                    })
                .PrimaryKey(t => t.T_ID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.TestCaseModels", new[] { "UATID" });
            DropIndex("dbo.TestCaseModels", new[] { "StatusD" });
            DropIndex("dbo.UATModels", new[] { "StatusD" });
            DropIndex("dbo.UATModels", new[] { "ProjectID" });
            DropIndex("dbo.UserModels", new[] { "RoleID" });
            DropIndex("dbo.ProjectModels", new[] { "UserID" });
            DropForeignKey("dbo.TestCaseModels", "UATID", "dbo.UATModels");
            DropForeignKey("dbo.TestCaseModels", "StatusD", "dbo.StatusModels");
            DropForeignKey("dbo.UATModels", "StatusD", "dbo.StatusModels");
            DropForeignKey("dbo.UATModels", "ProjectID", "dbo.ProjectModels");
            DropForeignKey("dbo.UserModels", "RoleID", "dbo.RoleModels");
            DropForeignKey("dbo.ProjectModels", "UserID", "dbo.UserModels");
            DropTable("dbo.TeacherModels");
            DropTable("dbo.RoomModels");
            DropTable("dbo.TestCaseModels");
            DropTable("dbo.StatusModels");
            DropTable("dbo.UATModels");
            DropTable("dbo.RoleModels");
            DropTable("dbo.UserModels");
            DropTable("dbo.ProjectModels");
            DropTable("dbo.DepartmentModels");
            DropTable("dbo.CourseModels");
        }
    }
}
