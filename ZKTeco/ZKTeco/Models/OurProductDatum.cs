using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class OurProductDatum
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string TextEn { get; set; }
        public string TextAr { get; set; }
        public string SubTextEn { get; set; }
        public string SubTextAr { get; set; }
    }
}
