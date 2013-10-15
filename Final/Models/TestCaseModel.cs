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
    
    public partial class TestCaseModel
    {
        [Key]
        public int TestCaseID { get; set; }
        public string Title { get; set; }
        public string Steps { get; set; }
        public string Comments { get; set; }
        public Nullable<int> StatusD { get; set; }
        public Nullable<int> UATID { get; set; }
    
        public virtual StatusModel StatusModel { get; set; }
        public virtual UATModel UATModel { get; set; }
    }
}
