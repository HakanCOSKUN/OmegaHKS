using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaHKS.Models
{
    class BildirimListe
    {
        public int BildirimciSifat { get; set; }
        public int BildirimTuruId { get; set; }
        public long ReferansKunye { get; set; }
        public int KarsiDepoId { get; set; }
        public string BelgeNo { get; set; }
        public Urun urun  { get; set; }
    }

    //public BildirimServiceReference.BildirimKayitIstek WebBuildSingleIstek(long refKunye, int depo, Models.IrsaliyeDetay urun, string belgeNo)
    //{
    //    return new BildirimServiceReference.BildirimKayitIstek()
    //    {
    //        BildirimciBilgileri = new BildirimciBilgileriDTO { KisiSifat = 7 }, // Market 7 Gidicek
    //        BildirimTuru = 195,                                                 // this.GetBildirimTuru(),  Satin Alim
    //        IkinciKisiBilgileri = new IkinciKisiBilgileriDTO { TcKimlikVergiNo = Core.StaticDegiskenler.webServiceUser.UserName, KisiSifat = 4 }, //  Üretici 4
    //        ReferansBildirimKunyeNo = this.GetReferansKunyeNo(refKunye),
    //        BildirimMalBilgileri = new BildirimMalBilgileriDTO { MalinSatisFiyat = urun.BRTFIAT, MalinMiktari = urun.TBIRIMMIK, MalinNiteligi = 1 }, // this.GetMalBilgileri(urun),
    //        MalinGidecekYerBilgileri = this.GetMalinGidecekYerBilgileri(depo, belgeNo),
    //        UniqueId = urun.UniqueId.ToString()
    //    };
    //}
}
