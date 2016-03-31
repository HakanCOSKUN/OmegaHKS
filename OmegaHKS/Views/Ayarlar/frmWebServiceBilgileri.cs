using System;
using System.Collections.Generic;
using System.Linq;
using NLog;

namespace OmegaHKS.Views.Ayarlar
{
    public partial class frmWebServiceBilgileri : BaseForm
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public frmWebServiceBilgileri()
        {
            InitializeComponent();
            WebUserBilgileriYaz();
        }

        private void WebUserBilgileriYaz()
        {
            txtWebUserName.Text = Core.StaticDegiskenler.webServiceUser.UserName;
            txtWebUserPassword.Text = Core.StaticDegiskenler.webServiceUser.Password;
            txtWebServicePassword.Text = Core.StaticDegiskenler.webServiceUser.ServicePasssword;
        }

        private void ucsBTNKayitIpal1_ClickKaydet(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty( txtWebServicePassword.Text ) && !String.IsNullOrEmpty( txtWebUserName.Text ) && !String.IsNullOrEmpty(txtWebUserPassword.Text))
            {
                var updateController = new Controllers.LocalHKSUpdateController();
                var user = new Models.ServiceUser() { UserName = txtWebUserName.Text, Password = txtWebUserPassword.Text, ServicePasssword = txtWebServicePassword.Text };
                var sonuc = updateController.WebServiceUserUpdate(user);
                if (sonuc)
                {
                    Helpers.MessageHelper.ShowInformation("İşlem Başarı ile Gerçekleştirildi.");
                    var hata = string.Format("Web Service Kullanıcı Ayarları Değiştirildi");
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                    logger.Info(hata);

                    hata = string.Format("Web Service User :{0}", user.UserName);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                    logger.Info(hata);

                    hata = string.Format("Web Service User Şifre :{0}", user.Password);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                    logger.Info(hata);

                    hata = string.Format("Web Service Services Password :{0}", user.ServicePasssword);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = hata });
                    logger.Info(hata);

                    Core.StaticDegiskenler.webServiceUser.UserName = user.UserName;
                    Core.StaticDegiskenler.webServiceUser.Password = user.Password;
                    Core.StaticDegiskenler.webServiceUser.ServicePasssword = user.ServicePasssword;


                    var conWebSer = new Controllers.WebServiceTool();
                    var webUser = conWebSer.GetWebServiceUser();
                }
                else
                {
                    Helpers.MessageHelper.ShowError("İşelm Başarısız Oldu. Log Kayıtlarını Yazılımcı ile Paylaşın..");
                    var hata = string.Format("Web Service Kullanıcı Ayarları Değiştirken Hata Oluştu");
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = hata });
                    logger.Info(hata);
                }
            }
            else
            {
                Helpers.MessageHelper.ShowError("İlgili Alanları Doldurmanız Gerekir..!");
            }
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            Close();
        }

        private void checkEditSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtWebServicePassword.Properties.UseSystemPasswordChar = !checkEditSifreGoster.Checked;
            txtWebUserPassword.Properties.UseSystemPasswordChar = !checkEditSifreGoster.Checked;
        }

        private void btnYekiVer_Click(object sender, EventArgs e)
        {
            string Sifre = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            var Yetki = txtErisimSifresi.Text;
            if(Yetki == Sifre)
            {
                groupControl1.Enabled = !groupControl1.Enabled;
            }
        }
    }
}
