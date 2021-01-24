using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Dtos.Product;

namespace ZKTeco.Dtos.Title
{
    public class FullTitleDto : TitleDto
    {
        public ProductDto ProductItem { get; set; }
    }
}
