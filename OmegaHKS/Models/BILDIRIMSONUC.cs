using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OmegaHKS.Models
{
    internal class BILDIRIMSONUC
    {
        public IList<OmegaHKS.BildirimServiceReference.BildirimKayitCevap> BildirimSonucItem { get; set; }
        public string HataKodu { get; set; }
        public string HataMesaji { get; set; }
        public bool HataVarYok { get; set; }

        public BILDIRIMSONUC()
        {
            BildirimSonucItem = new List<OmegaHKS.BildirimServiceReference.BildirimKayitCevap>();
            HataVarYok = false;
        }
    }
}
