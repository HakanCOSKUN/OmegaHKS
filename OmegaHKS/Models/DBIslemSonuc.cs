using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OmegaHKS.Models
{
    internal class DBIslemSonuc
    {
        public bool HataDurumu { get; set; }
        public long HataKodu { get; set; }
        public string HataMesaji { get; set; }
        public string HataBlogu { get; set; }
        public int HataSatiri { get; set; }
    }
}
