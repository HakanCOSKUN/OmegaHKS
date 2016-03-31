using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaHKS.Models
{
    public class AnlikIslem
    {
        public bool Islem { get; set; }
        public string IslemYabanBirim { get; set; }
        public Guid IslemPidId { get; set; }
    }
}
