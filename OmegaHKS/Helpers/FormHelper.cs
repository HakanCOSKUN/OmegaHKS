using System;
using System.Collections.Generic;
using System.Linq;
using OmegaHKS.Views;

namespace OmegaHKS.Helpers
{
    public static class FormHelper
    {
        private static TForm GetForm<TForm>(params object[] constructorParams) where TForm: Views.BaseForm
        {
            return (TForm)Activator.CreateInstance(typeof(TForm), constructorParams);
        }
        public static void ShowDialog<TForm>(params object[] constructorParams) where TForm: BaseForm
        {
            Core.StaticDegiskenler.FormInt = -1;
            var form = GetForm<TForm>(constructorParams);
            form.ShowDialog();
        }
        public static void Show<TForm>(params object[] constructorParams) where TForm: BaseForm
        {
            Core.StaticDegiskenler.FormInt = -1;
            var form = GetForm<TForm>(constructorParams);
            form.MdiParent = Views.Main.frmMain.ActiveForm;
            form.Show();
        }
    }
    public static class DepoSubeIslemleri
    {
        public static int DepoSubeSecim(bool secim = true , int localNo = -1, Models.DepoSubeAramaTipi tip = Models.DepoSubeAramaTipi.Sube)
        {
            var result = -1;
            FormHelper.ShowDialog<Views.Eslestirme.frmDepoSubeListesi>(secim, localNo, tip);
            result = Core.StaticDegiskenler.FormInt;
            return result;
        }
    }
    public static class Irsaliyeler
    {
        public static void IrsaliyeDetayGoster(int irsNo)
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Aktarim.frmIrsaliyeDetay>(irsNo);
        }
    }
    public static class Urunler
    {
        public static int StokAramaYap(bool secim, int? stokKodu, string stokAdi)
        {
            var result = -1;
            FormHelper.ShowDialog<Views.Eslestirme.frmStokArama>(secim, stokKodu, stokAdi);
            result = Core.StaticDegiskenler.FormInt;
            return result;
        }
    }
    public static class HataBilgileri
    {
        public static void HataGosterDialog(IList<Models.ErrorLog> errLog)
        {
            FormHelper.ShowDialog<Views.Main.frmHataListele>(errLog);

        }

        public static void HataGosterShow(IList<Models.ErrorLog> errLog)
        {
            FormHelper.Show<Views.Main.frmHataListele>(errLog);

        }
    }
    public static class Aktarimlar
    {

        public static void StokSifirlama()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Aktarim.frmIrsaliyesizBildirim>();
        }

        public static void NihaiBildirimler()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Aktarim.frmNihaiBildirimler>();
        }
        public static void ReferansBildirimler()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Aktarim.frmReferansBildirimler>();
        }
        public static void BildirimYap()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Aktarim.frmIrsaliyeAktarimlari>();
        }
        public static void EtiketIslemleri()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Aktarim.frmEtiketIstekleri>();
        }
        public static void AlisIrsaliyesindenKunyeIsle()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Aktarim.frmAlistanKunye>();
        }

        public static void EtiketListesiSorgula()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.LocalHKSUpdate.frmEtiketSorgu>();
        }

        public static void EtiketYazdir(List<Models.EtiketEkranListe> model)
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Aktarim.frmEtiketViewer>(model);
        }

        public static string CariArama(string cariUnvan)
        {
            string result = string.Empty;
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.ShowDialog<Views.Eslestirme.frmCariFirmaAra>(cariUnvan);
            result = Core.StaticDegiskenler.CariKod;
            return result;
        }
    }
    public static class Ayarlar
    {
        public static void AracTanimlari()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Ayarlar.frmAracTanimlari>();
        }
        public static void WebServiceTanimlari()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Ayarlar.frmWebServiceBilgileri>();
        }
        public static void BildirimveGidecekYerAyarlari()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Ayarlar.FrmSifatBilgileri>();
        }
    }
    public static class EslestirmeIslemleri
    {
        public static void DepoEslestirmeIslemleri()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Eslestirme.frmDepoEslestirme>();
        }
        public static void SubeEslestirmeIslemleri()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Eslestirme.frmSubeEslestirme>();
        }
        public static void DMEslestirmeIslemleri()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Eslestirme.frmDMEslestirme>();
        }
        public static void StokEslestirme()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.Eslestirme.frmUrunEslestirmeleri>();
        }
        public static int StokAramaYap(bool secim, int? stokKodu, string stokAdi)
        {
            var result = -1;
            FormHelper.ShowDialog<Views.Eslestirme.frmStokArama>(secim, stokKodu, stokAdi);
            result = Core.StaticDegiskenler.FormInt;
            return result;
        }
        public static int DepoSubeArama(bool secim = true, int localNo = -1, Models.DepoSubeAramaTipi tip = Models.DepoSubeAramaTipi.Sube)
        {
            var result = -1;
            FormHelper.ShowDialog<Views.Eslestirme.frmDepoSubeListesi>(secim, localNo, tip);
            result = Core.StaticDegiskenler.FormInt;
            return result;
        }
    }
    public static class HKSLocalUpdateIslemleri
    {
        public static void LokasyonIslemleri()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.LocalHKSUpdate.frmLokasyon>();
        }
        public static void UrunIslemleri()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.LocalHKSUpdate.frmUrunBilgileri>();
        }
        public static void UrunYardimciBilgileriIslemleri()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.LocalHKSUpdate.frmUrunYardimciBilgieri>();
        }
        public static void BildirimYardimciSinifIslemleri()
        {
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            FormHelper.Show<Views.LocalHKSUpdate.frmBildirimYardimciBilgileri>();
        }
    }
}
