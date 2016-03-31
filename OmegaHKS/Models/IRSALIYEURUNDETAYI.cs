using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OmegaHKS.Models
{
    internal class IRSALIYEURUNDETAYI : IrsaliyeDetay
    {
        public List<STKTH011> URUNESLESTIRMETABLOSU { get; set; }
        public string PLAKANO { get; set; }
        public  IRSALIYEURUNDETAYI ()
        {
            URUNESLESTIRMETABLOSU = new List<STKTH011>();
            base.KUNYEALINDI = false;
        }
    }
}
