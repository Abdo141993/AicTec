using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class FooterSubTitle
    {
        public int Id { get; set; }
        public string SubTitleEn { get; set; }
        public string SubTitleAr { get; set; }
        public string Link { get; set; }
        public int FooterMainTitleId { get; set; }

        public virtual FooterMaintTitl FooterMainTitle { get; set; }
    }
}
