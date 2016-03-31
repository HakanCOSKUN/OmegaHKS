using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OmegaHKS.BildirimServiceReference;
using NLog;
using System.Text;

namespace OmegaHKS.Views.Aktarim
{
    public partial class frmIrsaliyeAktarimlari : BaseForm
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        private IList<BildirimEtiketDTO> KunyeEtiketKontrolListesi = new List<BildirimEtiketDTO>();
        private DateTime BildirimTairih = DateTime.Now;
        private int BildirimYapanDepoNoEtiketIcin = 0;

        private Guid PidID;
        public frmIrsaliyeAktarimlari()
        {
            InitializeComponent();

            txtDateEditTarihB.EditValue = DateTime.Now;
            txtDateEditTarihS.EditValue = DateTime.Now;
            PidID = Guid.NewGuid();
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();

            gvIrsaliyeListesi.SecimColumnGoster();
            GonderenDepoGetir();
        }

        private void GonderenDepoGetir()
        {
            var localDepoController = new Controllers.LocalDepoDTOController();
            var localList = localDepoController.GetLocalDepoList(Models.DepoSubeAramaTipi.Depo);
            if(localList.Count>0)
            {
                foreach (var item in localList.Where(w=>w.HKSID >0).ToList())
                {
                    if(item.HKSISYERITURU != 19)
                    {
                        txtBtnSevkEdenDepo.Text = item.AD;
                        txtBtnSevkEdenDepo.Tag = item.DMBNO;
                    }
                }
            }
        }
        private void txtBtnSevkEdenDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var btnEdit = sender as ButtonEdit;

            Core.StaticDegiskenler.tmpSubeDepo = null;
            Helpers.DepoSubeIslemleri.DepoSubeSecim(true, -1, Models.DepoSubeAramaTipi.Genel);
            if (Core.StaticDegiskenler.tmpLocalDepo != null)
            {
                btnEdit.Tag = Core.StaticDegiskenler.tmpLocalDepo.DMBNO;
                btnEdit.Text = Core.StaticDegiskenler.tmpLocalDepo.AD;
            }
        }
        private void txtBtnKarsiDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var btnEdit = sender as ButtonEdit;
            Core.StaticDegiskenler.tmpSubeDepo = null;
            Helpers.DepoSubeIslemleri.DepoSubeSecim(true, -1, Models.DepoSubeAramaTipi.Genel);
            if (Core.StaticDegiskenler.tmpLocalDepo != null)
            {
                btnEdit.Tag = Core.StaticDegiskenler.tmpLocalDepo.DMBNO;
                btnEdit.Text = Core.StaticDegiskenler.tmpLocalDepo.AD;

                var localControllers = new Controllers.LocalDepoDTOController();
                var localDepo = new Models.LocalDepo();
                localDepo = localControllers.GetLocalDepo(Core.StaticDegiskenler.tmpLocalDepo.DMBNO);
                if(string.IsNullOrEmpty( localDepo.Plaka)  || localDepo.HKSID <=0)
                {
                    Helpers.MessageHelper.ShowError("Karşı Şube / Depo için Plaka Tanımlaması, Veya HKS Eşleştirilmesi Yapılması Zorunludur.");
                }
            }
        }
        private void btnIrsaliyeleriListele_Click(object sender, EventArgs e)
        {
            var karsiDepo = -1;
            if (txtBtnSevkEdenDepo.Text != null && txtBtnSevkEdenDepo.Text != string.Empty)
            {
                if (txtBtnKarsiDepo.Text == string.Empty)
                {
                    txtBtnKarsiDepo.Tag = 0;
                }
                else
                {
                    karsiDepo = (int)txtBtnKarsiDepo.Tag;
                }
                var irsController = new Controllers.IrsaliyeController();

                var sevkEdenDepo = (int)txtBtnSevkEdenDepo.Tag;
                var tarihb = Convert.ToDateTime(txtDateEditTarihB.Text);
                var tarihs = Convert.ToDateTime(txtDateEditTarihS.Text);
                gcIrsaliyeListesi.DataSource = irsController.GetSevkIrsaliyeListesi(tarihb, tarihs, sevkEdenDepo, karsiDepo, chKunyeDahil.Checked);
            }
            else
            {
                Helpers.MessageHelper.ShowError("Sevk Eden Depo Bilgilerini Girmeniz Meçburidir.");
            }
        }
        private void gvIrsaliyeListesi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Core.StaticDegiskenler.tmpIrsaliye = null;
                Core.StaticDegiskenler.tmpIrsaliye = gvIrsaliyeListesi.GetFocusedItem<Models.Irsaliye>();
                Helpers.Irsaliyeler.IrsaliyeDetayGoster(gvIrsaliyeListesi.GetFocusedItem<Models.Irsaliye>().IRSNO);
            }
        }
        private void gvIrsaliyeListesi_DoubleClick(object sender, EventArgs e)
        {
            if (gvIrsaliyeListesi.RowCount > 0)
            {
                Core.StaticDegiskenler.tmpIrsaliye = null;
                Core.StaticDegiskenler.tmpIrsaliye = gvIrsaliyeListesi.GetFocusedItem<Models.Irsaliye>();
                Helpers.Irsaliyeler.IrsaliyeDetayGoster(gvIrsaliyeListesi.GetFocusedItem<Models.Irsaliye>().IRSNO);
            }
        }
        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            if (Core.StaticDegiskenler.AnlikIslem.IslemPidId != PidID)
            {
                Close();
            }
            else
            {
                Helpers.MessageHelper.ShowError("Devam eden işlem var işlemin bitmesini bekleyin lütfen ...!");
            }
        }
        private void ucsBTNKayitIpal1_ClickKaydet(object sender, EventArgs e)
        {
            if (gvIrsaliyeListesi.RowCount > 0)
            {
                if (!Core.StaticDegiskenler.AnlikIslem.Islem)
                {
                    PidID = Guid.NewGuid();
                    Core.StaticDegiskenler.AnlikIslem.IslemPidId = PidID;
                    Core.StaticDegiskenler.AnlikIslem.Islem = true;

                    ucsBTNKayitIpal1.KaydetEnabled = false;
                    ucsBTNKayitIpal1.IptalEnabled = false;

                    BildirimIslemleri(gvIrsaliyeListesi.GetSelectedItems<Models.Irsaliye>());

                    // tmpIrsaliyeListesi = gvIrsaliyeListesi.GetSelectedItems<Models.Irsaliye>();
                    // BildirimIslemleri(tmpIrsaliyeListesi);
                }
                else
                {
                    Helpers.MessageHelper.ShowError("Devam eden işlem var işlemin bitmesini bekleyin lütfen ...!");
                }
            }
            else
            {
                Helpers.MessageHelper.ShowInformation("Bildirim Yapılacak İrsaliye Listesi Boş\r\nİrsaliye Seçmeniz Gerekir..");
            }
        }

        /*//-------------------

        private long GetReferansKunyeNo(long refKunye)
        {
            return Convert.ToInt64(refKunye);
        }
        private MalinGidecekYerBilgileriDTO GetMalinGidecekYerBilgileri(int karsiDepo, string belgeNo)
        {
            var localControllers = new Controllers.LocalDepoDTOController();

            var result = new MalinGidecekYerBilgileriDTO();
            var localDepo = new Models.LocalDepo();

            localDepo = localControllers.GetLocalDepo(karsiDepo);

            result.AracPlakaNo = localDepo.Plaka;
            result.GidecekIsyeriId = localDepo.HKSID;
            result.BelgeNo = belgeNo;
            result.GidecekYerIsletmeTuruId = Core.StaticDegiskenler.GidecekYerIsletmeTuruId;
            result.BelgeTipi = Core.StaticDegiskenler.BildirimBelgeTipiId;

            return result;
        }

        private Models.BILDIRIMSONUC WebBildirimKayit(IList<BildirimKayitIstek> bildirim)
        {
            BaseResponseMessageOf_ListOf_BildirimKayitCevap cevap = null;
            Models.BILDIRIMSONUC bidirimSonuc = new Models.BILDIRIMSONUC();

            var donus = false;
            var bildirimController = new Controllers.BildirimController();
            var localControllers = new Controllers.LocalDepoDTOController();
            var etkList = new List<Models.LocalBildirimEtiketDTO>();


            var istekList = new BaseRequestMessageOf_ListOf_BildirimKayitIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new List<BildirimKayitIstek>()
            };

            for (var i = 0; i < bildirim.Count; i++)
            {
                var singleIstek = bildirim[i];
                singleIstek.UniqueId = Guid.NewGuid().ToString();
                istekList.Istek.Add(singleIstek);
            }

            try
            {
                using (var proxy = new BildirimServiceClient())
                {
                    cevap = proxy.BildirimServisBildirimKaydet(istekList);
                }
            }
            finally
            {
            }

            var sb = new StringBuilder();
            if (cevap.Sonuc != null)
            {
                // IList<OmegaHKS.BildirimServiceReference.BildirimKayitCevap> sonuc = new List<OmegaHKS.BildirimServiceReference.BildirimKayitCevap>();

                foreach (var item in cevap.Sonuc)
                {
                    if ((item == null) || (item.HataKodu == 0))
                    {
                        // Künye Bildirimi Tamam Olup Sunuc Üzerinde İşlem Yapılması Gerekiyor
                        bidirimSonuc.BildirimSonucItem.Add(item);
                    }
                    else
                    {
                        // Bildirim Yapılamadı Hata Mesajı Döndür İşlem Yap
                        sb.AppendFormat("{0} unique id'li bildirimin hata Kodu : {1}, Hata Mesajı : {2}\r\n", item.UniqueId, item.HataKodu, item.Mesaj);
                        bidirimSonuc.BildirimSonucItem.Add(item);
                    }
                }

                if (cevap.IslemKodu == ServiceConstants.Global.ServisIslemBasarili)
                {
                    bidirimSonuc.HataVarYok = false;
                    bidirimSonuc.HataMesaji = sb.ToString();
                }
                else
                {
                    bidirimSonuc.HataVarYok = true;
                    bidirimSonuc.HataMesaji = sb.ToString();
                }
            }
            else
            {
                bidirimSonuc.HataVarYok = false;
                bidirimSonuc.HataKodu = cevap.IslemKodu;
            }

            return bidirimSonuc;
        }

        //public BildirimKayitIstek WebBuildSingleIstek(long refKunye, int karsiDepo, Models.IrsaliyeDetay urun, string belgeNo)
        private BildirimKayitIstek WebBuildSingleIstek(Models.IRSALIYEURUNDETAYI urun)
        {
            return new BildirimKayitIstek()
            {
                BildirimciBilgileri = new BildirimciBilgileriDTO { KisiSifat = Core.StaticDegiskenler.BildirimciSifatId },
                BildirimTuru = Core.StaticDegiskenler.BidirimTuruId,
                IkinciKisiBilgileri = new IkinciKisiBilgileriDTO { TcKimlikVergiNo = Core.StaticDegiskenler.webServiceUser.UserName, KisiSifat = Core.StaticDegiskenler.GidecekYerSifatId },
                ReferansBildirimKunyeNo = GetReferansKunyeNo(urun.REFKUNYE),
                BildirimMalBilgileri = new BildirimMalBilgileriDTO { MalinSatisFiyat = 0, MalinMiktari = urun.TBIRIMMIK, MalinNiteligi = 1 },
                MalinGidecekYerBilgileri = GetMalinGidecekYerBilgileri(urun.ALDEP, urun.BELGENO),
                UniqueId = urun.UniqueId.ToString()
            };
        }

        //------------------------*/
        /*
        private void BildirimIslemleri(List<Models.Irsaliye> model)
        {
            Core.StaticDegiskenler.IslemHataListesi.Clear();

            if (model.Count <= 0)
            {
                Helpers.MessageHelper.ShowInformation("Bildirim Yapılacak İrsaliye Listesi Boş\nİrsaliye Seçmeniz Gerekir..");
                return;
            }

            // Ekrana Bildirim Yapılıyor
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Künye İşlemleri Yapılıyor...");

            // Controllorlar Hazırlanıyor
            var depController = new Controllers.LocalDepoDTOController();
            var controllerIrsaliyeDetay = new Controllers.IrsaliyeController();
            var bildirimController = new Controllers.BildirimController();
            // Liste Bilgileri Tanımlanıyor
            IList<Models.IrsaliyeDetay> BildirimYapilacakIrsaliyeUrunListesi = new List<Models.IrsaliyeDetay>();
            IList<Models.IrsaliyeDetay> bildirimBildirimYapilacakIrsaliyeUrunListesi = new List<Models.IrsaliyeDetay>();
            IList<BildirimSorguDTO> HksReferansBildirimSonucListesi = new List<BildirimSorguDTO>();


            var localControllers = new Controllers.LocalDepoDTOController();

            foreach (var irsaliyeListesi in model)
            {
                BildirimYapilacakIrsaliyeUrunListesi.Clear();
                bildirimBildirimYapilacakIrsaliyeUrunListesi.Clear();
                HksReferansBildirimSonucListesi.Clear();

                var bildirimYapanDepoNo = depController.GetLocalDepo(irsaliyeListesi.DEPNO).HKSID;
                var bidirimiYapanIsyeriTuru = depController.GetLocalDepo(irsaliyeListesi.DEPNO).HKSISYERITURU;

                //var bildirimYapanDepoNo = depController.GetLocalDepo(irs.DEPNO).HKSID;
                //var bidirimiYapanIsyeriTuru = depController.GetLocalDepo(irs.DEPNO).HKSISYERITURU;

                var irsaliyeEslestirilmisUrunListesi = controllerIrsaliyeDetay.GetUrunEslestirmeListesi(controllerIrsaliyeDetay.GetIrsaliyeDetayListesiAsilIRsaliye(irsaliyeListesi.IRSNO));


                var hata00 = string.Format("İrsaliyede Eşleşen Ürün Sayısı {0}", irsaliyeEslestirilmisUrunListesi.Where(w => w.URUNESLESTIRMETABLOSU.Count > 0).ToList().Count);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata00 });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata00 });
                logger.Info(hata00);

                foreach (var item in irsaliyeEslestirilmisUrunListesi.Where(w => w.URUNESLESTIRMETABLOSU.Count > 0).ToList())
                {
                    foreach (var i in item.URUNESLESTIRMETABLOSU)
                    {
                        hata00 = string.Format("Eşleşen Ürünler {0}  {1}   {2}   {3}", item.STKKOD, item.STOKAD,i.MALID,i.MALCINSID);
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata00 });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata00 });
                        logger.Info(hata00);
                    }
                }

                                var eslesmeyenUrunListesi = irsaliyeEslestirilmisUrunListesi.Where(w => w.URUNESLESTIRMETABLOSU.Count == 0).ToList();

                var AlinanKunyeler = controllerIrsaliyeDetay.GetIrsaliyeDetayListesi(irsaliyeListesi.IRSNO).Where(w => w.KUNYE > 0).ToList();


                foreach (var item in irsaliyeEslestirilmisUrunListesi)
                {
                    foreach (var i in AlinanKunyeler)
                    {
                        if( item.STKKOD ==  i.STKKOD)
                        {
                            item.KUNYEALINDI = true;
                        }
                    }
                }

                irsaliyeEslestirilmisUrunListesi = irsaliyeEslestirilmisUrunListesi.Where(w => w.KUNYEALINDI == false).ToList();

                //-----------Eşleşmeyen Ürün Listesini Log aga Yazdır
                if (eslesmeyenUrunListesi.Count > 0)
                {
                    var hata = string.Format("Eşleşmeyen Ürünler Var Bege No {0} İrsaliye No {1}", irsaliyeListesi.BELGENO, irsaliyeListesi.IRSNO);
                    logger.Error(hata);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });

                    foreach (var item in eslesmeyenUrunListesi)
                    {
                        hata = string.Format("Eşleşmeyen Ürünler Var Bege No {0} İrsaliye No {1} Stok Kodu {2} Stok Adi {3}", irsaliyeListesi.BELGENO, irsaliyeListesi.IRSNO, item.STKKOD, item.STOKAD);
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                        logger.Error(hata);
                    }
                }



                HksReferansBildirimSonucListesi = bildirimController.GetReferansBildirim(DateTime.Now.AddMonths(-1), DateTime.Now);
                HksReferansBildirimSonucListesi = HksReferansBildirimSonucListesi.Where(s => s.GidecekIsyeriId == bildirimYapanDepoNo && s.GidecekYerTuruId == bidirimiYapanIsyeriTuru).OrderBy(o => o.BildirimTarihi).ToList();
                irsaliyeEslestirilmisUrunListesi = irsaliyeEslestirilmisUrunListesi.Where(w => w.URUNESLESTIRMETABLOSU.Count > 0).ToList();




                foreach (var item in irsaliyeEslestirilmisUrunListesi)
                {

                    if (item.BIRIMTIP == Models.BrimTip.ADET || item.BIRIMTIP == Models.BrimTip.KG)
                    {
                        item.TBIRIMMIK = Math.Floor(item.TBIRIMMIK);
                    }
                    else
                    {
                        item.TBIRIMMIK = item.CEVRIMDEGER > 0 ? item.TBIRIMMIK / item.CEVRIMDEGER : item.TBIRIMMIK;
                        item.TBIRIMMIK = Math.Floor(item.TBIRIMMIK);
                    }

                    var HksReferansBildirimUrunMiktarKontroluListesi = new List<BildirimSorguDTO>();
                    foreach (var e in item.URUNESLESTIRMETABLOSU)
                    {
                        item.EslesmeDurumu = false;
                        HksReferansBildirimUrunMiktarKontroluListesi = HksReferansBildirimSonucListesi.Where(w => w.MalinCinsKodNo == e.MALCINSID && w.MalinKodNo == e.MALID).ToList();
                        if (HksReferansBildirimUrunMiktarKontroluListesi.Count > 0)
                        {
                            for (var i = 0; i < HksReferansBildirimUrunMiktarKontroluListesi.Count; i++)
                            {
                                if (HksReferansBildirimUrunMiktarKontroluListesi[i].KalanMiktar >= item.TBIRIMMIK && item.MALID == 0 && item.MALCINSID == 0)
                                {
                                    HksReferansBildirimUrunMiktarKontroluListesi[i].KalanMiktar = HksReferansBildirimUrunMiktarKontroluListesi[i].KalanMiktar - item.TBIRIMMIK;
                                    e.ESLESTIMI = true;
                                    item.EslesmeDurumu = true;
                                    item.BildirimEksik = false;
                                    item.MALID = e.MALID;
                                    item.MALCINSID = e.MALCINSID;
                                    item.MALTUR = e.MALTUR;
                                    item.URUNKOD = e.URUNKOD;
                                    item.REFKUNYE = HksReferansBildirimUrunMiktarKontroluListesi[i].KunyeNo;
                                    break;
                                }
                                else if (item.MALID == 0 && item.MALCINSID == 0)
                                {
                                    item.BildirimEksik = true;
                                }
                            }
                        }
                    }
                }

                var eksikUrunListesi = irsaliyeEslestirilmisUrunListesi.Where(w => w.BildirimEksik).ToList();
                var eslesenUrunListesi = irsaliyeEslestirilmisUrunListesi.Where(w => w.EslesmeDurumu).ToList();


                //-----------Eksik Bildirimli  Ürün Listesini Log aga Yazdır
                if (eksikUrunListesi.Count > 0)
                {
                    var hata = string.Format("HKS Sisteminde Eksik Bildirimli Ürünler Var Bege No {0} İrsaliye No {1}", irsaliyeListesi.BELGENO, irsaliyeListesi.IRSNO);
                    logger.Error(hata);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });

                    foreach (var item in eksikUrunListesi)
                    {
                        hata = string.Format("HKS Sisteminde Eksik Ürünler Var Bege No {0} İrsaliye No {1} Stok Kodu {2} Stok Adi {3}", irsaliyeListesi.BELGENO, irsaliyeListesi.IRSNO, item.STKKOD, item.STOKAD);
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                        logger.Error(hata);
                    }
                }

                if(eslesmeyenUrunListesi.Count > 0)
                {
                    var sonuc = Helpers.MessageHelper.ShowQuestion("Eşleşmeyen Ürünler Var Yinede Bidirim Yapılsın mı? ");
                    if (!sonuc)
                    {
                        ucsBTNKayitIpal1.KaydetEnabled = true;
                        ucsBTNKayitIpal1.IptalEnabled = true;
                        Core.StaticDegiskenler.AnlikIslem.Islem = false;
                        Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

                        return;
                    }
                }
                if(eksikUrunListesi.Count > 0)
                {
                    var sonuc = Helpers.MessageHelper.ShowQuestion("Eksik Bildirim Miktarlı Ürünler Var Yinede Bidirim Yapılsın mı? ");
                    if(!sonuc)
                    {
                        ucsBTNKayitIpal1.KaydetEnabled = true;
                        ucsBTNKayitIpal1.IptalEnabled = true;
                        Core.StaticDegiskenler.AnlikIslem.Islem = false;
                        Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

                        return;
                    }
                }

                //***************
                if (eslesenUrunListesi.Count > 0)
                {
                    IList<BildirimKayitIstek> brList = new List<BildirimKayitIstek>();
                    List<Models.LocalKunyeKayitBildirimSorguDTO> KunyeKayitList = new List<Models.LocalKunyeKayitBildirimSorguDTO>();
                    var etkList = new List<Models.LocalBildirimEtiketDTO>();

                    foreach (var item in eslesenUrunListesi)
                    {
                        brList.Add(WebBuildSingleIstek(item));
                    }

                    if (brList.Count > 0)
                    {
                        ///
                        /// Werb Service HKS Künye BildirimIslemleri
                        ///
                        ///
                        if (Core.StaticDegiskenler.Trial)
                        {
                            ucsBTNKayitIpal1.KaydetEnabled = true;
                            ucsBTNKayitIpal1.IptalEnabled = true;
                            Core.StaticDegiskenler.AnlikIslem.Islem = false;
                            Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

                            Helpers.MessageHelper.ShowInformation("Program Deneme Sürümüdür. Bildirim Yapmak İçin Lisans Almanız Gerekir.");
                            return;
                        }
                        else
                        {
                            var brSonuc = WebBildirimKayit(brList);
                            if(brSonuc.HataVarYok)
                            {

                                var hata = string.Format("İşlemlerde Hata Var Irsaliye Bilgisi: Belge No/Irsaliye No {0} / {1} Hata Kodu : {2}  Hata Mesajı : {3}", irsaliyeListesi.BELGENO, irsaliyeListesi.IRSNO, brSonuc.HataKodu, brSonuc.HataMesaji);
                                logger.Error(hata);
                                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });

                            }
                            else
                            {
                                var hataliKunyeler = brSonuc.BildirimSonucItem.Where(w => w.HataKodu != 0).ToList();

                                if(hataliKunyeler.Count>0)
                                {
                                    var hata = string.Format("Hatali Künye Islemleri Irsaliye Bilgisi: Belge No/Irsaliye No {0} / {1} Hata Sayisi : {2}  Hata Mesajı", irsaliyeListesi.BELGENO, irsaliyeListesi.IRSNO, hataliKunyeler.Count);
                                    logger.Info(hata);
                                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });

                                    foreach (var item in hataliKunyeler)
                                    {
                                        foreach (var es in eslesenUrunListesi)
                                        {

                                            hata = string.Format("Hata Bilgileri MalId: {0} MalCinsId: {1} Referans Kunye: {2} Hata Mesajı: {3}",
                                                        item.MalinKodNo,
                                                        item.MalinCinsiId,
                                                        item.HataKodu,                 
                                                        item.Mesaj);

                                            logger.Error(hata);
                                            Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                                            Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });

                                        }
                                    }
                                }

                                var hatasizKunyeler = brSonuc.BildirimSonucItem.Where(w => w.HataKodu == 0).ToList();


                                if (hatasizKunyeler.Count > 0)
                                {
                                    var hata = string.Format("Alınan Künyeler Irsaliye Bilgisi: Belge No/Irsaliye No {0} / {1} Künye Sayısı Sayisi : {2} ", irsaliyeListesi.BELGENO, irsaliyeListesi.IRSNO, hatasizKunyeler.Count);
                                    logger.Info(hata);
                                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });

                                    foreach (var item in hatasizKunyeler)
                                    {
                                        foreach (var es in eslesenUrunListesi)
                                        {
                                            var localDepo = new Models.LocalDepo();
                                            localDepo = localControllers.GetLocalDepo(es.ALDEP);


                                            if (item.MalinCinsiId == es.MALCINSID && item.MalinKodNo == es.MALID)
                                            {
                                                etkList.Add(new Models.LocalBildirimEtiketDTO
                                                {
                                                    STKKOD = es.STKKOD,
                                                    DEPNO = es.ALDEP,
                                                    KayitTarihi = item.KayitTarihi,
                                                    UreticisininAdUnvani = item.UreticisininAdUnvani,
                                                    MalinKunyeNo = item.YeniKunyeNo,
                                                    MalinAdi = es.MALAD,
                                                    BelgeNo = item.BelgeNo,
                                                    PlakaNo = item.AracPlakaNo,
                                                    IlId = (int)localDepo.HKSILID,
                                                    IlceId = (int)localDepo.HKSILCEID,
                                                    BeldeId = (int)localDepo.HKSBELDEID,
                                                    UretimSekliAdi = item.UretimSekli.ToString()
                                                });


                                                //************************
                                                KunyeKayitList.Add(new Models.LocalKunyeKayitBildirimSorguDTO
                                                {
                                                    IRSTARIHI = es.TARIH,
                                                    BildirimTarihi = item.KayitTarihi,
                                                    DEPNO = es.ALDEP,
                                                    IRSNO = es.IRSNO,
                                                    STKKOD = es.STKKOD,
                                                    YeniKunye = item.YeniKunyeNo,
                                                    KunyeNo = es.REFKUNYE,
                                                    MalinCinsKodNo = es.MALCINSID,
                                                    MalinKodNo = es.MALID,
                                                    BelgeNo = es.BELGENO,
                                                    MalinMiktari = es.BIRIMMIK,
                                                     BelgeTipi = item.BelgeTipi
                                                    
                                                });



                                                hata = string.Format("Yeni Oluşan Künyeler Stk Kod: {0} Sotk Ad: {1} MalId: {2} MalCinsId: {3} Referans Kunye: {4} Yeni Künye: {5}",
                                                    es.STKKOD,
                                                    es.STOKAD,
                                                    es.MALID,
                                                    es.MALCINSID,
                                                    es.REFKUNYE,
                                                    item.YeniKunyeNo);

                                                logger.Info(hata);
                                                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                                                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                                            }

                                        }
                                    }
                                }
                            }



                        }
                    }
                    var kunyeKayit = bildirimController.SaveKunyeBildirim(KunyeKayitList);
                    var etkKayit = bildirimController.BildirimEtiketKayit(etkList);
                }

                //*****
            }

                                  

            ///

            var liste = bildirimController.EtiketBelgeListesi(DateTime.Now);
            if (liste.Count > 0)
            {
                foreach (var item in liste)
                {
                    var EtiketListesi = GetKunyeEtiketKayit(item.PLAKANO, item.BELGENO, item.TARIH, item.BELDEID, item.ILCEID, item.ILID);
                    if (EtiketListesi.Count > 0)
                    {
                        bildirimController.BildirimEtiketGuncelle(EtiketListesi);
                    }
                }
            }

            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();

            if (Core.StaticDegiskenler.IslemHataListesi.Count > 0)
            {

                var bilgiListesi = Core.StaticDegiskenler.IslemHataListesi.Where(s => s.HataTipi == "Error").ToList();
                if (bilgiListesi.Count == 0)
                {
                    Helpers.MessageHelper.ShowInformation("İşlemler Başarılı Bir Şekilde Tamamlandı.\r\nYapılan İşlemler. İşlem Sayısı :" + Core.StaticDegiskenler.IslemHataListesi.Count);
                    Helpers.HataBilgileri.HataGosterDialog(Core.StaticDegiskenler.IslemHataListesi);

                }
                else
                {
                    Helpers.MessageHelper.ShowInformation("İşlemler Hatalı Bir Şekilde Tamamlandı.\r\nOluşan Hatalar Var. Hata Sayısı :" + Core.StaticDegiskenler.IslemHataListesi.Count);
                    Helpers.HataBilgileri.HataGosterDialog(Core.StaticDegiskenler.IslemHataListesi);
                }
                ucsBTNKayitIpal1.KaydetEnabled = true;
                ucsBTNKayitIpal1.IptalEnabled = true;
                Core.StaticDegiskenler.AnlikIslem.Islem = false;
                Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

            }
            else
            {
                ucsBTNKayitIpal1.KaydetEnabled = true;
                ucsBTNKayitIpal1.IptalEnabled = true;
                Core.StaticDegiskenler.AnlikIslem.Islem = false;
                Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

                Helpers.MessageHelper.ShowInformation("İşlemler Başarılı Bir Şekilde Gerçekleşti...");
            }
        }

        */

        private List<BildirimEtiketDTO> GetKunyeEtiketKayit(string plaka, string belgeNo, DateTime tarih, int beldeId, int ilceId, int ilId)
        {
            var result = new List<BildirimEtiketDTO>();
            BaseResponseMessageOf_BildirimEtiketCevap cevap = null;

            var istek = new BaseRequestMessageOf_BildirimEtiketIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new BildirimEtiketIstek()
                {
                    AracPlakaNo = plaka,
                    BelgeNo = belgeNo,
                    BildirimTarihi = tarih,
                    GidecekYerBeldeId = beldeId,
                    GidecekYerIlceId = ilceId,
                    GidecekYerIlId = ilId,
                    MalinSahibiTcKimlikNo = Core.StaticDegiskenler.webServiceUser.UserName
                }
            };
            try
            {
                //DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Etiket İşlemleri Yapılıyor...");

                using (var proxy = new BildirimServiceClient())
                {
                    cevap = proxy.BildirimServisBildirimEtiket(istek);
                }
            }
            finally
            {
                //DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
            if (cevap.Sonuc != null)
            {
                if ((cevap.Sonuc.HataKodu == 0))
                {
                    var kunyeLis = cevap.Sonuc.Kunyeler;
                    result = kunyeLis;
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
                    Helpers.MessageHelper.ShowInformation(cevap.IslemKodu);
                }
            }
            return result;
        }
        private void BildirimIslemleri(List<Models.Irsaliye> model)
        {
            Core.StaticDegiskenler.IslemHataListesi.Clear();

            if (model.Count <= 0)
            {
                Helpers.MessageHelper.ShowInformation("Bildirim Yapılacak İrsaliye Listesi Boş\nİrsaliye Seçmeniz Gerekir..");
            }

            var depController = new Controllers.LocalDepoDTOController();
            var controllerIrsaliyeDetay = new Controllers.IrsaliyeController();
            var bildirimController = new Controllers.BildirimController();

            IList<Models.IrsaliyeDetay> BildirimYapilacakIrsaliyeUrunListesi = new List<Models.IrsaliyeDetay>();
            IList<Models.IrsaliyeDetay> bildirimBildirimYapilacakIrsaliyeUrunListesi = new List<Models.IrsaliyeDetay>();
            IList<BildirimSorguDTO> HksReferansBildirimSonucListesi = new List<BildirimSorguDTO>();

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Künye İşlemleri Yapılıyor...");

            foreach (var irs in model)
            {
                if(string.IsNullOrEmpty(  irs.BELGENO))
                {
                    var hata = "Bildirim Yapılabilmesi İcin Belge No Zorunludur İrsaliye No " + irs.IRSNO.ToString();
                    Helpers.MessageHelper.ShowError(hata);

                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });


                    ucsBTNKayitIpal1.KaydetEnabled = true;
                    ucsBTNKayitIpal1.IptalEnabled = true;
                    Core.StaticDegiskenler.AnlikIslem.Islem = false;
                    Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

                    return;
                }


                var bildirimYapanDepoNo = depController.GetLocalDepo(irs.DEPNO).HKSID;
                var bidirimiYapanIsyeriTuru = depController.GetLocalDepo(irs.DEPNO).HKSISYERITURU;

                BildirimYapilacakIrsaliyeUrunListesi.Clear();
                bildirimBildirimYapilacakIrsaliyeUrunListesi.Clear();
                HksReferansBildirimSonucListesi.Clear();

                BildirimYapilacakIrsaliyeUrunListesi = controllerIrsaliyeDetay.GetIrsaliyeDetayListesi(irs.IRSNO).Where(s => s.KUNYE == 0).ToList();


                Core.StaticDegiskenler.IslemYapilanIrsaliye = controllerIrsaliyeDetay.GetIrsaliyeDetayListesiAsilIRsaliye(irs.IRSNO);
                // Bildirimlerin Etiket Tablosuna Tek işlenmesi icin HksReferansBildirimUrunMiktarKontroluListesi

                HksReferansBildirimSonucListesi = bildirimController.GetReferansBildirim(DateTime.Now.AddMonths(-1), DateTime.Now);
                HksReferansBildirimSonucListesi = HksReferansBildirimSonucListesi.Where(s => s.GidecekIsyeriId == bildirimYapanDepoNo
                        && s.GidecekYerTuruId == bidirimiYapanIsyeriTuru).OrderBy(o => o.BildirimTarihi).ToList();  //s.GidecekYerTuruId == 6

                foreach (var byiul in BildirimYapilacakIrsaliyeUrunListesi)
                {

                    //byiul.TBIRIMMIK = byiul.CEVRIMDEGER > 0 ? byiul.TBIRIMMIK / byiul.CEVRIMDEGER : byiul.TBIRIMMIK;
                    //byiul.TBIRIMMIK = Math.Floor(byiul.TBIRIMMIK);

                    //if (byiul.BIRIMTIP == byiul.CEVBIRIMTIP)
                    //{
                    //    byiul.TBIRIMMIK = Math.Floor(byiul.TBIRIMMIK);
                    //}
                    //else
                    //{
                    //    byiul.TBIRIMMIK = byiul.CEVRIMDEGER > 0 ? byiul.TBIRIMMIK / byiul.CEVRIMDEGER : byiul.TBIRIMMIK;
                    //    byiul.TBIRIMMIK = Math.Floor(byiul.TBIRIMMIK);
                    //}

                    
                    ///---------------------------
                    //if (byiul.BIRIMTIP == Models.BrimTip.ADET || byiul.BIRIMTIP == Models.BrimTip.KG)
                    //{
                    //    byiul.TBIRIMMIK = Math.Floor(byiul.TBIRIMMIK);
                    //}
                    //else
                    //{
                    //    byiul.TBIRIMMIK = byiul.CEVRIMDEGER > 0 ? byiul.TBIRIMMIK / byiul.CEVRIMDEGER : byiul.TBIRIMMIK;
                    //    byiul.TBIRIMMIK = Math.Floor(byiul.TBIRIMMIK);
                    //}
                    ///-----------------------------
                    

                    if(byiul.CEVBIRIMTIP == byiul.BIRIMTIP)
                    {
                        byiul.TBIRIMMIK =(byiul.BIRIMMIK / byiul.CEVRIMDEGER);

                        byiul.TBIRIMMIK = Math.Round(byiul.TBIRIMMIK, 3) ;
                    }
                    else
                    {
                        byiul.TBIRIMMIK = Math.Round(byiul.TBIRIMMIK, 3);
                    }

                    var HksReferansBildirimUrunMiktarKontroluListesi = new List<BildirimSorguDTO>();

                    HksReferansBildirimUrunMiktarKontroluListesi = HksReferansBildirimSonucListesi.Where(w => w.MalinCinsKodNo == byiul.MALCINSID && w.MalinKodNo == byiul.MALID).ToList();
                    if (HksReferansBildirimUrunMiktarKontroluListesi.Count > 0)
                    {
                        for (var rbumkl = 0; rbumkl < HksReferansBildirimUrunMiktarKontroluListesi.Count; rbumkl++)
                        {
                            if (HksReferansBildirimUrunMiktarKontroluListesi[rbumkl].KalanMiktar >= byiul.TBIRIMMIK)
                            {
                                HksReferansBildirimUrunMiktarKontroluListesi[rbumkl].KalanMiktar = HksReferansBildirimUrunMiktarKontroluListesi[rbumkl].KalanMiktar - byiul.TBIRIMMIK;
                                byiul.KUNYE = HksReferansBildirimUrunMiktarKontroluListesi[rbumkl].KunyeNo;
                                byiul.SifatId = HksReferansBildirimUrunMiktarKontroluListesi[rbumkl].GidecekYerTuruId;

                                bildirimBildirimYapilacakIrsaliyeUrunListesi.Add(byiul);
                                byiul.BildirimEksik = false;
                                byiul.EslesmeDurumu = true;

                                logger.Info(string.Format("{0} {1} {2} {3} İrsaliye Miktarı {4} HKS Kalan Miktar {5}",
                                    byiul.STKKOD.PadRight(11),
                                    byiul.STOKAD.PadRight(25),
                                    byiul.KUNYE.ToString().PadRight(20),
                                    HksReferansBildirimUrunMiktarKontroluListesi[rbumkl].KunyeNo.ToString().PadRight(25),
                                    byiul.TBIRIMMIK.ToString().PadRight(15),
                                    HksReferansBildirimUrunMiktarKontroluListesi[rbumkl].KalanMiktar.ToString().PadRight(15)));
                                break;
                            }
                            else
                            {
                                byiul.BildirimEksik = true;
                            }
                        }
                        foreach (var eksilt in HksReferansBildirimSonucListesi)
                        {
                            foreach (var k in HksReferansBildirimUrunMiktarKontroluListesi)
                            {
                                if (eksilt.KunyeNo == k.KunyeNo)
                                {
                                    eksilt.KalanMiktar = k.KalanMiktar;
                                }
                            }
                        }
                    }
                }

                logger.Info("Eşleşen Ürünlerin Listesi");
                logger.Info("--------------------------------------");
                foreach (var cc in BildirimYapilacakIrsaliyeUrunListesi)
                {
                    logger.Info(string.Format("{0} {1} {2} {3} {4}",
                            cc.STKKOD.PadRight(11),
                            cc.STOKAD.PadRight(25),
                            cc.KUNYE.ToString().PadRight(20),
                            cc.REFKUNYE.ToString().PadRight(20),
                            cc.TBIRIMMIK.ToString().PadRight(15)));
                }
                logger.Info("--------------------------------------");

                var EslsmesiOlmayanUrunListesi = BildirimYapilacakIrsaliyeUrunListesi.Where(s => s.MALID <= 0).ToList();

                var HksSistemindeEksikOlanUrunListesi = BildirimYapilacakIrsaliyeUrunListesi.Where(s => s.BildirimEksik == true).ToList();

                if (EslsmesiOlmayanUrunListesi.Count > 0)
                {
                    var hata0 = string.Format("HSK ile Sistemde Arasında Eşleşmeyen Ürünler Var.. İrsaliye No :  {0}  Belge No  :{1}", irs.IRSNO, irs.BELGENO);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata0 });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata0 });
                    logger.Error(hata0);
                    foreach (Models.IrsaliyeDetay s in EslsmesiOlmayanUrunListesi)
                    {
                        var hata = string.Format("Eşleşmeyen Ürün Bilgileri İrsaliye No :{0}  Ürün : {1} Stok {2} Miktar {3} Ürün Id {4} Cins Id : {5}",
                                s.IRSNO.ToString().PadRight(10),
                                s.STKKOD.ToString().PadRight(15),
                                s.STOKAD.PadRight(25),
                                s.TBIRIMMIK.ToString("N2").PadRight(15),
                                s.MALID,
                                s.MALCINSID);
                        logger.Error(hata);
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                    }
                }

                if (HksSistemindeEksikOlanUrunListesi.Count > 0)
                {
                    var hata0 = string.Format("HSK'den Alınan Ürünlerde Eksik Ürün Var.. İrsaliye No  : {0} Belge No :{1}",
                                    irs.IRSNO.ToString().PadRight(8),
                                    irs.BELGENO.PadRight(12));
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = hata0 });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = hata0 });
                    logger.Info(hata0);

                    foreach (Models.IrsaliyeDetay s in HksSistemindeEksikOlanUrunListesi)
                    {
                        var hata = string.Format("Eksik Miktar Bilgileri İrsaliye No :{0} Ürün : {1} Stok {2} Miktar : {3} Ürün Id :{4} Cins Id : {5}",
                                s.IRSNO.ToString().PadRight(10),
                                s.STKKOD.ToString().PadRight(15),
                                s.STOKAD.PadRight(25),
                                s.TBIRIMMIK.ToString("N2").PadRight(15),
                                s.MALID.ToString().PadRight(5),
                                s.MALCINSID.ToString().PadRight(5));
                        logger.Error(hata);
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = hata });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = hata });
                    }
                }

                if (HksSistemindeEksikOlanUrunListesi.Count > 1)
                {
                    var hata0 = string.Format("HSK'den Alınan Ürünlerde Eksik Ürün Var.. İrsaliye No  : {0} Belge No :{1}",
                                    irs.IRSNO.ToString().PadRight(8),
                                    irs.BELGENO.PadRight(12));
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata0 });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata0 });
                    logger.Error(hata0);

                    foreach (Models.IrsaliyeDetay s in HksSistemindeEksikOlanUrunListesi)
                    {
                        var hata = string.Format("Eksik Miktar Bilgileri İrsaliye No :{0} Ürün : {1} Stok {2} Miktar : {3} Ürün Id :{4} Cins Id : {5}",
                                s.IRSNO.ToString().PadRight(10),
                                s.STKKOD.ToString().PadRight(15),
                                s.STOKAD.PadRight(25),
                                s.TBIRIMMIK.ToString("N2").PadRight(15),
                                s.MALID.ToString().PadRight(5),
                                s.MALCINSID.ToString().PadRight(5));

                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                    }
                }

                ///********************************
                bildirimBildirimYapilacakIrsaliyeUrunListesi = bildirimBildirimYapilacakIrsaliyeUrunListesi.GroupBy(test => test.STKKOD)
                               .Select(grp => grp.First())
                               .ToList();

                ///********************************
                ///

                var bildirim = bildirimBildirimYapilacakIrsaliyeUrunListesi.GroupBy(test => test.STKKOD)
                       .Select(grp => grp.First())
                       .ToList();

                logger.Info("Künye Alımı İçin Tekil ID Bilgileri");
                foreach (var item in bildirim)
                {
                    item.UniqueId = Guid.NewGuid();
                    logger.Info(string.Format("{0} {1} {2} {3}",
                        item.STKKOD.PadRight(11),
                        item.STOKAD.PadRight(25),
                        item.KUNYE.ToString().PadRight(20),
                        item.UniqueId.ToString().PadRight(40)));
                }
                logger.Info("Künye Alımı İçin Tekil ID Bilgileri Sonu");

                Core.StaticDegiskenler.IslemYapilanIrsaliye.Clear();
                Core.StaticDegiskenler.IslemYapilanIrsaliye = bildirim;

                //if (bildirimBildirimYapilacakIrsaliyeUrunListesi.Count > 0)
                if (bildirim.Count > 0)
                {
                    IList<BildirimKayitIstek> brList = new List<BildirimKayitIstek>();

                    foreach (var item in bildirim)
                    {
                        brList.Add(bildirimController.WebBuildSingleIstek(item.KUNYE, item.ALDEP, item, irs.BELGENO));
                        BildirimYapanDepoNoEtiketIcin = item.ALDEP;
                        BildirimTairih = DateTime.Now;
                    }

                    //---------KONTROL----------------------------

                    var xxx = brList;
                    foreach (var item in xxx)
                    {
                        logger.Info(string.Format("{0} {1} {2} {3}",
                            item.BildirimMalBilgileri.MalinCinsiId,
                            item.BildirimMalBilgileri.MalinKodNo,
                            item.BildirimMalBilgileri.MalinMiktari,
                            item.ReferansBildirimKunyeNo));
                    }

                    //---------KONTROL----------------------------

                    if (brList.Count > 0)
                    {
                        ///
                        /// Werb Service HKS Künye BildirimIslemleri
                        ///
                        ///
                        if (Core.StaticDegiskenler.Trial)
                        {
                            ucsBTNKayitIpal1.KaydetEnabled = true;
                            ucsBTNKayitIpal1.IptalEnabled = true;
                            Core.StaticDegiskenler.AnlikIslem.Islem = false;
                            Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

                            Helpers.MessageHelper.ShowInformation("Program Deneme Sürümüdür. Bildirim Yapmak İçin Lisans Almanız Gerekir.");
                            return;
                        }
                        else
                        {
                            var HskBildirimSonucList = bildirimController.WebBildirimKayit(brList, bildirimBildirimYapilacakIrsaliyeUrunListesi);
                            var sonuc = bildirimController.SaveRefaransBildirim(HksReferansBildirimSonucListesi);

                            if (!HskBildirimSonucList)
                            {
                                var irsUpdate = new Controllers.IrsaliyeController();
                                var irsUp = irsUpdate.UpdateIrsaliyeTarih(irs.IRSNO, DateTime.Now);
                                if (!irsUp)
                                {
                                    var hata = string.Format("Irsaliye Kapatma İşleminde Hata Oluşt.. İrsaliye No :{0} Belge No :{1}", irs.IRSNO, irs.BELGENO);
                                    logger.Error(hata);
                                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                                }
                            }
                        }
                    }
                }
                else
                {
                    var hata = string.Format("Bildirim Yapılamadı Tüm İşlemler İptal Edildi.. İrsaliye No :{0} Belge No :{1}", irs.IRSNO, irs.BELGENO);
                    logger.Error(hata);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                }
            }

            var liste = bildirimController.EtiketBelgeListesi(DateTime.Now);
            if (liste.Count > 0)
            {
                foreach (var item in liste)
                {
                    var EtiketListesi = GetKunyeEtiketKayit(item.PLAKANO, item.BELGENO, item.TARIH, item.BELDEID, item.ILCEID, item.ILID);
                    if (EtiketListesi.Count > 0)
                    {
                        bildirimController.BildirimEtiketGuncelle(EtiketListesi);
                    }
                    
                    //------ Etiket Listesi Kontrol
                    //*********
                    DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Etiket Kontrolleri Yapılıyor...");
                    var kontrol = bildirimController.GetEkitekKontrolListesi(BildirimTairih, BildirimYapanDepoNoEtiketIcin);
                    bool ekontrol = false;
                    bool eekontrol = false;

                    //*********
                    // Etiket İsimleri Kontrol

                    do
                    {
                        foreach (var e in EtiketListesi)
                        {
                            foreach (var k in kontrol)
                            {
                                if (e.MalinKunyeNo.ToString() == k.KUNYENO)
                                {
                                    if (e.MalinAdi.ToUpper() != k.MALAD.ToUpper() || e.MalinCinsAdi.ToUpper() != k.MALCINSAD.ToUpper() || e.UretimYeri.ToUpper() != k.URETIMYERI.ToUpper())
                                    {
                                        ekontrol = true;
                                    }
                                }
                            }
                        }

                        if (ekontrol)
                        {
                            EtiketListesi = GetKunyeEtiketKayit(item.PLAKANO, item.BELGENO, item.TARIH, item.BELDEID, item.ILCEID, item.ILID);
                            if (EtiketListesi.Count > 0)
                            {
                                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("Eksik Etiketler Tekrar İşleniyor...");

                                bildirimController.BildirimEtiketGuncelle(EtiketListesi);
                            }
                        }

                        kontrol.Clear();
                        kontrol = bildirimController.GetEkitekKontrolListesi(BildirimTairih, BildirimYapanDepoNoEtiketIcin);

                        ekontrol = false;
                        eekontrol = false;

                        foreach (var e in EtiketListesi)
                        {
                            foreach (var k in kontrol)
                            {
                                if (e.MalinKunyeNo.ToString() == k.KUNYENO)
                                {
                                    if (e.MalinAdi.ToUpper() != k.MALAD.ToUpper() || e.MalinCinsAdi.ToUpper() != k.MALCINSAD.ToUpper() || e.UretimYeri.ToUpper() != k.URETIMYERI.ToUpper())
                                    {
                                        eekontrol = true;
                                        logger.Error(" Eksik Etiket li Ürünler var Künye" + e.MalinKunyeNo.ToString());
                                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = " Eksik Etiket li Ürünler var Künye" + e.MalinKunyeNo.ToString() });
                                    }
                                }
                            }
                        }
                      
                        ekontrol = false;
                    }

                    while (eekontrol);


                    //*****************
                    // Etiket İsimleri Kontrol Sonu

                    //kontrol = bildirimController.GetEkitekKontrolListesi(BildirimTairih, BildirimYapanDepoNoEtiketIcin);

                    //if (kontrol.Count > 0)
                    //{

                    //    foreach (var kk in kontrol)
                    //    {
                    //        if (string.IsNullOrEmpty(kk.MALAD) || string.IsNullOrEmpty(kk.MALCINSAD) || string.IsNullOrEmpty(kk.URETIMYERI) || string.IsNullOrEmpty(kk.URETIMSEKLI))
                    //        {
                    //            ekontrol = true;
                    //        }
                    //    }
                    //}

                    ////------ Etiket Listesi Kontrol
                    //if (ekontrol)
                    //{
                    //    EtiketListesi = GetKunyeEtiketKayit(item.PLAKANO, item.BELGENO, item.TARIH, item.BELDEID, item.ILCEID, item.ILID);
                    //    if (EtiketListesi.Count > 0)
                    //    {
                    //        DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("Eksik Etiketler Tekrar İşleniyor...");

                    //        bildirimController.BildirimEtiketGuncelle(EtiketListesi);
                    //    }
                    //}

                }
            }

            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();

            if (Core.StaticDegiskenler.IslemHataListesi.Count > 0)
            {

                var bilgiListesi = Core.StaticDegiskenler.IslemHataListesi.Where(s => s.HataTipi == "Error").ToList();
                if (bilgiListesi.Count == 0)
                {
                    Helpers.MessageHelper.ShowInformation("İşlemler Başarılı Bir Şekilde Tamamlandı.\r\nYapılan İşlemler. İşlem Sayısı :" + Core.StaticDegiskenler.IslemHataListesi.Count);
                    Helpers.HataBilgileri.HataGosterDialog(Core.StaticDegiskenler.IslemHataListesi);

                }
                else
                {
                    Helpers.MessageHelper.ShowInformation("İşlemler Hatalı Bir Şekilde Tamamlandı.\r\nOluşan Hatalar Var. Hata Sayısı :" + Core.StaticDegiskenler.IslemHataListesi.Count);
                    Helpers.HataBilgileri.HataGosterDialog(Core.StaticDegiskenler.IslemHataListesi);
                }
                ucsBTNKayitIpal1.KaydetEnabled = true;
                ucsBTNKayitIpal1.IptalEnabled = true;
                Core.StaticDegiskenler.AnlikIslem.Islem = false;
                Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

            }
            else
            {
                ucsBTNKayitIpal1.KaydetEnabled = true;
                ucsBTNKayitIpal1.IptalEnabled = true;
                Core.StaticDegiskenler.AnlikIslem.Islem = false;
                Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

                Helpers.MessageHelper.ShowInformation("İşlemler Başarılı Bir Şekilde Gerçekleşti...");
            }
        }
    }
}
