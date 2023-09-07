﻿using System.ComponentModel;

namespace FluxPlanner.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [DefaultValue("WFH")]
        public string WorkLocation { get; set; }
    }

}
