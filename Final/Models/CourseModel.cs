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
        public int Class_Nbr { get; set; }
        public string Subject { get; set; }
        public int Catalog_Nbr { get; set; }
        public string Section { get; set; }
        public int Enroll_Cap { get; set; }
        public int Total_Enroll { get; set; }
        public Nullable<int> MeetingPatternID { get; set; }

        //public string Meeting_Pattern { get; set; }
        //public string Mtg_Start { get; set; }
        //public string Mtg_End { get; set; }
        //public string CLass_Stat { get; set; }
        //public Nullable<int> Time_ID { get; set; }

        //public virtual TimeModel TimeModel { get; set; }

        public virtual MeetingPatternModel MeetingPatternModel { get; set; }

    }
}
