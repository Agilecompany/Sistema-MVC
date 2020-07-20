using ProjetoTCM.Data.Data.Base;
using ProjetoTCM.Data.Data.General;
using ProjetoTCM.Domain.General;
using ProjetoTCM.Infrastructure.Common;
using ProjetoTCM.Infrastructure.Common.Enum;
using ProjetoTCM.Infrastructure.Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoTCM.Business.General
{
    public class ProviderBusiness
    {
        public ObjectReply<ProviderDomain> Save(ProviderDomain provider)
        {

            var result = new ObjectReply<ProviderDomain>();
            try
            {
                if (string.IsNullOrWhiteSpace(provider.Name))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Provider_CNPJ_Required;
                    return result;
                }

                if (string.IsNullOrWhiteSpace(provider.CNPJ))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Provider_Name_Required;
                    return result;
                }

                var currentProviders = this.GetAll().Entity;
                if (currentProviders.Exists(x => x.CNPJ == provider.CNPJ && x.ID != provider.ID))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Provider_CNPJ_Duplicate;
                    return result;
                }

                if (currentProviders.Exists(x => x.Email == provider.Email && x.ID != provider.ID))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Provider_Email_Duplicate;
                    return result;
                }

                result.Entity = new ProviderData().Save(provider);
            }
            catch (Exception ex)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }

            return result;
        }

        public ObjectReply<ProviderDomain> GetByID(long id)
        {
            var result = new ObjectReply<ProviderDomain>();
            try
            {
                result.Entity = new ProviderDomain();
                result.Entity = new ProviderData().GetByID(id);
            }
            catch (Exception)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }
            return result;
        }

        public ObjectReply<List<ProviderDomain>> GetAll()
        {
            var result = new ObjectReply<List<ProviderDomain>>();
            try
            {
                result.Entity = new ProviderData().GetAll();
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
                var deleteResult = new ProviderData().Delete(id);
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
    }
}
