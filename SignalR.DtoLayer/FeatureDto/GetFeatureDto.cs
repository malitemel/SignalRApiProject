using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.FeatureDto
{
    public class GetFeatureDto
    {
        public int FeatureId { get; set; }
        public int Title1 { get; set; }
        public int Descripton1 { get; set; }
        public int Title2 { get; set; }
        public int Descripton2 { get; set; }
        public int Title3 { get; set; }
        public int Descripton3 { get; set; }
    }
}
