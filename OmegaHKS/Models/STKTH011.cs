using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OmegaHKS.Models
{
    internal class STKTH011
    {
        public long STKKOD { get; set; }
        public int MALID { get; set; }
        public int MALCINSID { get; set; }
        public string MALTUR { get; set; }
        public string URUNKOD { get; set; }
        public string ITHAL { get; set; }
        public bool ESLESTIMI { get; set; }
        public STKTH011()
        {
            ESLESTIMI = false;
            ITHAL = "H";
        }
    }
}
