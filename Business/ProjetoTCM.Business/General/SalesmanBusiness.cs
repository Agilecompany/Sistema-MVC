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
   public class SalesmanBusiness
    {
        public ObjectReply<SalesmanDomain> Save(SalesmanDomain salesman)
        {

            var result = new ObjectReply<SalesmanDomain>();
            try
            {
                if (string.IsNullOrWhiteSpace(salesman.CPF))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Salesman_CPF_Required;
                    return result;
                }

                if (string.IsNullOrWhiteSpace(salesman.Name))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Salesman_Name_Required;
                    return result;
                }
                if (string.IsNullOrWhiteSpace(salesman.Address))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Salesman_Address_Required;
                    return result;
                }
                if (string.IsNullOrWhiteSpace(salesman.Email))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Salesman_Email_Required;
                    return result;
                }
                if (string.IsNullOrWhiteSpace(salesman.Phone))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Salesman_Phone_Required;
                    return result;
                }


                var currentSalesmen = this.GetAll().Entity;
                if (currentSalesmen.Exists(x => x.CPF == salesman.CPF && x.ID != salesman.ID))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Salesman_CPF_Duplicate;
                    return result;
                }

                if (currentSalesmen.Exists(x => x.Email == salesman.Email && x.ID != salesman.ID))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Salesman_Email_Duplicate;
                    return result;
                }


                result.Entity = new SalesmanData().Save(salesman);
            }
            catch (Exception ex)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }

            return result;
        }

        public ObjectReply<SalesmanDomain> GetByID(long id)
        {
            var result = new ObjectReply<SalesmanDomain>();
            try
            {
                result.Entity = new SalesmanDomain();
                result.Entity = new SalesmanData().GetByID(id);
            }
            catch (Exception ex)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }
            return result;
        }

        public ObjectReply<List<SalesmanDomain>> GetAll()
        {
            var result = new ObjectReply<List<SalesmanDomain>>();
            try
            {
                result.Entity = new SalesmanData().GetAll();
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
                var deleteResult = new SalesmanData().Delete(id);
                if (!deleteResult)
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.User_Delete_Error_ID;
                }
            }
            catch (Exception ex)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }

            return result;
        }
    }
}
