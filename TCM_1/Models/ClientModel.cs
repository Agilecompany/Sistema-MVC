using ProjetoTCM.Domain.Enum;
using ProjetoTCM.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCM_1.Models
{
    public class ClientModel
    {

        public long ID { get; set; }

        public string Name { get; set; }

        public string CPF { get; set; }

        public EnumSex Sex { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string CellPhone { get; set; }


        public ClientDomain ConvertToDomain()
        {
            var domain = new ClientDomain();
            domain.ID = this.ID;
            domain.Name = this.Name;
            domain.CPF = this.CPF;
            domain.Sex = this.Sex;
            domain.Email = this.Email;
            domain.Phone = this.Phone;
            domain.CellPhone = this.CellPhone;

            return domain;
        }


    }
}