using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class DownloadLaple
    {
        public DownloadLaple()
        {
            Dlcontents = new HashSet<Dlcontent>();
        }

        public int Id { get; set; }
        public string LapleName { get; set; }
        public string LapleNameAr { get; set; }
        public int DownloadingId { get; set; }

        public virtual Downloading Downloading { get; set; }
        public virtual ICollection<Dlcontent> Dlcontents { get; set; }
    }
}
