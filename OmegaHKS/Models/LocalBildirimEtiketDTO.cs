using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaHKS.Models
{
    class LocalBildirimEtiketDTO :OmegaHKS.BildirimServiceReference.BildirimEtiketDTO
    {
        public string STKKOD { get; set; }
        public int DEPNO { get; set; }
        public string PlakaNo { get; set; }
        public string BelgeNo { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int BeldeId { get; set; }
        public bool YazYazma { get; set; }
        public string UniqueId { get; set; }
    }
}
