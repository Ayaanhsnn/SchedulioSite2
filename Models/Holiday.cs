using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedulioSite2.Models
{
    public class Holiday
    {
        public int Id { get; set; }
        public DateTime HolidayStartDate { get; set; }
        public DateTime HolidayEndDate { get; set; }
        public int EmployeeId { get; set; }
    }
}