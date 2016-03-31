using OmegaHKS.BildirimServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OmegaHKS.Models
{
    class BildirimSorguDTOLocal : BildirimSorguDTO
    {
        public bool SECIM { get; set; }
        public double SEVKMIKTARI { get; set; }

    }
}
