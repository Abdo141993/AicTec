using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZKTeco.Dto.AboutUs
{
    public class AboutUsWithFileForm : AboutUsDto
    {
        public IFormFile photourlFormFile { get; set; }
    }
}
