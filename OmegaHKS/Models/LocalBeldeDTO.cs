using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaHKS.Models
{
    public class LocalBeldeDTO : OmegaHKS.GenelServiceReference.BeldeDTO
    {
       public int IlId { get; set; }
       public int IlceId { get; set; }
    }
}
