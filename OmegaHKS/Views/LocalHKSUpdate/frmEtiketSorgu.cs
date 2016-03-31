using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NLog;

namespace OmegaHKS.Views.LocalHKSUpdate
{
    public partial class frmEtiketSorgu : BaseForm
    {
        private Models.DepoSubeAramaTipi Tip;
        Logger logger = LogManager.GetCurrentClassLogger();
        private List<OmegaHKS.BildirimServiceReference.BildirimEtiketDTO> etiketListesi = new List<BildirimServiceReference.BildirimEtiketDTO>();

        public frmEtiketSorgu()
        {
            InitializeComponent();
            InitDTGDoldur();
        }

        private void InitDTGDoldur()
        {
            var localDepoController = new Controllers.LocalDepoDTOController();
            var localList = localDepoController.GetLocalDepoList(Tip);
            bsLocalDepoSube.DataSource = localList;
            dgcDepoSubeListesi.DataSource = bsLocalDepoSube;
            dtTarih.EditValue = DateTime.Now;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var gidecekYer = dgvDepoSubeListesi.GetFocusedItem<Models.LocalDepo>();
            var belgeNo = txtBelgeNo.Text;

            BildirimServiceReference.BaseResponseMessageOf_BildirimEtiketCevap cevap = null;

            var istek = new BildirimServiceReference.BaseRequestMessageOf_BildirimEtiketIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new BildirimServiceReference.BildirimEtiketIstek()
                {
                    AracPlakaNo = gidecekYer.PLAKANO,
                    BelgeNo = belgeNo,
                    BildirimTarihi = Convert.ToDateTime(dtTarih.EditValue),
                    GidecekYerBeldeId = (int)gidecekYer.HKSBELDEID,
                    GidecekYerIlceId = (int)gidecekYer.HKSILCEID,
                    GidecekYerIlId = (int)gidecekYer.HKSILID,
                    MalinSahibiTcKimlikNo = Core.StaticDegiskenler.webServiceUser.UserName
                }
            };
            try
            {
                using (var proxy = new BildirimServiceReference.BildirimServiceClient())
                {
                    cevap = proxy.BildirimServisBildirimEtiket(istek);

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
                        // result = cevap.Sonuc.Subeler;
                    }
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

                    if (kunyeLis.Count > 0)
                    {
                        dgcEtiketListesi.DataSource = kunyeLis;
                        this.etiketListesi = kunyeLis;
                    }
                    else
                    {
                        Helpers.MessageHelper.ShowInformation("Kayıt Bulunamadı");
                    }

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

        }

        private void btnEtiketGuncelle_Click(object sender, EventArgs e)
        {
            var bController = new Controllers.BildirimController();
            if (bController.BildirimEtiketGuncelle(this.etiketListesi))
            {
                Helpers.MessageHelper.ShowError("Etiket Güncelleme İşlemi Hata Oluştu");
            }
            else
            {
                Helpers.MessageHelper.ShowInformation("İşlem Başarı İle Tamamlandı");
            }

        }
    }
}