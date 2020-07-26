using ProjetoTCM.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCM_1.Models
{
    public class ProviderModel
    {

        public long ID { get; set; }

        public string Name { get; set; }

        public string CNPJ { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }


        public ProviderDomain ConvertToDomain()
        {
            var domain = new ProviderDomain();
            domain.ID = this.ID;
            domain.Name = this.Name;
            domain.CNPJ = this.CNPJ;
            domain.Address = this.Address;
            domain.Email = this.Email;

            return domain;
        }
    }
}