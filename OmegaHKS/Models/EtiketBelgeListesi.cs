using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaHKS.Models
{
    public class EtiketBelgeListesi
    {
        public DateTime TARIH { get; set; }
        public string PLAKANO { get; set; }
        public string BELGENO { get; set; }
        public int ILID { get; set; }
        public int ILCEID { get; set;}
        public int BELDEID { get; set; }
        public string UNIQUEID { get; set; }
    }
}
