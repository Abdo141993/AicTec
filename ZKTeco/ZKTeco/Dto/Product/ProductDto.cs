using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZKTeco.Dtos.Product
{
    public class ProductDto
    {
        public int Id { get; set; }
        [DisplayName("Product Name in Arabic")]
        [Required]
        public string ProductNameAr { get; set; }
        [DisplayName("Product Name in English")]
        [Required]
        public string ProductNameEn { get; set; }
        [DisplayName("Description in English")]
        [Required]
        public string DescriptionEn { get; set; }
        [DisplayName("Description in Arabic")]
        [Required]
        public string DescriptionAr { get; set; }
        public DateTime? CreatedAt { get; set; }
        [DisplayName("Parent Category")]
        public int? CategoryId { get; set; }
    }
}
