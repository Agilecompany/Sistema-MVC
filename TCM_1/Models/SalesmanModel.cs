using ProjetoTCM.Domain.Enum;
using ProjetoTCM.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCM_1.Models
{
    public class SalesmanModel
    {

        public long ID { get; set; }

        public string Name { get; set; }

        public string CPF { get; set; }

        public EnumSex Sex { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public bool Excluded { get; set; }


        public SalesmanDomain ConvertToDomain()
        {
            var domain = new SalesmanDomain();
            domain.ID = this.ID;
            domain.Name = this.Name;
            domain.CPF = this.CPF;
            domain.Sex = this.Sex;
            domain.Email = this.Email;
            domain.Phone = this.Phone;
            domain.Address = this.Address;

            return domain;
        }
    }
}