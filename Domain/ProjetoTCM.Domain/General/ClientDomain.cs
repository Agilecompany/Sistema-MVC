using ProjetoTCM.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Domain.General
{
    public class ClientDomain
    {
        public long ID { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public string CPF { get; set; } = string.Empty;

        public EnumSex Sex { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string CellPhone { get; set; } = string.Empty;

        public bool Excluded { get; set; }

    }
}
