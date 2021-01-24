using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Dtos.Category;
using ZKTeco.Dtos.ProductImage;
using ZKTeco.Dtos.Title;

namespace ZKTeco.Dtos.Product
{
    public class FullProductDto : ProductDto
    {
        public CategoryDto Category { get; set; }
        public List<ProductImageDto> ProductImages { get; set; }
        public List<TitleDto> Titles { get; set; }
    }
}
