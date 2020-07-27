using ProjetoTCM.Domain.Enum;
using ProjetoTCM.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCM_1.Models
{
    public class UserModel
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public EnumProfile Profile { get; set; }

        public bool Excluded { get; set; }


        public UserDomain ConvertToDomain()
        {
            var domain = new UserDomain();
            domain.ID = this.ID;
            domain.Name = this.Name;
            domain.Email = this.Email;
            domain.Login = this.Login;
            domain.Password = this.Password;
            domain.Profile = this.Profile;

            return domain;
        }
    }
}