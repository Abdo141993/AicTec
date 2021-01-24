using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class Dlcontent
    {
        public int Id { get; set; }
        public string LapleName { get; set; }
        public string LapleNameAr { get; set; }
        public string DownloadSize { get; set; }
        public DateTime DateTime { get; set; }
        public string DownloadPath { get; set; }
        public string Img { get; set; }
        public int DownloadingLapleId { get; set; }

        public virtual DownloadLaple DownloadingLaple { get; set; }
    }
}
