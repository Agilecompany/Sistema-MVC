using ProjetoTCM.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Domain.Security
{
    public class UserDomain
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public EnumProfile Profile { get; set; }

        public bool Excluded { get; set; }
    }
}
