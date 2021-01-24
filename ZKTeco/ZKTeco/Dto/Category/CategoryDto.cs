using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZKTeco.Dtos.Category
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [DisplayName("Category Name Arabic")]
        [Required]
        public string CategoryNameArabic { get; set; }
        [DisplayName("Category Name English")]
        [Required]
        public string CategoryNameEnglish { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        [DisplayName("ParentName")]
        public int? ParentCategoryId { get; set; }
    }
}
