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
        public int T_ID { get; set; }
        public string T_FName { get; set; }
        public string T_LName { get; set; }
    }
}
