using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaHKS.Models
{
    public class IrsaliyeDetay
    {
        public int IRSNO { get; set; }
        public DateTime TARIH { get; set; }
        public int DEPNO { get; set; }
        public int ALDEP { get; set; }
        public int? SIPNO { get; set; }
        public int SIRANO { get; set; }
        public string STKKOD { get; set; }
        public string BARKOD { get; set; }
        public string STOKAD { get; set; }
        public double TBIRIMMIK { get; set; }
        public double BIRIMMIK { get; set; }
        public double CEVRIMDEGER { get; set; }
        public double BRTFIAT { get; set; }
        public BrimTip CEVBIRIMTIP { get; set; }
        public BrimTip BIRIMTIP { get; set; }
        public double NETTUTAR { get; set; }
        public double TUTAR { get; set; }
        public int MALID { get; set; }
        public string MALAD { get; set; }
        public int MALCINSID { get; set; }
        public string MALCINSAD { get; set; }
        public string MALTUR { get; set; }
        public string URUNKOD { get; set; }
        public long KUNYE { get; set; }
        public long REFKUNYE { get; set; }
        public int MALINNITELIGI { get; set; }
        public Guid? UniqueId { get; set; }
        public int SifatId { get; set; }
        public bool EslesmeDurumu { get; set; }
        public bool BildirimEksik { get; set; }
        public string BELGENO { get; set; }
        public bool AsilUrun { get; set; }
        public bool KUNYEALINDI { get; set; }

    }
}
