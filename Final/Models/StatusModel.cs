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
    
    public partial class StatusModel
    {
        //public StatusModel()
        //{
        //    this.TestCaseModels = new HashSet<TestCaseModel>();
        //    this.UATModels = new HashSet<UATModel>();
        //}
    
        [Key]
        public int StatusD { get; set; }
        public string StatusType { get; set; }
    
        public virtual ICollection<TestCaseModel> TestCaseModels { get; set; }
        public virtual ICollection<UATModel> UATModels { get; set; }
    }
}
