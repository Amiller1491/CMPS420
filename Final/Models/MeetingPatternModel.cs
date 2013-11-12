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

    public partial class MeetingPatternModel
    {

        [Key]
        public int MeetingPatternID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CourseModel> CourseModels { get; set; }
    }
}
