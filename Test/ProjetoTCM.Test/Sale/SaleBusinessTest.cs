using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTCM.Business.General;
using ProjetoTCM.Business.Sale;
using ProjetoTCM.Business.Security;
using ProjetoTCM.Domain.Enum;
using ProjetoTCM.Domain.General;
using ProjetoTCM.Domain.Sale;
using ProjetoTCM.Domain.Security;
using ProjetoTCM.Infrastructure.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProjetoTCM.Test.Sale
{
    [TestClass]
    public class SaleBusinessTest
    {
        [TestMethod]
        [TestCategory("SaleBusiness_Save")]
        public void SaleBusiness_Save_New()
        {
          using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                SaleDomain sale = new SaleDomain();
                SaleBusiness business = new SaleBusiness();
                MountSale(ref sale);

                var result = business.Save(sale);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

            }
        }

        private void MountSale(ref SaleDomain sale)
        {
            var salesman = new SalesmanDomain() { Email = "teste@gmail.", Name = "Sr Teste", Address = "rua 2", CPF = "35.659.698.510", Phone = "2944-3956" };
            new SalesmanBusiness().Save(salesman);

            var client = new ClientDomain() { Email = "teste@gmail", Name = "Sr Teste", CPF = "325.459.678.20", Phone = "2944-3956" };
            new ClientBusiness().Save(client);

            var user = new UserDomain() { Login = "tes", Password = "123456", Email = "teste@gmail.c", Name = "Sr Teste", Profile = EnumProfile.Cashier };
            new UserBusiness().Save(user);

            var product = new ProductDomain() { ExternalCode = "20195655", Name = "camisa do brasil", Description = "tenis", Model = "calca" };
            new ProductBusiness().Save(product);

            sale = new SaleDomain() { Payment = EnumPayment.Credito, Date = new DateTime(2019, 5, 12), SalesmanID = salesman.ID, ClientID = client.ID, UserID = user.ID, ClientName = client.Name, ClientCPF = client.CPF, SalesmanName = salesman.Name };
            sale.SaleProducts.Add(new SaleProductDomain() { ProductID = product.ID, Quantity = 2, UnitPrice = 39.00m, ProductName = product.Name, ExternalCode = product.ExternalCode });
        }

        [TestMethod]
        [TestCategory("SaleBusiness_GetByID")]
        public void SaleBusiness_GetByID_WhenDoesntExistSale()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {

                var business = new SaleBusiness();
                var result = business.GetByID(5000);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("SaleBusiness_GetAll")]
        public void SaleBusiness_GetAll_WhenExistUsers()
        {
            var business = new SaleBusiness();

            var Sale = business.GetAll();
        }

        [TestMethod]
        [TestCategory("SaleBusiness_Delete")]
        public void SaleBusiness_Delete()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                SaleDomain sale = new SaleDomain();
                SaleBusiness business = new SaleBusiness();
                MountSale(ref sale);

                business.Save(sale);

                var result = business.Delete(sale.ID);

                Assert.AreEqual(EnumReply.Success, result.Reply);

                var resultConsult = business.GetByID(sale.ID);
                Assert.AreEqual(null, resultConsult.Entity);
            }
        }
    }
}
