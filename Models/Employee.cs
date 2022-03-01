using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedulioSite2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Fullname { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public int DepartmentID { get; set; }

        public bool isWeekend { get; set; }

        public bool isHoliday { get; set; }
    }
}