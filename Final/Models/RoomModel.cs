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
    
    public partial class RoomModel
    {
        [Key]
        public int Room_ID { get; set; }
        public string Facility_ID { get; set; }
        public string Description { get; set; }
        public int RoomCap { get; set; }
    }
}
