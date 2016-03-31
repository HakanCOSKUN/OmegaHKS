using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmegaHKS.BildirimServiceReference;

namespace OmegaHKS.Models
{
    internal class LocalBildirimSorguDTO : BildirimSorguDTO
    {
        private string belgeTipiAdi;

        public string BelgeTipiAdi
        {
            get { return belgeTipiAdi; }
            set { belgeTipiAdi = value; }
        }

        private string bildirimTuruAdi;

        public string BildirimTuruAdi
        {
            get { return bildirimTuruAdi; }
            set { bildirimTuruAdi = value; }
        }

        private string gidecekYerTuruAdi;

        public string GidecekYerTuruAdi
        {
            get { return gidecekYerTuruAdi; }
            set { gidecekYerTuruAdi = value; }
        }

        private string gidecekIsyeriAdi;

        public string GidecekIsyeriAdi
        {
            get { return gidecekIsyeriAdi; }
            set { gidecekIsyeriAdi = value; }
        }

        //public void xxxxx()
        //{
        //    var x = new BildirimSorguDTO();
        //    var xx0=  x.BelgeNo;
        //    var xx1 = x.BelgeTipi;
        //    var xx2 = x.BildirimciTcKimlikVergiNo;
        //    var xx3 = x.BildirimTarihi;
        //    var xx4 = x.BildirimTuru;
        //    var xx5 = x.GidecekIsyeriId;
        //    var xx6 = x.GidecekYerTuruId;
        //    var xx7 = x.KalanMiktar;
        //    var xx8 = x.KunyeNo;
        //    var xx9 = x.MalinAdi;
        //    var x10 = x.MalinCinsi;
        //    var x11 = x.MalinCinsKodNo;
        //    var x12 = x.MalinKodNo;
        //    var x13 = x.MalinMiktari;
        //    var x14 = x.MalinSahibiTcKimlikVergiNo;
        //    var x15 = x.MalinSatisFiyati;
        //    var x16 = x.MalinTuru;
        //    var x17 = x.MalinTuruKodNo;
        //    var x18 = x.MiktarBirimiAd;
        //    var x19 = x.MiktarBirimId;
        //    var x20 = x.RusumMiktari;
        //    var x21 = x.UniqueId;
        //    var x22 = x.UreticiTcKimlikVergiNo;
        //}

    }
}
