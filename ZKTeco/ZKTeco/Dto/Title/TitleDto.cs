using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZKTeco.Dtos.Title
{
    public class TitleDto
    {
        public int Id { get; set; }
        [DisplayName("Arabic Title Name")]
        [Required]
        public string TitleNameAr { get; set; }
        [DisplayName("English Title Name")]
        [Required]
        public string TitleNameEn { get; set; }
        [DisplayName("Arabic content")]
        [Required]
        public string ContentInAr { get; set; }
        [DisplayName("English content")]
        [Required]
        public string ContentInEn { get; set; }
        public int ProductId { get; set; }
    }
}
