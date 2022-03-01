using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedulioSite2.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime WorkStartTime { get; set; }
        public DateTime WorkEndTime { get; set; }
        public bool isCover { get; set; }
    }
}