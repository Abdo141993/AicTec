using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
