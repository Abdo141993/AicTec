using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class FooterMaintTitl
    {
        public FooterMaintTitl()
        {
            FooterSubTitles = new HashSet<FooterSubTitle>();
        }

        public int Id { get; set; }
        public string MainTitleEn { get; set; }
        public string MainTitleAr { get; set; }

        public virtual ICollection<FooterSubTitle> FooterSubTitles { get; set; }
    }
}
