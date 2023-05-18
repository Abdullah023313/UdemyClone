﻿using Microsoft.AspNetCore.Identity;
using Models.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Identity
{
    public class ApplicationUserRole : IdentityUserRole<int>
    {

        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
