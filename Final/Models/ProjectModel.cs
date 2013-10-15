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
    
    public partial class ProjectModel
    {
        //public ProjectModel()
        //{
        //    this.UATModels = new HashSet<UATModel>();
        //}
        
        [Key]
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }
    
        public virtual UserModel UserModel { get; set; }
        public virtual ICollection<UATModel> UATModels { get; set; }
    }
}
