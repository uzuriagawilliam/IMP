using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustriellMaskinPark.Shared
{
    public class Maskin : Imaskin
    {
        public int MaskinId { get; set; }
        public string Namn { get; set; }
        public Start lagge { get; set; }
        public Status MStatus { get; set; }
        public string Data { get; set; }
        public Hastighet MHastighet { get; set; }
        public string Kommando { get; set; }
    }
}
