﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.AboutDtos
{
    public class GetAboutDto
    {
        public int AboutId { get; set; }
        public string AboutUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}