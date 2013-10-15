using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ScheduleContext : DbContext
    {
       // public ScheduleContext()
        //    : base("name=ScheduleContext")
        //{
       // }
    
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}
    
        //public DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public DbSet<CourseModel> Course { get; set; }
        public DbSet<DepartmentModel> Department { get; set; }
        public DbSet<ProjectModel> Project { get; set; }
        public DbSet<RoleModel> Role { get; set; }
        public DbSet<RoomModel> Room { get; set; }
        public DbSet<StatusModel> Status { get; set; }
        public DbSet<TeacherModel> Teacher { get; set; }
        public DbSet<TestCaseModel> TestCase { get; set; }
        public DbSet<UATModel> UAT { get; set; }
        public DbSet<UserModel> User { get; set; }

        public DbSet<SemesterModel> Semester { get; set; }
    }
}
