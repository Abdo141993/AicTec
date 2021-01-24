using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductDownloads = new HashSet<ProductDownload>();
            ProductImages = new HashSet<ProductImage>();
            Titles = new HashSet<Title>();
        }

        public int Id { get; set; }
        public string ProductNameAr { get; set; }
        public string ProductNameEn { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<ProductDownload> ProductDownloads { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<Title> Titles { get; set; }
    }
}
