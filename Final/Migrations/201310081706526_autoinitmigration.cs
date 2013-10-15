namespace Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class autoinitmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SemesterModels", "TeacherModel_T_ID", "dbo.TeacherModels");
            DropIndex("dbo.SemesterModels", new[] { "TeacherModel_T_ID" });
            DropColumn("dbo.SemesterModels", "TeacherModel_T_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SemesterModels", "TeacherModel_T_ID", c => c.Int());
            CreateIndex("dbo.SemesterModels", "TeacherModel_T_ID");
            AddForeignKey("dbo.SemesterModels", "TeacherModel_T_ID", "dbo.TeacherModels", "T_ID");
        }
    }
}
