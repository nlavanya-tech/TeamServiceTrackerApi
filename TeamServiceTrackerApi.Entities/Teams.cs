using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeamServiceTrackerApi.Entities
{
    public class Teams
    {
        [Key]
        public String TeamName { get; set; }
        public String TeamManager { get; set; }
        public String DomainOfWork { get; set; }
        public String TeamMembers { get; set; }
    }
}
