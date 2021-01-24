using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class ContactU
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
