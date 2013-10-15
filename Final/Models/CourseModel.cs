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
    
    public partial class CourseModel
    {
        [Key]
        public int C_Num { get; set; }
        public string C_Name { get; set; }
        public int C_Section { get; set; }
    }
}
