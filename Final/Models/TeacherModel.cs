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
    
    public partial class TeacherModel
    {
        [Key]
        public int Instructor_ID { get; set; }
        public string Instructor_FName { get; set; }
        public string Instructor_LName { get; set; }
    }
}
