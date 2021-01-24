using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class Config
    {
        public int Id { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Google { get; set; }
        public string LinkedIn { get; set; }
        public string Youtube { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Fax { get; set; }
        public string Location { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string OurProductTitleEn { get; set; }
        public string OurProductTitleAr { get; set; }
        public string SupportTitleEn { get; set; }
        public string SupportTitleAr { get; set; }
        public string FooterTextEn { get; set; }
        public string FooterTextAr { get; set; }
        public string FooterLink { get; set; }
        public string SupportParagraphTitleEn { get; set; }
        public string SupportParagraphTitleAr { get; set; }
        public string SupportParagraphEn { get; set; }
        public string SupportParagraphAr { get; set; }
        public string OurClientsTitleEn { get; set; }
        public string OurClientsTitleAr { get; set; }
        public string LogoUrl { get; set; }
    }
}
