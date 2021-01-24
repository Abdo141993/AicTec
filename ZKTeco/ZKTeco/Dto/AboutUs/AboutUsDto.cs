using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZKTeco.Dto.AboutUs
{
    public class AboutUsDto
    {
        public int Id { get; set; }
        [DisplayName("Arabic Title")]
        [Required]
        public string titleAr { get; set; }
        [DisplayName("English Title")]
        [Required]
        public string titleEn { get; set; }
        [DisplayName("Arabic SubTitle")]
        [Required]
        public string subtitleAr { get; set; }
        [DisplayName("English SubTitle")]
        [Required]
        public string subtitleEn { get; set; }
        [DisplayName("Arabic Paragraph")]
        [Required]
        public string paragraphAr { get; set; }
        [DisplayName("English Paragraph")]
        [Required]
        public string paragraphEn { get; set; }
        public string photourl { get; set; }
    }
}
