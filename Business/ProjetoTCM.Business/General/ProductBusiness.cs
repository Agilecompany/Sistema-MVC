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
   public class ProductBusiness
    {
        public ObjectReply<ProductDomain> Save(ProductDomain product)
        {

            var result = new ObjectReply<ProductDomain>();
            try
            {
                if (string.IsNullOrWhiteSpace(product.ExternalCode))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Product_ExternalCode_Required;
                    return result;
                }

                if (string.IsNullOrWhiteSpace(product.Name))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.product_Name_Required;
                    return result;
                }

                var currentProducts = this.GetAll().Entity;
                if (currentProducts.Exists(x => x.ExternalCode == product.ExternalCode && x.ID != product.ID))
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Product_ExternalCode_Duplicate;
                    return result;
                }

                result.Entity = new ProductData().Save(product);
            }
            catch (Exception ex)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }

            return result;
        }

        public ObjectReply<ProductDomain> GetByID(long id)
        {
            var result = new ObjectReply<ProductDomain>();
            try
            {
                result.Entity = new ProductDomain();
                result.Entity = new ProductData().GetByID(id);
            }
            catch (Exception)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }
            return result;
        }


        public ObjectReply<List<ProductDomain>> GetAll()
        {
            var result = new ObjectReply<List<ProductDomain>>();
            try
            {
                result.Entity = new ProductData().GetAll();
            }
            catch (Exception)
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
                var deleteResult = new ProductData().Delete(id);
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
