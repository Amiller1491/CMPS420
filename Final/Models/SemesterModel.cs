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
        public int Term_ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public virtual ICollection<CourseModel> CourseModels { get; set; }
    }
}