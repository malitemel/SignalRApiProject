using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ContactDto
{
    public class CreateContactDto
    {
        public string Location { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
