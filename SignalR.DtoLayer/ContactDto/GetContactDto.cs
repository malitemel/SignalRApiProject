﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ContactDto
{
    public class GetContactDto
    {
        public int ContactId { get; set; }
        public string Location { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
