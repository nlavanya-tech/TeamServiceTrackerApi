using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeamServiceTrackerApi.Entities
{
  public class Users
    {
        [Key]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String UserType { get; set; }
        public String Status { get; set; }
        public String InterviewStatus { get; set; }
        public String ReportingTo { get; set; }
        public String Mobile { get; set; }

    }
}
