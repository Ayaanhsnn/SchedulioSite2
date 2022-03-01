using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedulioSite2.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Fullname { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }
    }
}