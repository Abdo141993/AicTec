using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class QustionAnswer
    {
        public int Id { get; set; }
        public string QustionEn { get; set; }
        public string QustionAr { get; set; }
        public string AnswerEn { get; set; }
        public string AnswerAr { get; set; }
        public int TitleId { get; set; }

        public virtual QustionsTitle Title { get; set; }
    }
}
