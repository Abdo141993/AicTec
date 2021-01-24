﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class AspNetUserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual AspNetRole Role { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}