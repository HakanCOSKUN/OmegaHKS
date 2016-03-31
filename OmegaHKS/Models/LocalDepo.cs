using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaHKS.Models
{
    public class LocalDepo
    {
        public int DMBNO { get; set; }
        public string AD { get; set; }
        public string ADRES { get; set; }
        public string ILCE { get; set; }
        public string IL { get; set; }
        public string Plaka {get; set;}
        public string PLAKANO { get; set; }
        public int HKSID { get; set; }
        public int? HKSISYERITURU { get; set; }
        public int? HKSILID { get; set; }
        public int? HKSILCEID { get; set; }
        public int? HKSBELDEID { get; set; }
    }
}
