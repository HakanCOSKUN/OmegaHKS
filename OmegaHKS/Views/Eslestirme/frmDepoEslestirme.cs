using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using OmegaHKS.GenelServiceReference;
using NLog;
using System.Reflection;
using System.Text;

namespace OmegaHKS.Views.Eslestirme
{
    public partial class frmDepoEslestirme : BaseForm
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        //private bool islem = false;
        private Guid PidID;

        public frmDepoEslestirme()
        {
            InitializeComponent();

            InitDTGDoldur();

            //islem = true;
            PidID = Guid.NewGuid();
        }

        private void InitDTGDoldur()
        {

            try
            {
                IList<DepoDTO> depoDTOList = null;
                depoDTOList = GetDepoDTO();

                IList<Models.LocalDepo> localDepoList = null;
                localDepoList = GetLocalDepoList();

                var localDepoDTOList = new List<Models.LocalDepoDTO>();
                bool kontrol = false;


                foreach (var dDTO in depoDTOList)
                {
                    var beldeAdi = GetLocalBelde(dDTO.IlId, dDTO.IlceId, dDTO.BeldeId).BeldeAdi;
                    var ilceAdi = GetLocalIlce(dDTO.IlId, dDTO.IlceId).IlceAdi;
                    var ilAdi = GetLocalIl(dDTO.IlId).IlAdi;

                    if (string.IsNullOrEmpty(beldeAdi) && !kontrol)
                    {
                        kontrol = true;
                        Helpers.MessageHelper.ShowError("Lokasyon Bilgileri Güncelleme Yapılması Gerekiyor Bilgiler Eksik!!!");
                        //this.Close();
                    }

                    var tmp = new Models.LocalDepoDTO
                    {
                        Id = dDTO.Id,
                        DepoAdi = dDTO.DepoAdi,
                        Adres = dDTO.Adres,
                        BeldeId = dDTO.BeldeId,
                        BeldeAdi = beldeAdi,
                        IlceId = dDTO.IlceId,
                        IlceAdi = ilceAdi,
                        IlId = dDTO.IlId,
                        IlAdi = ilAdi,
                        Halicimi = dDTO.Halicimi
                    };

                    if(localDepoList.Count>0)
                    {
                        foreach (var ls in localDepoList)
                        {
                            if (ls.HKSID == dDTO.Id)
                            {
                                tmp.DMBNO = ls.DMBNO;
                            }
                        }
                    }
                    localDepoDTOList.Add(tmp);
                }
                dgcLocalDepoDTO.DataSource = localDepoDTOList;
            }
            catch (Exception e)
            {
                var errorMessage = string.Format("Hata Yeri : {0}\nHata Bilgisi: {1}", e.StackTrace, e.Message);
                var islemLog = string.Format("Web Servisten Veri Okurken Hata Oluştu", MethodBase.GetCurrentMethod().DeclaringType);
                logger.Error(islemLog);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog + "  " + errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog + "  " + errorMessage });
                Helpers.MessageHelper.ShowError(errorMessage);
            }
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

        private IList<Models.LocalDepo> GetLocalDepoList()
        {
            IList<Models.LocalDepo> result = null;
            var localDepoController = new Controllers.LocalDepoDTOController();
            result = localDepoController.GetLocalDepoList(Models.DepoSubeAramaTipi.Depo);
            return result;
        }


        private List<DepoDTO> GetDepoDTO()
        {
            if (!Helpers.GenerelHelper.IsConnected())
            {
                Helpers.MessageHelper.ShowInformation("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!");
                return null;
            }
            var result = new List<DepoDTO>();
            try
            {
                using (var proxy = new GenelServiceReference.GenelServiceClient())
                {
                    var istek = new GenelServiceReference.BaseRequestMessageOf_DepolarIstek()
                    {
                        UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                        Password = Core.StaticDegiskenler.webServiceUser.Password,
                        ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                        Istek = new GenelServiceReference.DepolarIstek() { TcKimlikVergiNo = Core.StaticDegiskenler.webServiceUser.UserName }
                    };

                    logger.Info("HKS Web Service Okuma Başladı");
                    var cevap = proxy.GenelServisDepolar(istek);
                    
                    // result = cevap.Sonuc.Depolar;

                    if (cevap.HataKodlari !=null && cevap.HataKodlari.Count > 0)
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
                        result = cevap.Sonuc.Depolar;
                    }
                }
            }
            catch (Exception e)
            {
                var errorMessage = string.Format("Hata Yeri : {0}\nHata Bilgisi: {1}", e.StackTrace, e.Message);
                var islemLog = string.Format("Web Servisten Veri Okurken Hata Oluştu", MethodBase.GetCurrentMethod().DeclaringType);
                logger.Error(islemLog);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog  + "  " + errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog + "  " + errorMessage });

                Helpers.MessageHelper.ShowError(errorMessage);
            }
            return result;
        }

        private void btnEditDepoListesi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var btnEdit = sender as ButtonEdit;
            var key = btnEdit.Text;

            var localNo = String.IsNullOrEmpty(key) ? -1 : Convert.ToInt16(key);
            Core.StaticDegiskenler.FormInt = -1;
            Core.StaticDegiskenler.tmpLocalDepo = null;

            Helpers.DepoSubeIslemleri.DepoSubeSecim(true, localNo, Models.DepoSubeAramaTipi.Depo);
            if (Core.StaticDegiskenler.tmpLocalDepo != null)
            {
                dgvLocalDepoDTO.ActiveEditor.EditValue = Core.StaticDegiskenler.tmpLocalDepo.DMBNO;
            }
        }

        private void ucsBTNGuncelle1_ClickKapat(object sender, EventArgs e)
        {
            Close();
        }

        private void ucsBTNGuncelle1_ClickGuncelle(object sender, EventArgs e)
        {
            var depoLis = new List<Models.LocalDepoDTO>();
            depoLis = dgvLocalDepoDTO.GridControl.DataSource as List<Models.LocalDepoDTO>;

            var localDepoController = new Controllers.LocalDepoDTOController();
            var sonuc =  localDepoController.LocalDepoDTOEkleGuncelle(depoLis);
            if (sonuc)
            {
                var islemLog = string.Format("Depo Eşleştirmesi Değiştirildi Yada Yeni Yapıldı", MethodBase.GetCurrentMethod().DeclaringType);
                logger.Info(islemLog);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = islemLog });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = islemLog });
                Helpers.MessageHelper.ShowInformation("Depo Eşleştirmeleri Güncellendi veya Eklendi ..!");
            }
            else
            {
                var islemLog = string.Format("Depo Eşleştirmesi Yapılırken Hata Oluştu", MethodBase.GetCurrentMethod().DeclaringType);
                logger.Error(islemLog);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog });

                Helpers.MessageHelper.ShowError("İşelem Başarısız Oldu");
            }
        }
    }
}
