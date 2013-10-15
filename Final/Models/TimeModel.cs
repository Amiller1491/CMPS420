using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class TimeModel
    {
        [Key]
        public int Time_ID { get; set; }
        public string Time_Slot { get; set; }

        //public virtual ICollection<CourseModel> CourseModels { get; set; }
    }
}