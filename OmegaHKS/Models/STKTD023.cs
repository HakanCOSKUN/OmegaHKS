using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OmegaHKS.Models
{
    internal class STKTD023 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }


        }
        public DateTime TARIH { get; set; }
        public int DEPNO { get; set; }
        public string TIP { get; set; }
        public long IRSNO { get; set; }
        public int SIRANO { get; set; }
        public int ALDEP { get; set; }
        public long STKKOD { get; set; }
        public string STOKAD { get; set; }
        public string BARKOD { get; set; }
        public BrimTip BIRIMTIP { get; set; }
        public decimal BIRIMMIK { get; set; }
        public decimal TBIRIMMIK { get; set; }
        public decimal BRTFIAT { get; set; }
        public decimal NETFIAT { get; set; }
        public decimal KDV { get; set; }

    }
}
