﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAndroid.DAL.Entities
{
    public class DbUserRole : IdentityUserRole<long>
    {
        public virtual DbUser User { get; set; }
        public virtual DbRole Role { get; set; }
    }
}
