using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using OmegaHKS.UrunServiceReference;
using NLog;
using System.Reflection;

namespace OmegaHKS.Views.Eslestirme
{
    public partial class frmUrunEslestirmeleri : BaseForm
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        private bool islem = false;
        private Guid PidID;
        public frmUrunEslestirmeleri()
        {
            InitializeComponent();

            InitOracleService();
            InitDTGDoldur();

            islem = true;
            PidID = Guid.NewGuid();
        }

        private void InitOracleService()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("Sisteminden Veriler Okunuyor...");

            Core.StaticDegiskenler.tmpLocalUrunDTOList = null;
            bsUrunDTO.DataSource = GetUrunDTOList();
            bsLocalUrunCinsiDTO.DataSource = GetDefaultLocalUrunCinsiDTO();
            bsLocalUrunDTO.DataSource = GetDefaultLocalUrunDTO();

            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }
        private void InitDTGDoldur()
        {
            dgcUrunDTO.DataSource = bsUrunDTO;
            dgcLocalUrunCinsiDTO.DataSource = bsLocalUrunCinsiDTO;

            dgcLocalUrunDTO.DataSource = bsLocalUrunDTO;
            dgvLocalUrunDTO.SecimColumnGoster();
        }
        private void rsiBtnOmegaStokAra_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var btnEdit = sender as ButtonEdit;
            var key = btnEdit.Text;
            var secilen = dgvLocalUrunCinsiDTO.GetFocusedItem<Models.LocalUrunCinsiDTO>();
            Core.StaticDegiskenler.tmpLocalUrunDTOList = null;
            var sonuc = Helpers.Urunler.StokAramaYap(true, null, String.IsNullOrEmpty(key) ? null : key);

            if (sonuc == -1)
            {
                return;
            }
            if (Core.StaticDegiskenler.tmpLocalUrunDTOList.Count > 0)
            {
                foreach (var item in Core.StaticDegiskenler.tmpLocalUrunDTOList)
                {
                    item.UrunCinsiId = secilen.Id;
                    item.UrunId = secilen.UrunId;
                    item.UrunKodu = secilen.UrunKodu;
                    item.UretimSekilId = secilen.UretimSekilId;
                    item.Ithalmi = secilen.Ithalmi.ToString();
                }
                bsLocalUrunDTO.DataSource = Core.StaticDegiskenler.tmpLocalUrunDTOList;
                var stkController = new Controllers.UrunControllers();
                stkController.StokUrunCinsEsleme(Core.StaticDegiskenler.tmpLocalUrunDTOList);
            }
            dgvLocalUrunCinsiDTO.ActiveEditor.EditValue = string.Empty;
        }
        private IList<UrunDTO> GetUrunDTOList()
        {
            IList<UrunDTO> result = new List<UrunDTO>();
            var urunController = new Controllers.UrunControllers();
            result = urunController.GetUrunDTOList();
            return result;
        }

        private List<Models.LocalUrunDTO> GetDefaultLocalUrunDTO()
        {
            return new List<Models.LocalUrunDTO>() { new Models.LocalUrunDTO() {  UrunId = 0,  STOKAD = "Seçiniz" } };
        }
        private List<Models.LocalUrunCinsiDTO> GetDefaultLocalUrunCinsiDTO()
        {
            return new List<Models.LocalUrunCinsiDTO>() { new Models.LocalUrunCinsiDTO() { Id = 0, UrunCinsiAdi = "Seçiniz" } };
        }

        private IList<Models.LocalUrunCinsiDTO> GetLocalUrunCinsiDTOList(int urunId)
        {
            IList<Models.LocalUrunCinsiDTO> result = new List<Models.LocalUrunCinsiDTO>();
            var stkController = new Controllers.UrunControllers();
            result = stkController.GetLocalUrunCinsiDTOList(urunId);
            return result;
        }

        private void dgvUrunDTO_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dgvUrunDTO.FocusedRowHandle >= 0 && islem)
            {
                var secilen = dgvUrunDTO.GetFocusedItem<UrunDTO>();
                if (secilen.Id == 0)
                {
                    bsLocalUrunCinsiDTO.DataSource = GetDefaultLocalUrunCinsiDTO();
                }
                else
                {
                    bsLocalUrunCinsiDTO.DataSource = GetLocalUrunCinsiDTOList(secilen.Id);
                }
                dgcLocalUrunCinsiDTO.DataSource = bsLocalUrunCinsiDTO;
            }
        }

        private void dgvLocalUrunCinsiDTO_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dgvLocalUrunCinsiDTO.FocusedRowHandle >= 0 && islem)
            {
                Core.StaticDegiskenler.tmpLocalUrunDTOList = null;
                var secilen = dgvLocalUrunCinsiDTO.GetFocusedItem<Models.LocalUrunCinsiDTO>();
                IList<Models.LocalUrunDTO> eslenStokListesi = null;
                var urunController = new Controllers.UrunControllers();

                if (secilen.Id == 0)
                {
                    bsLocalUrunDTO.DataSource = GetDefaultLocalUrunDTO();
                }
                else
                {
                    eslenStokListesi = urunController.GetUrunDTOEslesnler(secilen.UrunId, secilen.Id);
                    bsLocalUrunDTO.DataSource = eslenStokListesi;
                }
                dgcLocalUrunDTO.DataSource = bsLocalUrunDTO;
            }
        }

        private void dgvLocalUrunCinsiDTO_DataSourceChanged(object sender, EventArgs e)
        {
            bsLocalUrunDTO.DataSource = GetDefaultLocalUrunDTO();
        }

        private void dgvLocalUrunDTO_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvLocalUrunDTO.RowCount > 0)
            {
                dgcLocalUrunDTO.ContextMenuStrip = contextMenuStripdgcLocalUrunDTO;
            }
        }

        private void seciliUrunleriEslestirmedenKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenLocalStokList = dgvLocalUrunDTO.GetSelectedItems<Models.LocalUrunDTO>();
            if (secilenLocalStokList.Count > 0)
            {
                var urunController = new Controllers.UrunControllers();
                var sonuc = urunController.DelLocalUrunDTO_Eslesenler(secilenLocalStokList);
                if (sonuc)
                {
                    Helpers.MessageHelper.ShowInformation("İşlem Başarı İle Tamamlanmıştır.");
                    var secilen = dgvLocalUrunCinsiDTO.GetFocusedItem<Models.LocalUrunCinsiDTO>();
                    IList<Models.LocalUrunDTO> eslenStokListesi = null;
                    eslenStokListesi = urunController.GetUrunDTOEslesnler(secilen.UrunId, secilen.Id);
                    bsLocalUrunDTO.DataSource = eslenStokListesi;
                    dgcLocalUrunDTO.DataSource = bsLocalUrunDTO;

                    var islemLog = string.Format("Ürün Eşleştirmesi Yapıldı Yada Güncellendi", MethodBase.GetCurrentMethod().DeclaringType);
                    logger.Info(islemLog);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = islemLog });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = islemLog });


                }
                else
                {
                    var islemLog = string.Format("Ürün Eşleştirmesi Yapılırken Hata Oluştu", MethodBase.GetCurrentMethod().DeclaringType);
                    logger.Error(islemLog);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog  });

                    Helpers.MessageHelper.ShowError("Silme İşlemi Yapılamadı... Daha Sonra Deeneyin...");
                }
            }
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            Close();
        }
    }
}
