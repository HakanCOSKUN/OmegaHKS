using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OmegaHKS.Core
{
    public static class StaticDegiskenler
    {
        public static readonly string APP_VERSION = Application.ProductVersion;

        public static readonly string APP_NAME = string.Format("{0} v{1}", Application.ProductName, APP_VERSION);
        public static Models.ServiceUser webServiceUser { get; set; }
        public static Models.AnlikIslem AnlikIslem { get; set; }
        public static int FormInt { get; set; }
        public static Models.LocalDepoDTO tmpLocalDepoDTO { get; set; }
        public static Models.LocalDepo tmpLocalDepo { get; set; }
        public static Models.LocalUrunDTO tmpLocalUrunDTO { get; set; }
        public static List<Models.LocalUrunDTO> tmpLocalUrunDTOList { get; set; }
        public static Models.LocalSubeDepo tmpSubeDepo { get; set; }
        public static Models.Irsaliye tmpIrsaliye { get; set; }
        public static IList<Models.ErrorLog> HataListesi { get; set; }
        public static IList<Models.ErrorLog> IslemHataListesi { get; set; }
        public static IList<Models.ErrorLog> IslemInfoListesi { get; set; }
        public static bool Trial { get; set; }
        public static string AktifOracleUser { get; set; }
        public static Models.Cari tmpCari { get; set; }
        public static string CariKod { get; set; }
        public static IList<Models.IrsaliyeDetay> IslemYapilanIrsaliye { get; set; }
        public static int BildirimciSifatId { get; set; }
        public static int BildirimciIsletmeTuruId { get; set; }
        public static int GidecekYerSifatId { get; set; }
        public static int BidirimTuruId { get; set; }
        public static int GidecekYerIsletmeTuruId { get; set; }
        public static int BildirimBelgeTipiId { get; set; }

    }
}
