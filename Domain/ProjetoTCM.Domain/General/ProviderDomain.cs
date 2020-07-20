using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Domain.General
{
    public class ProviderDomain
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string CNPJ { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

    }
}
