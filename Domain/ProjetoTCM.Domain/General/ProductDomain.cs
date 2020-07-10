using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Domain.General
{
    public class ProductDomain
    {
        public long ID { get; set; }

        public string ExternalCode { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public decimal UnitPrice { get; set; }
        public bool Excluded { get; set; }

        public string ExternalCodeName { get { return string.Concat(this.ExternalCode, " - ", this.Name); } }


    }
}
