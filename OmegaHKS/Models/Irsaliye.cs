using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaHKS.Models
{
    public class Irsaliye
    {
        public DateTime TARIH { get; set; }
        public int DEPNO { get; set; }
        public string SEVKDEPOAD { get; set; }
        public int ALDEP { get; set; }
        public string KARSIDEPOAD { get; set; }
        public HareketTip TIP { get; set; }
        public int IRSNO { get; set; }
        public string BELGENO { get; set; }
        public decimal TUTAR { get; set; }
        public decimal KDVTUTAR { get; set; }
        public string CARKOD { get; set; }
        public DateTime? KUNYETARIH { get; set; }
        public int KONTROL { get; set; }
        public int HksID { get; set; }
        public int HksIlId { get; set; }
        public int HksIlceId { get; set; }
        public int HksBeldeId { get; set; }
    }
}
