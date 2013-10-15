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
    
    public partial class RoleModel
    {
        //public RoleModel()
        //{
        //    this.UserModels = new HashSet<UserModel>();
        //}
    
        [Key]
        public int RoleID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<UserModel> UserModels { get; set; }
    }
}
