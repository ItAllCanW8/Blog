﻿using Microsoft.AspNetCore.Identity;

namespace Blog.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        public string SubHeader { get; set; }
        public string AboutConent { get; set; }
    }
}
