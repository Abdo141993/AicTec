using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class NewsLetter
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string TitleEn { get; set; }
        public string TitleAr { get; set; }
        public string Imageurl { get; set; }
        public string ParagraphEn { get; set; }
        public string ParagraphAr { get; set; }
        public string NewsLetterLink { get; set; }
    }
}
