using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Domain.Sale
{
    public class SaleProductDomain
    {
        public long SaleID { get; set; }

        public long ProductID { get; set; }

        public string ExternalCode { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }


        public decimal SubTotal { get { return UnitPrice * Quantity; } }
       
    }
}
