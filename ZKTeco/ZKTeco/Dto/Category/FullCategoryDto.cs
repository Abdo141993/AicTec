using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Dtos.Product;

namespace ZKTeco.Dtos.Category
{
    public class FullCategoryDto : CategoryDto
    {
        public CategoryDto ParentCategory { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
