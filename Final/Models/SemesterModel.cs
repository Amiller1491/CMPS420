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

    public partial class SemesterModel
    {
        [Key]
        public int SemID { get; set; }
        public string SemName { get; set; }
        public int SemYear { get; set; }

        public virtual ICollection<CourseModel> CourseModels { get; set; }
    }
}