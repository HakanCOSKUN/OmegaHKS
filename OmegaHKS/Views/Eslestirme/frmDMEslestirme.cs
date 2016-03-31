using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OmegaHKS.GenelServiceReference;
using NLog;
using System.Reflection;

namespace OmegaHKS.Views.Eslestirme
{
    public partial class frmDMEslestirme : BaseForm
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        //private bool islem = false;
        private Guid PidID;

        public frmDMEslestirme()
        {
            InitializeComponent();
            InitDTGDoldur();

            PidID = Guid.NewGuid();
        }

        private void InitDTGDoldur()
        {
            IList<SubeDTO> subeDTOList = null;
            subeDTOList = GetSubeDTO();

            IList<Models.LocalSube> localSubeList = null;
            localSubeList = GetLocalSubeList();

            subeDTOList = subeDTOList.Where(s => s.IsyeriTuru == 12).ToList();

            var localSubeDTOList = new List<Models.LocalSubeDTO>();

            bool kontrol = false;

            foreach (var dDTO in subeDTOList)
            {
                var beldeAdi = GetLocalBelde(dDTO.IlId, dDTO.IlceId, dDTO.BeldeId).BeldeAdi;
                var ilceAdi = GetLocalIlce(dDTO.IlId, dDTO.IlceId).IlceAdi;
                var ilAdi = GetLocalIl(dDTO.IlId).IlAdi;
                var islemteTuruAdi = GetLocalIsletmeTuru(dDTO.IsyeriTuru).IsletmeTuruAdi;

                if (string.IsNullOrEmpty(beldeAdi) && !kontrol)
                {
                    kontrol = true;
                    Helpers.MessageHelper.ShowError("Lokasyon Bilgileri Güncelleme Yapılması Gerekiyor Bilgiler Eksik!!!");
                    //this.Close();
                }


                if (string.IsNullOrEmpty(islemteTuruAdi) && !kontrol)
                {

                    kontrol = true;
                    Helpers.MessageHelper.ShowError("Bildirim Yardımcı Bilgileri Güncelleme Yapılması Gerekiyor Bilgiler Eksik!!!");
                }

                var tmp = new Models.LocalSubeDTO
                {
                    Id = dDTO.Id,
                    SubeAdi = dDTO.SubeAdi,
                    Adres = dDTO.Adres,
                    BeldeId = dDTO.BeldeId,
                    BeldeAdi = beldeAdi,
                    IlceId = dDTO.IlceId,
                    IlceAdi = ilceAdi,
                    IlId = dDTO.IlId,
                    IlAdi = ilAdi,
                    IsletmeTuruAdi = islemteTuruAdi,
                    IsyeriTuruId = dDTO.IsyeriTuru
                };

                if (localSubeList.Count > 0)
                {
                    foreach (var ls in localSubeList)
                    {

                        if (ls.HKSID == dDTO.Id)
                        {
                            tmp.DMBNO = ls.DMBNO;
                            tmp.DMBNOKONTROL = ls.DMBNOKONTROL;
                        }
                    }
                }
                localSubeDTOList.Add(tmp);
            }

            dgcLocalSubeDTO.DataSource = localSubeDTOList;
        }

        private IsletmeTuruDTO GetLocalIsletmeTuru(int isletmeTurId)
        {
            IsletmeTuruDTO result = null;
            var localDepoController = new Controllers.LocalDepoDTOController();
            result = localDepoController.GetLocalIsletmeTuru(isletmeTurId);
            return result;
        }

        private IList<SubeDTO> GetSubeDTO()
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
                    logger.Error("HKS Web Service Okumaya Başla");
                    var cevap = proxy.GenelServisSubeler(istek);
                    // logger.Error("HKS Web Service Okuma Tamamlandı");
                    // result = cevap.Sonuc.Subeler;

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

        private IlDTO GetLocalIl(int id)
        {
            IlDTO result = null;
            var localDepoController = new Controllers.LocalDepoDTOController();
            result = localDepoController.GetLocall(id);
            return result;
        }

        private IlceDTO GetLocalIlce(int ilId, int IlceId)
        {
            IlceDTO result = null;
            var localDepoController = new Controllers.LocalDepoDTOController();
            result = localDepoController.GetLocalIce(ilId, IlceId);
            return result;
        }

        private BeldeDTO GetLocalBelde(int ilId, int IlceId, int beldeId)
        {
            BeldeDTO result = null;
            var localDepoController = new Controllers.LocalDepoDTOController();
            result = localDepoController.GetLocalBelde(ilId, IlceId, beldeId);
            return result;
        }

        private IList<Models.LocalSube> GetLocalSubeList()
        {
            IList<Models.LocalSube> result = null;

            var localDepoController = new Controllers.LocalDepoDTOController();
            logger.Info("Locak Şube Bilgilerini Oku Okumaya Başla");
            result = localDepoController.GetLocalSubeList(Models.DepoSubeAramaTipi.Genel);
            logger.Info("Locak Şube Bilgilerini Okuma Bitti");
            return result;
        }

        private void rsiBtnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var btnEdit = sender as ButtonEdit;
            var key = btnEdit.Text;

            var localNo = String.IsNullOrEmpty(key) ? -1 : Convert.ToInt16(key);
            Core.StaticDegiskenler.FormInt = -1;
            Core.StaticDegiskenler.tmpLocalDepo = null;

            Helpers.DepoSubeIslemleri.DepoSubeSecim(true, localNo, Models.DepoSubeAramaTipi.Genel);
            if (Core.StaticDegiskenler.tmpLocalDepo != null)
            {
                dgvLocalSubeDTO.ActiveEditor.EditValue = Core.StaticDegiskenler.tmpLocalDepo.DMBNO;
            }
        }

        private void ucsBTNGuncelle1_ClickKapat(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucsBTNGuncelle1_ClickGuncelle(object sender, EventArgs e)
        {
            var subeLis = new List<Models.LocalSubeDTO>();
            subeLis = dgvLocalSubeDTO.GridControl.DataSource as List<Models.LocalSubeDTO>;

            var localDepoController = new Controllers.LocalDepoDTOController();
            var sonuc = localDepoController.LocalSubeDTOEkleGuncelle(subeLis);
            if (sonuc)
            {
                var islemLog = string.Format("Şube Eşleştirmesi Değiştirildi Yada Yeni Yapıldı", MethodBase.GetCurrentMethod().DeclaringType);
                logger.Info(islemLog);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = islemLog });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = islemLog });
                Helpers.MessageHelper.ShowInformation("Şube Eşleştirmeleri Güncellendi veya Eklendi ..!");
            }
            else
            {
                var islemLog = string.Format("Şube Eşleştirmesi İşlemi Yapılırken Hata Alındı", MethodBase.GetCurrentMethod().DeclaringType);
                logger.Error(islemLog);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog });

                Helpers.MessageHelper.ShowError("İşelem Başarısız Oldu");
            }
        }
    }
}