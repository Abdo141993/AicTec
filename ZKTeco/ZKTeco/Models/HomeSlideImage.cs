using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class HomeSlideImage
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string TextEn { get; set; }
        public string TextAr { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }
    }
}
