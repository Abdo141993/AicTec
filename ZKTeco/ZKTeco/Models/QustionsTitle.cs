using System;
using System.Collections.Generic;

#nullable disable

namespace ZKTeco.Models
{
    public partial class QustionsTitle
    {
        public QustionsTitle()
        {
            QustionAnswers = new HashSet<QustionAnswer>();
        }

        public int Id { get; set; }
        public string TitleEn { get; set; }
        public string TitleAr { get; set; }

        public virtual ICollection<QustionAnswer> QustionAnswers { get; set; }
    }
}
