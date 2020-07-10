using ProjetoTCM.Data.Data.Sale;
using ProjetoTCM.Domain.Sale;
using ProjetoTCM.Infrastructure.Common;
using ProjetoTCM.Infrastructure.Common.Enum;
using ProjetoTCM.Infrastructure.Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Business.Sale
{
    public class SaleProductBusiness
    {
        public ObjectReply<SaleProductDomain> Save(SaleProductDomain saleProduct)
        {

            var result = new ObjectReply<SaleProductDomain>();
            try
            {
               
                if (saleProduct.Quantity ==0)
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.SaleProduct_Quantity_Required;
                    return result;
                }

                result.Entity = new saleProductData().Save(saleProduct);
            }
            catch (Exception ex)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }

            return result;
        }

        public ObjectReply<SaleProductDomain> GetByID(long ID)
        {
            var result = new ObjectReply<SaleProductDomain>();
            try
            {
                result.Entity = new saleProductData().GetByID(ID);
            }
            catch (Exception)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }
            return result;
        }

        public ObjectReply<List<SaleProductDomain>> GetAll()
        {
            var result = new ObjectReply<List<SaleProductDomain>>();
            try
            {
                result.Entity = new saleProductData().GetAll();
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
