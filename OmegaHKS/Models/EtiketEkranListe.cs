using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaHKS.Models
{
    public class EtiketEkranListe
    {
        public DateTime TARIH { get; set; }
        public int DEPNO { get; set; }
        public int STKKOD { get; set; }
        public string STOKAD { get; set; }
        public string KUNYENO { get; set; }
        public string MALAD { get; set; }
        public string MALCINSAD { get; set; }
        public DateTime URETIMTARIH { get; set; }
        public string URETIMSEKLI { get; set; }
        public string URETIMYERI { get; set; }
        public string URETICI { get; set; }
        public double SFIYAT { get; set; }
        public string BARKOD { get; set; }
    }
}
