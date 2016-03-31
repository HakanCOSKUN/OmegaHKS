using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OmegaHKS.BildirimServiceReference;
using OmegaHKS.GenelServiceReference;
using NLog;
using System.Reflection;
using DevExpress.XtraEditors.Controls;
using OmegaHKS.Properties;

namespace OmegaHKS.Views.Aktarim
{
    public partial class frmIrsaliyesizBildirim : BaseForm
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        private IList<SubeDTO> subeListesi = new List<SubeDTO>();
        private IList<Models.BildirimSorguDTOLocal> referansBildirimList = new List<Models.BildirimSorguDTOLocal>();
        private IList<BildirimSorguDTO> bildirimSorguList = new List<BildirimSorguDTO>();
        private IList<Models.LocalDepo> localSubeListesi = new List<Models.LocalDepo>();
        private int gelenRefIsyeriId = 0;
        private int bildirimIsyeriId = 0;
        private string PilakaNo = "";

        private DateTime TarihB = DateTime.Now.AddMonths(-1);
        private DateTime TarihS = DateTime.Now;

        private bool islem = false;
        private Guid PidID;
        public frmIrsaliyesizBildirim()
        {
            InitializeComponent();
            InitScreen();
            dgvReferansListesi.SecimColumnGoster();
        }

        private void InitScreen()
        {
            barDEIslemTarihB.EditValue = DateTime.Now.AddMonths(-1);
            barDEIslemTarihS.EditValue = DateTime.Now;

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Sisteminden Veriler Okunuyor...");

            subeListesi = GetSubeDTO();
            List<Models.LocalSubeBilgisi> sbList = new List<Models.LocalSubeBilgisi>();

            foreach (var item in subeListesi)
            {
                sbList.Add(new Models.LocalSubeBilgisi
                {
                    Id = item.Id,
                    SubeAdi = item.SubeAdi
                });
            }
            sbList.Add(new Models.LocalSubeBilgisi
            {
                Id = 0,
                SubeAdi = "Şube  / Depo Seciniz"
            });


            rsiSevkEdilecekSube.DataSource = sbList;
            rsiSevkEdilecekSube.Properties.DisplayMember = "SubeAdi";
            rsiSevkEdilecekSube.Properties.ValueMember = "Id";
            rsiSevkEdilecekSube.Properties.SearchMode = SearchMode.AutoComplete;

            var localDepoController = new Controllers.LocalDepoDTOController();
            localSubeListesi = localDepoController.GetLocalDepoList(Models.DepoSubeAramaTipi.Depo);
            gelenRefIsyeriId = Convert.ToInt32(Settings.Default["GelenReferansID"].ToString());

            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }
        private List<SubeDTO> GetSubeDTO()
        {
            logger.Error("HKS Web Service Okumaya İstek Hazırla");
            if (!Helpers.GenerelHelper.IsConnected())
            {
                Helpers.MessageHelper.ShowInformation("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!");
                return null;
            }
            var result = new List<SubeDTO>();
            try
            {
                using (var proxy = new GenelServiceReference.GenelServiceClient())
                {
                    var istek = new GenelServiceReference.BaseRequestMessageOf_SubelerIstek()
                    {
                        UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                        Password = Core.StaticDegiskenler.webServiceUser.Password,
                        ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                        Istek = new GenelServiceReference.SubelerIstek() { TcKimlikVergiNo = Core.StaticDegiskenler.webServiceUser.UserName }
                    };
                    logger.Info("HKS Web Service Okumaya Başladı");
                    var cevap = proxy.GenelServisSubeler(istek);

                    if (cevap.HataKodlari != null && cevap.HataKodlari.Count > 0)
                    {
                        var sb = new StringBuilder();
                        foreach (var item in cevap.HataKodlari)
                        {
                            sb.AppendLine(string.Format("Hata Kodu :{0} Hata Mesajı :{1}", item.HataKodu, item.Mesaj));
                        }

                        Helpers.MessageHelper.ShowError(sb.ToString());

                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                        logger.Error(sb.ToString());
                    }
                    else
                    {
                        logger.Info("HKS Web Service Okuma İşlemi Bitti");
                        result = cevap.Sonuc.Subeler;
                    }
                }
            }
            catch (Exception e)
            {
                var errorMessage = string.Format("Hata Yeri : {0}\nHata Bilgisi: {1} {2}", e.StackTrace, e.Message, MethodBase.GetCurrentMethod().DeclaringType);
                logger.Error(errorMessage);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
            }
            return result;
        }
        private void barBTNSorgula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TarihB = Convert.ToDateTime(barDEIslemTarihB.EditValue);
            TarihS = Convert.ToDateTime(barDEIslemTarihS.EditValue);
            this.bildirimSorguList.Clear();
            referansBildirimList.Clear();

            this.bildirimSorguList = ReferansKunyeSorgula(TarihB, TarihS).Where(w => w.GidecekIsyeriId == gelenRefIsyeriId).ToList();
            referansBildirimList.Clear();

            foreach (var item in bildirimSorguList)
            {
                referansBildirimList.Add(new Models.BildirimSorguDTOLocal
                {
                    AnalizStatus = item.AnalizStatus,
                    BelgeNo = item.BelgeNo,
                    BelgeTipi = item.BelgeTipi,
                    BildirimciTcKimlikVergiNo = item.BildirimciTcKimlikVergiNo,
                    BildirimTarihi = item.BildirimTarihi,
                    BildirimTuru = item.BildirimTuru,
                    GidecekIsyeriId = item.GidecekIsyeriId,
                    KalanMiktar = item.KalanMiktar,
                    GidecekYerTuruId = item.GidecekYerTuruId,
                    KunyeNo = item.KunyeNo,
                    MalinAdi = item.MalinAdi,
                    MalinCinsi = item.MalinCinsi,
                    MalinCinsKodNo = item.MalinCinsKodNo,
                    MalinKodNo = item.MalinKodNo,
                    MalinMiktari = item.MalinMiktari,
                    MalinSahibiTcKimlikVergiNo = item.MalinSahibiTcKimlikVergiNo,
                    MalinSatisFiyati = item.MalinSatisFiyati,
                    MalinTuru = item.MalinTuru,
                    MalinTuruKodNo = item.MalinTuruKodNo,
                    MiktarBirimiAd = item.MiktarBirimiAd,
                    MiktarBirimId = item.MiktarBirimId,
                    RusumMiktari = item.RusumMiktari,
                    UniqueId = item.UniqueId,
                    UreticiTcKimlikVergiNo = item.UreticiTcKimlikVergiNo,
                    SEVKMIKTARI = item.KalanMiktar
                });
            }
            dgcReferansListesi.DataSource = null;
            dgcReferansListesi.RefreshDataSource();
            dgcReferansListesi.DataSource = referansBildirimList;

        }
        private void barLueKarsiSube_EditValueChanged(object sender, EventArgs e)
        {
            var secilenSube = barLueKarsiSube.EditValue.ToString();
            int sube = 0;
            sube = Convert.ToInt32(secilenSube);
            PilakaNo = Settings.Default["TempPlakaNo"].ToString();
            bildirimIsyeriId = sube;
            foreach (var item in subeListesi)
            {
                if (item.Id == sube)
                {
                    foreach (var lc in localSubeListesi)
                    {
                        if (lc.HKSISYERITURU == item.IsyeriTuru && lc.HKSID == item.Id)
                        {
                            bildirimIsyeriId = sube;
                            PilakaNo = lc.PLAKANO;
                        }
                    }
                }
            }

            Helpers.MessageHelper.ShowInformation(string.Format("ID {0} Plaka {1}", bildirimIsyeriId, PilakaNo));
        }
        private IList<BildirimSorguDTO> ReferansKunyeSorgula(DateTime tarihB, DateTime tarihS)
        {
            IList<BildirimSorguDTO> result = new List<BildirimSorguDTO>();
            BildirimServiceReference.BaseResponseMessageOf_BildirimSorguCevap cevap = null;

            var istek = new BildirimServiceReference.BaseRequestMessageOf_BildirimSorguIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new BildirimServiceReference.BildirimSorguIstek()
                {
                    KunyeTuru = 1,
                    KunyeNo = Convert.ToInt64(0),
                    BaslangicTarihi = tarihB,
                    BitisTarihi = tarihS,
                    KalanMiktariSifirdanBuyukOlanlar = true,
                }
            };

            try
            {
                islem = true;
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Sisteminden Veriler Okunuyor...");

                if (!Helpers.GenerelHelper.IsConnected())
                {
                    Helpers.MessageHelper.ShowInformation("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!");
                    return result;
                }

                using (var proxy = new BildirimServiceReference.BildirimServiceClient())
                {
                    cevap = proxy.BildirimServisBildirimSorgu(istek);
                }
            }
            finally
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
                islem = false;
            }
            if (cevap.Sonuc != null)
            {
                if ((cevap.Sonuc.HataKodu == 0))
                {
                    var bildirimList = new List<BildirimServiceReference.BildirimSorguDTO>();

                    bildirimList = cevap.Sonuc.Bildirimler;
                    if (bildirimList.Count <= 0)
                    {
                        return result;
                    }

                    result = bildirimList;
                }
                else
                {
                    Helpers.MessageHelper.ShowError(string.Format("Hata Kodu : {0}, Hata Mesajı : {1}", cevap.Sonuc.HataKodu, cevap.Sonuc.Mesaj));
                }
            }
            else
            {
                if (cevap.HataKodlari != null)
                {
                    Helpers.MessageHelper.ShowError(string.Format("Hata Kodu : {0}, Hata Mesajı : {1}", cevap.HataKodlari[0].HataKodu, cevap.HataKodlari[0].Mesaj));
                }
                else
                {
                    Helpers.MessageHelper.ShowError(cevap.IslemKodu);
                }
            }

            return result;
        }
        private void barBtnBildirimYap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var secilenKunyeler = dgvReferansListesi.GetSelectedItems<Models.BildirimSorguDTOLocal>();
            if(secilenKunyeler.Count>0)
            {
                var bildirimSor = Helpers.MessageHelper.ShowQuestion("Secilen Künyeler Bildirim Yapılacaktır Onaylıyor musunuz? \r\nHer Bildirimde En Fazla 99 Ürün Bildirim Yapılmaktadır...");
                if(bildirimSor)
                {
                    IList<BildirimKayitIstek> brList = new List<BildirimKayitIstek>();

                    var BelegeNo = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
                    foreach (var item in secilenKunyeler)
                    {
                        brList.Add(WebBuildSingleIstek(item.KunyeNo, bildirimIsyeriId, PilakaNo, item.SEVKMIKTARI, BelegeNo));
                    }

                    if(brList.Count>0)
                    {
                        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
                        DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
                        DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Künye İşlemleri Yapılıyor...");

                        HksBildirimKayit(brList);

                        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
                    }
                }
            }
        }

        public BildirimKayitIstek WebBuildSingleIstek(long refKunye, int hksId, string plakaNo, double urunMiktari, string belgeNo)
        {
            return new BildirimKayitIstek()
            {
                BildirimciBilgileri = new BildirimciBilgileriDTO { KisiSifat = Core.StaticDegiskenler.BildirimciSifatId },
                BildirimTuru = Core.StaticDegiskenler.BidirimTuruId,
                IkinciKisiBilgileri = new IkinciKisiBilgileriDTO { TcKimlikVergiNo = Core.StaticDegiskenler.webServiceUser.UserName, KisiSifat = Core.StaticDegiskenler.GidecekYerSifatId },
                ReferansBildirimKunyeNo = GetReferansKunyeNo(refKunye),
                BildirimMalBilgileri = new BildirimMalBilgileriDTO { MalinSatisFiyat = 0, MalinMiktari = urunMiktari, MalinNiteligi = 1 },
                MalinGidecekYerBilgileri = GetMalinGidecekYerBilgileri(hksId, plakaNo, belgeNo),
                UniqueId = ""
            };
        }
        private long GetReferansKunyeNo(long refKunye)
        {
            return Convert.ToInt64(refKunye);
        }

        private MalinGidecekYerBilgileriDTO GetMalinGidecekYerBilgileri(int hksId,string plakaNo, string belgeNo)
        {

            var result = new MalinGidecekYerBilgileriDTO();

            result.AracPlakaNo = plakaNo;
            result.GidecekIsyeriId = hksId;
            result.BelgeNo = belgeNo;
            result.GidecekYerIsletmeTuruId = Core.StaticDegiskenler.GidecekYerIsletmeTuruId;  //19; // Databseden Alınıcak
            result.BelgeTipi = Core.StaticDegiskenler.BildirimBelgeTipiId; // 207;   // Databseden Alınıcak

            return result;
        }



        
        private void HksBildirimKayit(IList<BildirimKayitIstek> bList)
        {
            BaseResponseMessageOf_ListOf_BildirimKayitCevap cevap = null;



            BildirimServiceReference.BaseRequestMessageOf_ListOf_BildirimKayitIstek istekList = new BaseRequestMessageOf_ListOf_BildirimKayitIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new List<BildirimServiceReference.BildirimKayitIstek>()
            };



            for (var i = 0; i < bList.Count; i++)
            {
                if(i<=99)
                {
                    var singleIstek = bList[i];
                    singleIstek.UniqueId = Guid.NewGuid().ToString();
                    istekList.Istek.Add(singleIstek);
                }

            }


            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (BildirimServiceReference.BildirimServiceClient proxy = new BildirimServiceReference.BildirimServiceClient())
                {
                    cevap = proxy.BildirimServisBildirimKaydet(istekList);
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            StringBuilder sb = new StringBuilder();
            if (cevap.Sonuc != null)
            {
                foreach (var item in cevap.Sonuc)
                {
                    if ((item == null) || (item.HataKodu == 0))
                        sb.AppendFormat("{0} unique id'li bildirimin yeni künye numarası : {1}\r\n",
                            item.UniqueId, item.YeniKunyeNo);
                    else
                        sb.AppendFormat("{0} unique id'li bildirimin hata Kodu : {1}, Hata Mesajı : {2}\r\n",
                            item.UniqueId, item.HataKodu, item.Mesaj);
                }

                if (cevap.IslemKodu == ServiceConstants.Global.ServisIslemBasarili)
                {
                    Helpers.MessageHelper.ShowInformation("İşlem Başarılı Bir Şekilde Tamamlandı \r\n" + sb.ToString());
                }
                else
                    Helpers.MessageHelper.ShowError("İşlem Hatalı Bir Şekilde Tamamlandı \r\n" + sb.ToString());
            }
            else
                Helpers.MessageHelper.ShowInformation(cevap.IslemKodu);
        }


        /*
        private BildirimServiceReference.BildirimKayitIstek BuildSingleIstek()
        {
            return new BildirimServiceReference.BildirimKayitIstek()
            {
                BildirimciBilgileri = this.GetBildirimciBilgileri(),
                BildirimTuru = this.GetBildirimTuru(),
                IkinciKisiBilgileri = this.GetIkinciKisiBilgileri(),
                ReferansBildirimKunyeNo = this.GetReferansKunyeNo(),
                BildirimMalBilgileri = this.GetMalBilgileri(),
                MalinGidecekYerBilgileri = this.GetMalinGidecekYerBilgileri()
            };
        }

        private MalinGidecekYerBilgileriDTO GetMalinGidecekYerBilgileri()
        {
            MalinGidecekYerBilgileriDTO result = new MalinGidecekYerBilgileriDTO();

            UlkeDTO ulke = ((List<UlkeDTO>)bsGidecegiYerUlke.DataSource)[cmbGidecegiYerUlke.SelectedIndex];
            BeldeDTO belde = ((List<BeldeDTO>)bsGidecekYerBelde.DataSource)[cmbGidecekYerBelde.SelectedIndex];
            IlceDTO ilce = ((List<IlceDTO>)bsGidecegiYerIlce.DataSource)[cmbGidecegiYerIlce.SelectedIndex];
            IlDTO il = ((List<IlDTO>)bsGidecegiYerIl.DataSource)[cmbGidecegiYerIl.SelectedIndex];
            IsletmeTuruDTO isletmeTuru = ((List<IsletmeTuruDTO>)bsIsletmeTuru.DataSource)[cmbGidecegiYerIsletmeTuru.SelectedIndex];

            result.AracPlakaNo = txtAracPlakaNo.Text;
            result.GidecekIsyeriId = Convert.ToInt32(nmGidecegiYerNokta.Value);
            result.GidecekUlkeId = ulke.Id;
            result.GidecekYerBeldeId = belde.Id;
            result.GidecekYerIlceId = ilce.Id;
            result.GidecekYerIlId = il.Id;
            result.GidecekYerIsletmeTuruId = isletmeTuru.Id;
            //result.GidecekYerKayitliDegil = cbGidecegiYerKayitliDegil.Checked;

            return result;
        }

        private BildirimMalBilgileriDTO GetMalBilgileri()
        {
            BildirimMalBilgileriDTO result = new BildirimMalBilgileriDTO();

            UlkeDTO ulke = ((List<UlkeDTO>)bsMalBilgileriUlke.DataSource)[cmbMalBilgileriUlke.SelectedIndex];
            UrunCinsiDTO urunCinsi = ((List<UrunCinsiDTO>)bsMalBilgileriUrunCinsi.DataSource)[cmbMalBilgileriUrunCinsi.SelectedIndex];
            UrunDTO urun = ((List<UrunDTO>)bsMalBilgileriUrun.DataSource)[cmbMalBilgileriUrun.SelectedIndex];
            UretimSekliDTO uretimSekli = ((List<UretimSekliDTO>)bsMalBilgileriUretimSekli.DataSource)[cmbMalBilgileriUretimSekli.SelectedIndex];
            UrunBirimiDTO urunBirimi = ((List<UrunBirimiDTO>)bsMalBilgileriMiktarBirimi.DataSource)[cmbMalBilgileriMiktarBirimi.SelectedIndex];
            BeldeDTO belde = ((List<BeldeDTO>)bsMalBilgileriBelde.DataSource)[cmbMalBilgileriBelde.SelectedIndex];
            IlceDTO ilce = ((List<IlceDTO>)bsMalBilgileriIlce.DataSource)[cmbMalBilgileriIlce.SelectedIndex];
            IlDTO il = ((List<IlDTO>)bsMalBilgileriIl.DataSource)[cmbMalBilgileriIl.SelectedIndex];

            int malinNiteligi = rbYerli.Checked ? 1 : rbIthal.Checked ? 2 : 3;

            result.GelenUlkeId = ulke.Id;
            result.MalinCinsiId = urunCinsi.Id;
            result.MalinKodNo = urun.Id;
            result.MalinNiteligi = malinNiteligi;
            result.MalinSatisFiyat = Convert.ToDouble(nmMalBilgileriBirimFiyati.Value);
            //result.MalinSatisFiyat = 1.1;
            result.MiktarBirimId = urunBirimi.Id;
            result.MalinMiktari = Convert.ToDouble(nmMiktarBilgileriMalinMiktar.Value);
            //result.MalinMiktari = 8;
            result.UretimBeldeId = belde.Id;
            result.UretimIlceId = ilce.Id;
            result.UretimIlId = il.Id;
            result.UretimSekli = uretimSekli.Id;
            result.AnalizeGonderilecekMi = this.cbAnalizeGonder.Checked;

            return result;
        }

        private BildirimciBilgileriDTO GetBildirimciBilgileri()
        {
            BildirimciBilgileriDTO result = new BildirimciBilgileriDTO();

            SifatDTO item = ((List<SifatDTO>)bsSifat.DataSource)[cmbSifat.SelectedIndex];
            result.KisiSifat = item.Id;

            return result;
        }

        private int GetBildirimTuru()
        {
            int result = 0;

            BildirimTuruDTO item = ((List<BildirimTuruDTO>)bsBildirimTurleri.DataSource)[cmbBildirimTuru.SelectedIndex];
            result = item.Id;

            return result;
        }

        private IkinciKisiBilgileriDTO GetIkinciKisiBilgileri()
        {
            IkinciKisiBilgileriDTO result = new IkinciKisiBilgileriDTO();
            result.YurtDisiMi = chkIkinciKisiYurtDisi.Checked;
            result.TcKimlikVergiNo = txtIkinciKisiTcKimlikVergiNo.Text;
            result.Eposta = txtIkinciKisiEPostasi.Text;
            result.AdSoyad = txtIkinciKisiAdSoyadUnvani.Text;
            result.CepTel = txtIkinciKisiGSMNumarasi.Text;

            SifatDTO item = ((List<SifatDTO>)bsIkinciKisiSifat.DataSource)[cmbIkinciKisiSifati.SelectedIndex];
            result.KisiSifat = item.Id;

            return result;
        }


        private long GetReferansKunyeNo()
        {
            return Convert.ToInt64(nmReferansKunyeNo.Value);
        }
        */
    }
}