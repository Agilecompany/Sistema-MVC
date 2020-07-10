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
    public class SaleBusiness
    {
        public ObjectReply<SaleDomain> Save(SaleDomain sale)
        {

            var result = new ObjectReply<SaleDomain>();
            try
            {

                if (sale.Date == DateTime.MinValue)
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Client_Date_Required;
                    return result;
                }
                if (sale.SalesmanID == 0)
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Client_SalesmanID_Required;
                    return result;
                }

                if (sale.ClientID == 0)
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.Client_ClientID_Required;
                    return result;
                }

                if (sale.SaleProducts.Count == 0)
                {
                    result.Reply = EnumReply.BusinessError;
                    result.Message = MessageResource.SaleProduct_Quantity_Required;
                    return result;
                }

                var saleProductBusiness = new SaleProductBusiness();
                result.Entity = new SaleData().Save(sale);
                foreach (var saleProduct in sale.SaleProducts)
                {
                    saleProduct.SaleID = sale.ID;
                    saleProductBusiness.Save(saleProduct);
                }

            }
            catch (Exception ex)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }

            return result;
        }

        public ObjectReply<SaleDomain> GetByID(long ID)
        {
            var result = new ObjectReply<SaleDomain>();
            try
            {
                result.Entity = new SaleDomain();
                result.Entity = new SaleData().GetByID(ID);
            }
            catch (Exception)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }
            return result;
        }

        public ObjectReply<List<SaleDomain>> GetAll()
        {
            var result = new ObjectReply<List<SaleDomain>>();
            try
            {
                result.Entity = new SaleData().GetAll();
            }
            catch (Exception ex)
            {
                result.Reply = EnumReply.SystemError;
                result.Message = MessageResource.SystemError;
            }
            return result;
        }

        public ObjectReply Delete(long ID)
        {
            var result = new ObjectReply();
            try
            {
                var deleteResult = new SaleData().Delete(ID);
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
