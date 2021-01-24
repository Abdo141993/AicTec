using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Dtos.Product;

namespace ZKTeco.Dtos.ProductImage
{
    public class FullProductImageDto : ProductImageDto
    {
        public ProductDto ProductItem { get; set; }
    }
}
