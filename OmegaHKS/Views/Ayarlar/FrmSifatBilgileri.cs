using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace OmegaHKS.Views.Ayarlar
{
    public partial class FrmSifatBilgileri : BaseForm
    {
        IList<Models.LocalSifatDTO> Sifatlar = new List<Models.LocalSifatDTO>();
        IList<Models.LocalSifatDTO> SifatlarTmp = new List<Models.LocalSifatDTO>();
        IList<Models.LocalBelgeTipiDTO> BelgeTipleri = new List<Models.LocalBelgeTipiDTO>();
        IList<Models.LocalBildirimTuruDTO> BildirimTurleri = new List<Models.LocalBildirimTuruDTO>();
        IList<Models.LocalIsletmeTuruDTO> IsletmeTuruBilgileri = new List<Models.LocalIsletmeTuruDTO>();
        List<string> TcKimlikVergiNo = new List<string>();

        public FrmSifatBilgileri()
        {
            InitializeComponent();
            InitWebService();
            InitDTGDoldur();
        }

        private void InitWebService()
        {
            var cr = new Controllers.LocalHKSUpdateController();
            this.Sifatlar = cr.GetSifatlarDTO();

            if (!Helpers.GenerelHelper.IsConnected())
            {
                Helpers.MessageHelper.ShowInformation("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!");
                return;
            }
            TcKimlikVergiNo.Add(Core.StaticDegiskenler.webServiceUser.UserName);

            BildirimServiceReference.BaseResponseMessageOf_KayitliKisiSorguCevap cevap = null;

            BildirimServiceReference.BaseRequestMessageOf_KayitliKisiSorguIstek istek = new BildirimServiceReference.BaseRequestMessageOf_KayitliKisiSorguIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new BildirimServiceReference.KayitliKisiSorguIstek()
                {
                    TcKimlikVergiNolar = TcKimlikVergiNo
                }
            };

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (BildirimServiceReference.BildirimServiceClient proxy = new BildirimServiceReference.BildirimServiceClient())
                {
                    cevap = proxy.BildirimServisKayitliKisiSorgu(istek);
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            StringBuilder sb = new StringBuilder();
            if (cevap.Sonuc != null)
            {
                if ((cevap.Sonuc.HataKodu == 0))
                {
                    bsKayitliKisiSifatListesi.DataSource = cevap.Sonuc.TcKimlikVergiNolar;

                    List<OmegaHKS.BildirimServiceReference.KayitliKisiSorguDTO> list = (List<OmegaHKS.BildirimServiceReference.KayitliKisiSorguDTO>)bsKayitliKisiSifatListesi.DataSource;

                    if (list.Count > 0)
                    {
                        List<int> sifatIdleri = new List<int>();
                        foreach (var item in list)
                        {
                            sifatIdleri.AddRange(item.Sifatlari);
                        }

                        foreach (var item in sifatIdleri)
                        {
                            SifatlarTmp.Add(new Models.LocalSifatDTO { ID = item });
                        }
                        foreach (var item in this.Sifatlar)
                        {
                            foreach (var tmp in SifatlarTmp)
                            {
                                if (item.ID == tmp.ID)
                                {
                                    tmp.SIFATADI = item.SIFATADI;
                                }
                            }
                        }
                        dgcKayitliSifatlar.DataSource = SifatlarTmp;
                    }
                }

                else
                {
                    Helpers.MessageHelper.ShowError( string.Format("Hata Kodu : {0}, Hata Mesajı : {1}", cevap.Sonuc.HataKodu, cevap.Sonuc.Mesaj));
                }
            }
            else
            {
                if (cevap.HataKodlari != null)
                    Helpers.MessageHelper.ShowError(string.Format("Hata Kodu : {0}, Hata Mesajı : {1}", cevap.HataKodlari[0].HataKodu, cevap.HataKodlari[0].Mesaj));
                else
                    Helpers.MessageHelper.ShowError(cevap.IslemKodu);
            }
        }
        private void InitDTGDoldur()
        {
            var cr = new Controllers.LocalHKSUpdateController();

            this.Sifatlar = cr.GetSifatlarDTO();
            this.BelgeTipleri = cr.GetBelgeTipiDTO();
            this.BildirimTurleri = cr.GetBildirimTuruDTO();
            this.IsletmeTuruBilgileri = cr.GetIsletmeTuruDTO();


            bsBildirimciSifati.DataSource = this.Sifatlar;
            bsBildirimTurleri.DataSource = this.BildirimTurleri;
            bsBildirimciIsltemeTuru.DataSource = this.IsletmeTuruBilgileri;
            bsGidecekYerIsletmeTuruBilgileri.DataSource = this.IsletmeTuruBilgileri;
            bsGidecekYerSifati.DataSource = this.Sifatlar;
            bsBelgeTipleri.DataSource = this.BelgeTipleri;


            lueBildirimciSifatBilgisi.Properties.DataSource = bsBildirimciSifati;
            lueGidecekIsletmeTuru.Properties.DataSource = bsGidecekYerIsletmeTuruBilgileri;
            lueBildirimTuru.Properties.DataSource = bsBildirimTurleri;
            lueBildirimBelgeTipi.Properties.DataSource = bsBelgeTipleri;
            lueGidecekYerSifatBilgisi.Properties.DataSource = bsGidecekYerSifati;
            lueBildirimciIsletmeTuru.Properties.DataSource = bsBildirimciIsltemeTuru;


            lueBildirimciSifatBilgisi.Properties.DisplayMember = "SIFATADI";
            lueBildirimciSifatBilgisi.Properties.ValueMember = "ID";

            lueBildirimciIsletmeTuru.Properties.DisplayMember = "ISLETMETURUADI";
            lueBildirimciIsletmeTuru.Properties.ValueMember = "ID";

            lueGidecekIsletmeTuru.Properties.DisplayMember = "ISLETMETURUADI";
            lueGidecekIsletmeTuru.Properties.ValueMember = "ID";

            lueBildirimTuru.Properties.DisplayMember = "BILDIRIMTURUADI";
            lueBildirimTuru.Properties.ValueMember = "ID";

            lueBildirimBelgeTipi.Properties.DisplayMember = "BELGETIPIADI";
            lueBildirimBelgeTipi.Properties.ValueMember = "ID";

            lueGidecekYerSifatBilgisi.Properties.DisplayMember = "SIFATADI";
            lueGidecekYerSifatBilgisi.Properties.ValueMember = "ID";

            LookUpColumnInfoCollection colBildirimciSifat = lueBildirimciSifatBilgisi.Properties.Columns;
            colBildirimciSifat.Add(new LookUpColumnInfo("ID", 45,"Id"));
            colBildirimciSifat.Add(new LookUpColumnInfo("SIFATADI", 100,"Bidirimci Sıfat Adı"));

            LookUpColumnInfoCollection colBildirimciIsletmeTuru = lueBildirimciIsletmeTuru.Properties.Columns;
            colBildirimciIsletmeTuru.Add(new LookUpColumnInfo("ID", 45, "Id"));
            colBildirimciIsletmeTuru.Add(new LookUpColumnInfo("ISLETMETURUADI", 100, "İşletme Türü Adı"));

            LookUpColumnInfoCollection colGidecekIsletmeTuru = lueGidecekIsletmeTuru.Properties.Columns;
            colGidecekIsletmeTuru.Add(new LookUpColumnInfo("ID", 45,"Id"));
            colGidecekIsletmeTuru.Add(new LookUpColumnInfo("ISLETMETURUADI", 100,"İşletme Türü Adı"));

            LookUpColumnInfoCollection colBildirimTuru = lueBildirimTuru.Properties.Columns;
            colBildirimTuru.Add(new LookUpColumnInfo("ID", 45,"Id"));
            colBildirimTuru.Add(new LookUpColumnInfo("BILDIRIMTURUADI", 100,"Bildirim Türü Adı"));

            LookUpColumnInfoCollection colBildirimBelgeTipi = lueBildirimBelgeTipi.Properties.Columns;
            colBildirimBelgeTipi.Add(new LookUpColumnInfo("ID", 45,"Id"));
            colBildirimBelgeTipi.Add(new LookUpColumnInfo("BELGETIPIADI", 100,"Belge Tipi Adı"));


            LookUpColumnInfoCollection colGidecekYerSifatBilgisi = lueGidecekYerSifatBilgisi.Properties.Columns;
            colGidecekYerSifatBilgisi.Add(new LookUpColumnInfo("ID", 45,"Id"));
            colGidecekYerSifatBilgisi.Add(new LookUpColumnInfo("SIFATADI", 100,"Gidecek Yer Sıfat Adı"));

            lueBildirimciSifatBilgisi.Properties.SearchMode = SearchMode.AutoComplete;
            lueGidecekIsletmeTuru.Properties.SearchMode = SearchMode.AutoComplete;
            lueBildirimTuru.Properties.SearchMode = SearchMode.AutoComplete;
            lueBildirimBelgeTipi.Properties.SearchMode = SearchMode.AutoComplete;
            lueGidecekYerSifatBilgisi.Properties.SearchMode = SearchMode.AutoComplete;
            lueBildirimciIsletmeTuru.Properties.SearchMode = SearchMode.AutoComplete;

            if (Core.StaticDegiskenler.BildirimciSifatId>0)
            {
                lueBildirimciSifatBilgisi.EditValue = Core.StaticDegiskenler.BildirimciSifatId;
            }
            if (Core.StaticDegiskenler.GidecekYerSifatId > 0)
            {
                lueGidecekYerSifatBilgisi.EditValue = Core.StaticDegiskenler.GidecekYerSifatId;
            }
            if (Core.StaticDegiskenler.GidecekYerIsletmeTuruId > 0)
            {
                lueGidecekIsletmeTuru.EditValue = Core.StaticDegiskenler.GidecekYerIsletmeTuruId;
            }
            if (Core.StaticDegiskenler.BidirimTuruId > 0)
            {
                lueBildirimTuru.EditValue = Core.StaticDegiskenler.BidirimTuruId;
            }
            if (Core.StaticDegiskenler.BildirimBelgeTipiId > 0)
            {
                lueBildirimBelgeTipi.EditValue = Core.StaticDegiskenler.BildirimBelgeTipiId;
            }
            if (Core.StaticDegiskenler.BildirimciIsletmeTuruId > 0)
            {
                lueBildirimciIsletmeTuru.EditValue = Core.StaticDegiskenler.BildirimciIsletmeTuruId;
            }
        }

        private void ucsBTNKayitIpal1_ClickTemizle(object sender, EventArgs e)
        {
            InitDTGDoldur();
            InitWebService();
        }

        private void ucsBTNKayitIpal1_ClickKaydet(object sender, EventArgs e)
        {
            List<Models.SifatTanimlari> tanimlar = new List<Models.SifatTanimlari>();
            var BildirimciSifatId = lueBildirimciSifatBilgisi.EditValue.ToString();
            var GidicekYerSifatBilgisi = lueGidecekYerSifatBilgisi.EditValue.ToString();
            var BildirimTuru = lueBildirimTuru.EditValue.ToString();
            var GidecekYerIsletmeTuru = lueGidecekIsletmeTuru.EditValue.ToString();
            var GonderimBelgeTipi = lueBildirimBelgeTipi.EditValue.ToString();
            var BildirimciISletmeTuru = lueBildirimciIsletmeTuru.EditValue.ToString();

            tanimlar.Add(new Models.SifatTanimlari {
                 TANIMKODU = 10,  // Bildirimci Sifat Bilgisi
                 ID = Convert.ToInt16(BildirimciSifatId),
                 TANIMBILGISI  = "Bildirimci Sifat Bilgisi"
            });
            tanimlar.Add(new Models.SifatTanimlari
            {
                TANIMKODU = 11,   // Gider Yer Sifat Bilgisi
                ID = Convert.ToInt16(GidicekYerSifatBilgisi),
                TANIMBILGISI = "Gidecek Yer Sifat Bilgisi"
            });
            tanimlar.Add(new Models.SifatTanimlari
            {
                TANIMKODU = 12,   // Gidecek Yer İşletme Türü
                ID = Convert.ToInt16(GidecekYerIsletmeTuru),
                TANIMBILGISI = "Gidecek Yer İşletme Türü Bilgisi"
            });
            tanimlar.Add(new Models.SifatTanimlari
            {
                TANIMKODU = 13,   // Bildirim Türü Bilgisi
                ID = Convert.ToInt16(BildirimTuru),
                TANIMBILGISI = "Bildirim Türü Bilgisi"
            });
            tanimlar.Add(new Models.SifatTanimlari
            {
                TANIMKODU = 14,   // Belge Tipi Bilgisi
                ID = Convert.ToInt16(GonderimBelgeTipi),
                TANIMBILGISI = "Belge Tipi Bilgisi"
            });
            tanimlar.Add(new Models.SifatTanimlari
            {
                TANIMKODU = 15,   // Belge Tipi Bilgisi
                ID = Convert.ToInt16(BildirimciISletmeTuru),
                TANIMBILGISI = "Bildirimci İşletme Türü Bilgisi"
            });

            var cr = new Controllers.LocalHKSUpdateController();
            var silSonuc = cr.BildirimTainlamalariSil();
            if(silSonuc)
            {
                var sonuc = cr.BildirimTainlamalariGuncelle(tanimlar);
                if (sonuc)
                {
                    var conWebSer = new Controllers.WebServiceTool();
                    var xxx = conWebSer.GetBildirimTanimlariniOku();
                    InitDTGDoldur();
                    Helpers.MessageHelper.ShowInformation("İşlem Başarılı Bir Şeklide Tamamlandı.");
                }
                else
                {
                    Helpers.MessageHelper.ShowError("Beklenmeyen Bir Hata Oluştu Lütfen Daha Sonra Tekrar Deneyin");
                }
            }

        }

        private void btnYekiVer_Click(object sender, EventArgs e)
        {
            string Sifre = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            var Yetki = txtErisimSifresi.Text;
            if (Yetki == Sifre)
            {
                groupControl1.Enabled = !groupControl1.Enabled;
                groupControl2.Enabled = !groupControl2.Enabled;
            }
        }
    }
}