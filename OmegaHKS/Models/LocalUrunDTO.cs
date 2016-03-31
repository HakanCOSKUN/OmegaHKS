using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaHKS.Models
{
    public class LocalUrunDTO
    {
        public int STKKOD { get; set; }
        public string STOKAD { get; set; }
        public int REYON { get; set; }
        public string REYONAD { get; set; }
        public string AKTIF { get; set; }
        public string BARKOD { get; set; }
        public int UrunCinsiId { get; set; }
        public int UrunId { get; set; }
        public int UretimSekilId { get; set; }
        public int UrunKodu { get; set; }
        public string Ithalmi { get; set; }
    }
}
