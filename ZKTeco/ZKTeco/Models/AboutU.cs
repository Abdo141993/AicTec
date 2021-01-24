using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class AboutU
    {
        public int Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string SubtitleAr { get; set; }
        public string SubtitleEn { get; set; }
        public string ParagraphAr { get; set; }
        public string ParagraphEn { get; set; }
        public string Photourl { get; set; }
    }
}
