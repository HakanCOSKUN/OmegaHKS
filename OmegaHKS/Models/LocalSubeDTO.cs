using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaHKS.Models
{
    internal class LocalSubeDTO
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public int Id { get; set; }
        public string SubeAdi { get; set; }
        public string Adres { get; set; }
        public int BeldeId { get; set; }
        public int IlceId { get; set; }
        public int IlId { get; set; }
        public int IsyeriTuruId { get; set; }
        public string IsletmeTuruAdi { get; set; }

        private int? _DMBNO;
        public int? DMBNO
        {
            get
            {
                return _DMBNO;
            }
            set
            {
                if (value > 0)
                {
                    GetLocalDepo(value);
                }
                else
                {
                    LocalDepoAd = null;
                    LocalAdres = null;
                    LocalIlce = null;
                    LocalI = null;
                }

                _DMBNO = value;
            }
        }

        public int? DMBNOKONTROL { get; set; }
        public string BeldeAdi { get; set; }
        public string IlceAdi { get; set; }
        public string IlAdi { get; set; }
        public string LocalDepoAd { get; set; }
        public string LocalAdres { get; set; }
        public string LocalIlce { get; set; }
        public string LocalI { get; set; }

        private void GetLocalDepo(int? dpmno)
        {
            var localDepoController = new Controllers.LocalDepoDTOController();
            var result = new LocalDepo();

            logger.Error(" internal class LocalSubeDTO");

            result = localDepoController.GetLocalDepo(dpmno);
            if (result == null)
            {
                LocalDepoAd = null;
                LocalAdres = null;
                LocalIlce = null;
                LocalI = null;
            }
            else
            {
                LocalDepoAd = result.AD;
                LocalAdres = result.ADRES;
                LocalIlce = result.ILCE;
                LocalI = result.IL;
            }
        }

        public LocalSubeDTO()
        {
        }
    }
}
