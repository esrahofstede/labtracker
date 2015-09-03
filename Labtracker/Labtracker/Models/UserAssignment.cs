using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labtracker.Models
{
    public class UserAssignment
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Assignment Assignment { get; set; }
        public int Status { get; set; }
    }
}