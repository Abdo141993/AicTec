using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class OnlineSupport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Comment { get; set; }
        public string ProductModelNumber { get; set; }
        public string Code { get; set; }
        public string CustomerType { get; set; }
    }
}
