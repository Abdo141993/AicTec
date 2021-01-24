using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class Title
    {
        public int Id { get; set; }
        public string TitleNameAr { get; set; }
        public string TitleNameEn { get; set; }
        public string ContentInAr { get; set; }
        public string ContentInEn { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
