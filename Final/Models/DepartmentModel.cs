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
    
    public partial class DepartmentModel
    {
        [Key]
        public int D_ID { get; set; }
        public string D_Name { get; set; }
    }
}
