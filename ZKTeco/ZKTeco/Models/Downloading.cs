using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class Downloading
    {
        public Downloading()
        {
            DownloadLaples = new HashSet<DownloadLaple>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }

        public virtual ICollection<DownloadLaple> DownloadLaples { get; set; }
    }
}
