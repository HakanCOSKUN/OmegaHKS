using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaHKS.Models
{
    public class AlisIrsaliye
    {
        public DateTime TARIH { get; set; }
        public int DEPNO { get; set; }
        public string DEPOAD { get; set; }
        public HareketTip TIP { get; set; }
        public int IRSNO { get; set; }
        public string BELGENO { get; set; }
        public decimal TUTAR { get; set; }
        public decimal KDVTUTAR { get; set; }
        public string CARKOD { get; set; }
        public string CARIUNVAN { get; set; }
        public string VERGINO { get; set; }
        public DateTime? KUNYETARIH { get; set; }
        public int KONTROL { get; set; }
        public int HksID { get; set; }
        public int HksIlId { get; set; }
        public int HksIlceId { get; set; }
        public int HksBeldeId { get; set; }
        public string PLAKANO { get; set; }
    }
}
