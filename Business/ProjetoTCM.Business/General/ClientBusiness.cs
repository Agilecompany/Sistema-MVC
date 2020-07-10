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
    public class ClientBusiness

    {
        public ObjectReply<ClientDomain> Save(ClientDomain client)
        {

            var result = new ObjectReply<ClientDomain>();
            try
            {
                if (string.IsNullOrWhiteSpace(client.CPF))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Client_CPF_Required;
                    return result;
                }

                if (string.IsNullOrWhiteSpace(client.Name))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Client_Name_Required;
                    return result;
                }

                var currentClients = this.GetAll().Entity;
                if (currentClients.Exists(x => x.CPF == client.CPF && x.ID != client.ID))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Client_CPF_Duplicate;
                    return result;
                }

                if (currentClients.Exists(x => x.Email == client.Email && x.ID != client.ID))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Client_Email_Duplicate;
                    return result;
                }

                result.Entity = new ClientData().Save(client);
            }
            catch (Exception ex)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }

            return result;
        }

        public ObjectReply<ClientDomain> GetByID(long id)
        {
            var result = new ObjectReply<ClientDomain>();
            try
            {
                result.Entity = new ClientDomain();
                result.Entity = new ClientData().GetByID(id);
            }
            catch (Exception)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }
            return result;
        }
        public ObjectReply<List<ClientDomain>> GetAll()
        {
            var result = new ObjectReply<List<ClientDomain>>();
            try
            {
                result.Entity = new ClientData().GetAll();
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
                var deleteResult = new ClientData().Delete(id);
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
