using ProjetoTCM.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Domain.Sale
{
    public class SaleDomain
    {
        public long ID { get; set; }

        public EnumPayment Payment { get; set; }

        public DateTime Date { get; set; } = DateTime.MinValue;

        public long SalesmanID { get; set; } 

        public long ClientID { get; set; }

        public long UserID { get; set; }

        public bool Excluded { get; set; }

        public string ClientName { get; set; }

        public string ClientCPF { get; set; }

        public string SalesmanName { get; set; }

        public List<SaleProductDomain> SaleProducts { get; set; } = new List<SaleProductDomain>();
    }
}
