using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaHKS.Models
{
    public class ErrorLog
    {
        public DateTime Tarih { set; get; }
        public string HataTipi { get; set; }
        public string HataBilgisi { get; set; }
        public bool HataVarYok { get; set; }
    }
}
