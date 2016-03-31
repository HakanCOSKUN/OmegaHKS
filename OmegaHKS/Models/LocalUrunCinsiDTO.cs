using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaHKS.Models
{
    internal class LocalUrunCinsiDTO
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public int UrunKodu { get; set; }
        public int UretimSekilId { get; set; }
        public string UrunCinsiAdi { get; set; }
        public string UretimSekiliAdi { get; set; }
        public char Ithalmi { get; set; }
        public int STKKOD { get; set; }
    }
}
