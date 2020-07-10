using ProjetoTCM.Data.Data.Security;
using ProjetoTCM.Domain.Security;
using ProjetoTCM.Infrastructure.Common;
using ProjetoTCM.Infrastructure.Common.Enum;
using ProjetoTCM.Infrastructure.Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Business.Security
{
    public class UserBusiness
    {
        public ObjectReply<UserDomain> Authentication(string login, string password)
        {
            var result = new ObjectReply<UserDomain>();
            result.Entity = new UserData().Authentication(login, password);

            if(result.Entity != null)
            {
                result.Message = MessageResource.User_Athentication_Welcome;
            }
            else
            {
                result.Message = MessageResource.User_Athentication_Invalid;
                result.Reply = EnumReply.BusinessError;
            }


            return result;
        }

        public ObjectReply<UserDomain> Save(UserDomain user)
        {
            var result = new ObjectReply<UserDomain>();
            try
            {
                if(string.IsNullOrWhiteSpace(user.Login))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.User_Login_Required;
                    return result;
                }

                if (string.IsNullOrWhiteSpace(user.Password))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.User_Password_Required;
                    return result;
                }

                if (string.IsNullOrWhiteSpace(user.Email))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.User_Email_Required;
                    return result;
                }

                if (string.IsNullOrWhiteSpace(user.Name))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.User_Name_Required;
                    return result;
                }

                var currentUsers = this.GetAll().Entity;
                if(currentUsers.Exists(x => x.Login == user.Login && x.ID != user.ID))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.User_Login_Duplicate;
                    return result;
                }

                if (currentUsers.Exists(x => x.Email == user.Email && x.ID != user.ID))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.User_Email_Duplicate;
                    return result;
                }

                result.Entity = new UserData().Save(user);
            }
            catch (Exception ex)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }

            return result;
        }

        public ObjectReply Delete(long id)
        {
            var result = new ObjectReply();
            try
            {
                var deleteResult = new UserData().Delete(id);
                if (!deleteResult)
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.User_Delete_Error_ID;
                }
            }
            catch (Exception)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }

            return result;
        }

        public ObjectReply<List<UserDomain>> GetAll()
        {
            var result = new ObjectReply<List<UserDomain>>();
            try
            {
                result.Entity = new UserData().GetAll();
            }
            catch (Exception)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }
            return result;
        }

        public ObjectReply<UserDomain> GetByID(long id)
        {
            var result = new ObjectReply<UserDomain>();
            try
            {
                result.Entity = new UserDomain();
                result.Entity = new UserData().GetByID(id);
            }
            catch (Exception)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }
            return result;
        }

    }
}
