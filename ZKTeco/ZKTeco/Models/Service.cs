using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class Service
    {
        public Service()
        {
            InverseParentService = new HashSet<Service>();
        }

        public int Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string ContentAr { get; set; }
        public string ContentEn { get; set; }
        public string ImgUrl { get; set; }
        public int? ParentServiceId { get; set; }

        public virtual Service ParentService { get; set; }
        public virtual ICollection<Service> InverseParentService { get; set; }
    }
}
