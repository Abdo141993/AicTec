using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class Training
    {
        public int Id { get; set; }
        public string YoutubeLink { get; set; }
        public string TitleEn { get; set; }
        public string TitleAr { get; set; }
    }
}
