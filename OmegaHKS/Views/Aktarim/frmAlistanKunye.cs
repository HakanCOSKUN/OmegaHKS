using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NLog;
using OmegaHKS.Models;

namespace OmegaHKS.Views.Aktarim
{
    public partial class frmAlistanKunye : BaseForm
    {
        private List<Models.AlisIrsaliye> tmpIrsaliyeListesi = new List<Models.AlisIrsaliye>();
        private List<Models.AlisIrsaliye> tmpPlakasizIrsaliyeListesi = new List<Models.AlisIrsaliye>();
        private List<OmegaHKS.BildirimServiceReference.BildirimSorguDTO> tmpBildirimList = new List<BildirimServiceReference.BildirimSorguDTO>();
        private Logger logger = LogManager.GetCurrentClassLogger();

        private Guid PidID;
        public frmAlistanKunye()
        {
            InitializeComponent();

            txtDateEditTarihB.EditValue = DateTime.Now;
            txtDateEditTarihS.EditValue = DateTime.Now;
            PidID = Guid.NewGuid();
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();

            gvIrsaliyeListesi.SecimColumnGoster();
        }

        private void txtBtnIrsaliyeDeposu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        private void txtBtnCariFirma_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var btnEdit = sender as ButtonEdit;
            var str = string.IsNullOrEmpty(btnEdit.Text) ? null : btnEdit.Text;

            Core.StaticDegiskenler.tmpCari = null;
            Core.StaticDegiskenler.CariKod = null;

            var sonuc = string.Empty;
            sonuc = Helpers.Aktarimlar.CariArama(str);
            if (!string.IsNullOrEmpty(sonuc))
            {
                btnEdit.Tag = Core.StaticDegiskenler.tmpCari.CARKOD;
                btnEdit.Text = Core.StaticDegiskenler.tmpCari.UNVAN;
            }
        }

        private void btnIrsaliyeleriListele_Click(object sender, EventArgs e)
        {
            var cari = string.Empty;
            if (txtBtnIrsaliyeDeposu.Text != null && txtBtnCariFirma.Text != string.Empty)
            {
                if (txtBtnCariFirma.Text == string.Empty)
                {
                    txtBtnCariFirma.Tag = "";
                }
                else
                {
                    cari = txtBtnCariFirma.Tag.ToString();
                }
                var irsController = new Controllers.IrsaliyeController();

                var depo = (int)txtBtnIrsaliyeDeposu.Tag;
                var tarihb = Convert.ToDateTime(txtDateEditTarihB.Text);
                var tarihs = Convert.ToDateTime(txtDateEditTarihS.Text);
                gcIrsaliyeListesi.DataSource = irsController.GetAlisIrsaliyeListesi(tarihb, tarihs, depo,cari,  chKunyeDahil.Checked);
            }
            else
            {
                Helpers.MessageHelper.ShowError("Cari Firma Bilgilerini Girmeniz Meçburidir.");
            }
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            if (Core.StaticDegiskenler.AnlikIslem.IslemPidId != PidID)
            {
                this.Close();
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

                    tmpIrsaliyeListesi = gvIrsaliyeListesi.GetSelectedItems<Models.AlisIrsaliye>();



                    //foreach (var item in tmpIrsaliyeListesi)
                    //{
                    //    if(string.IsNullOrEmpty( item.PLAKANO) )
                    //    {
                    //        tmpPlakasizIrsaliyeListesi.Add(item);
                    //    }
                    //}
                    if(tmpIrsaliyeListesi.Where(s=>s.PLAKANO == null).ToList().Count>0)
                    {
                        ucsBTNKayitIpal1.KaydetEnabled = true;
                        ucsBTNKayitIpal1.IptalEnabled = true;
                        Core.StaticDegiskenler.AnlikIslem.Islem = false;
                        Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

                        Helpers.MessageHelper.ShowError("Plaka No Eksik Olan İrsaliyeler Mevcut Eksik Bilgileri Girmeniz Gerekir..!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Iselem Yap");
                        this.AlisIrsaliyeleriIslemeAl(tmpIrsaliyeListesi);

                        ucsBTNKayitIpal1.KaydetEnabled = true;
                        ucsBTNKayitIpal1.IptalEnabled = true;
                        Core.StaticDegiskenler.AnlikIslem.Islem = false;
                        Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();
                    }

                    // BildirimIslemleri(tmpIrsaliyeListesi);
                }
                else
                {
                    Helpers.MessageHelper.ShowError("Devam eden işlem var işlemin bitmesini bekleyin lütfen ...!");
                }
            }
            else
            {
                Helpers.MessageHelper.ShowInformation("Bildirim Yapılacak İrsaliye Listesi Boş\nİrsaliye Seçmeniz Gerekir..");
            }
        }

        private IList<Models.IrsaliyeDetay> GetIrsaliyeDetayListesi(int irsNo)
        {
            IList<Models.IrsaliyeDetay> result = new List<Models.IrsaliyeDetay>();
            var irsControllers = new Controllers.IrsaliyeController();
            result = irsControllers.GetIrsaliyeDetayListesi(irsNo);
            return result;
        }

        private List<OmegaHKS.BildirimServiceReference.BildirimEtiketDTO> GetKunyeEtiketKayit(string plaka, string belgeNo, DateTime tarih, int beldeId, int ilceId, int ilId)
        {
            var result = new List<OmegaHKS.BildirimServiceReference.BildirimEtiketDTO>();
            BildirimServiceReference.BaseResponseMessageOf_BildirimEtiketCevap cevap = null;

            var istek = new BildirimServiceReference.BaseRequestMessageOf_BildirimEtiketIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new BildirimServiceReference.BildirimEtiketIstek()
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
                using (var proxy = new BildirimServiceReference.BildirimServiceClient())
                {
                    cevap = proxy.BildirimServisBildirimEtiket(istek);
                }
            }
            finally
            {
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


        private void AlisIrsaliyeleriIslemeAl(List<AlisIrsaliye> tmpIrsaliyeListesi)
        {
            if(tmpIrsaliyeListesi.Count<=0)
            {
                return;
            }
            BildirimServiceReference.BaseResponseMessageOf_BildirimSorguCevap cevap = null;

            var istek = new BildirimServiceReference.BaseRequestMessageOf_BildirimSorguIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new BildirimServiceReference.BildirimSorguIstek()
                {
                    KunyeTuru = 2,
                    KunyeNo = Convert.ToInt64(0),
                    BaslangicTarihi = Convert.ToDateTime(DateTime.Now),
                    BitisTarihi = Convert.ToDateTime(DateTime.Now),
                    KalanMiktariSifirdanBuyukOlanlar = true,
                }
            };

            try
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Sisteminden Veriler Okunuyor...");

                if (!Helpers.GenerelHelper.IsConnected())
                {
                    Helpers.MessageHelper.ShowInformation("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!");
                    return;
                }

                using (var proxy = new BildirimServiceReference.BildirimServiceClient())
                {
                    cevap = proxy.BildirimServisBildirimSorgu(istek);
                }
            }
            finally
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
            if (cevap.Sonuc != null)
            {
                if ((cevap.Sonuc.HataKodu == 0))
                {
                    tmpBildirimList = cevap.Sonuc.Bildirimler;
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


            var depoIrsaliBildirimList = new  List<Models.LocalBildirimSorguDTO>();


            /// Nihai Bildirim Listesi Oluştuktan Sonra
            if (tmpBildirimList.Count>0)
            {







                /// Irsaliye Detay İşlemleri
                foreach (var item in tmpIrsaliyeListesi)
                {
                    var bilDepoListe = tmpBildirimList.Where(s => s.GidecekIsyeriId == item.HksID).ToList();
                    foreach (var x in bilDepoListe)
                    {
                        //depoIrsaliBildirimList.Add(new Models.LocalBildirimSorguDTO { BelgeNo = x.BelgeNo,
                        //    BelgeTipi = x.BelgeTipi,
                        //     BildirimciTcKimlikVergiNo = x.BildirimciTcKimlikVergiNo,
                        //         BildirimTarihi = x.BildirimTarihi,
                        //          GidecekIsyeriId = x.GidecekIsyeriId,
                        //            GidecekYerTuruId = x.GidecekYerTuruId,
                                     
                        //});
                    }





                    IList<Models.IrsaliyeDetay> irsDetay = new List<Models.IrsaliyeDetay>();
                    irsDetay = this.GetIrsaliyeDetayListesi(item.IRSNO);
                    if(irsDetay.Count>0)
                    {
                        foreach (var irs  in irsDetay)
                        {
                            foreach (var bil in tmpBildirimList)
                            {
                                if( irs.MALID == bil.MalinKodNo && irs.MALCINSID == bil.MalinCinsKodNo )
                                {
                                    irs.KUNYE = bil.KunyeNo;
                                    irs.BELGENO = item.BELGENO;
                                    /// Künye Bilgilerini Al ve Yaz
                                }
                            }
                        }
                    }
                    var eslesmeyenler = irsDetay.Where(s => s.KUNYE == 0).ToList();
                    if(eslesmeyenler.Count>0)
                    {
                        /// Esleşmeyen Ürün Var Demektir.
                    }

                }
            }
        }
    }
}