using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserModel
    {
        //public UserModel()
        //{
        //    this.ProjectModels = new HashSet<ProjectModel>();
        //}
    
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleID { get; set; }
    
        public virtual ICollection<ProjectModel> ProjectModels { get; set; }
        public virtual RoleModel RoleModel { get; set; }
    }
}
