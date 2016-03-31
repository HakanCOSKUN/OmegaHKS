using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OmegaHKS.Models
{
    internal class LocalKunyeKayitBildirimSorguDTO : LocalBildirimSorguDTO
    {
        public long IRSNO { get; set; }
        public int DEPNO { get; set; }
        public string STKKOD { get; set; }
        public Int64 YeniKunye { get; set; }
        public DateTime IRSTARIHI { get; set; }
        public bool YazYazma { get; set; }
        public string UniqueId { get; set; }

    }
}
