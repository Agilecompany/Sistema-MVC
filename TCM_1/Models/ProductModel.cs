using ProjetoTCM.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCM_1.Models
{
    public class ProductModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public decimal UnitPrice { get; set; }

        public string ExternalCode { get; set; }


        public ProductDomain ConvertToDomain()
        {
            var domain = new ProductDomain();
            domain.Name = this.Name;
            domain.Description = this.Description;
            domain.Brand = this.Brand;
            domain.Model = this.Model;
            domain.UnitPrice = this.UnitPrice;
            domain.ExternalCode = this.ExternalCode;

            return domain;
        }

    }
}