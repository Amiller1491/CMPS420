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
    
    public partial class UATModel
    {
        //public UATModel()
        //{
        //    this.TestCaseModels = new HashSet<TestCaseModel>();
        //}
    
        [Key]
        public int UATID { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Intro { get; set; }
        public System.DateTime Started { get; set; }
        public System.DateTime LastModified { get; set; }
        public int ProjectID { get; set; }
        public Nullable<int> StatusD { get; set; }
    
        public virtual ProjectModel ProjectModel { get; set; }
        public virtual StatusModel StatusModel { get; set; }
        public virtual ICollection<TestCaseModel> TestCaseModels { get; set; }
    }
}
