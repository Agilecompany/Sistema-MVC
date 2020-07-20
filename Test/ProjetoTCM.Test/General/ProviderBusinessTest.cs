using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTCM.Business.General;
using ProjetoTCM.Domain.General;
using ProjetoTCM.Infrastructure.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProjetoTCM.Test.General
{
    [TestClass]
     public  class ProviderBusinessTest
    {
        [TestMethod]
        [TestCategory("ProvaderBusiness_Save")]
        public void ProviderBusiness_Save_New()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var provider = new ProviderDomain() {Name = "Distribuidaora", CNPJ = "65986598", Address = "rua 2", Email = "Teste@gmail.com" };
                var business = new ProviderBusiness();

                var result = business.Save(provider);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

            }
        }

        [TestMethod]
        [TestCategory("ProviderBusiness_Save")]
        public void ProviderBusiness_Save_New_DuplicateCNPJ()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var provider = new ProviderDomain() { Name = "Distribuidaora", CNPJ = "65986598", Address = "rua 2", Email = "Teste@gmail.com" };
                var business = new ProviderBusiness();

                var result = business.Save(provider);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var providerDuplicate = new ProviderDomain() { Name = "Distribuidaora", CNPJ = "65986598", Address = "rua 2", Email = "Teste@gmail.com" };
                var resultDuplicate = business.Save(providerDuplicate);

                Assert.AreEqual(EnumReply.BusinessError, resultDuplicate.Reply);
                Assert.IsNull(resultDuplicate.Entity);

            }
        }


        [TestMethod]
        [TestCategory("ProviderBusiness_Save")]
        public void ProviderBusiness_Save_New_DuplicateEmail()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var provider = new ProviderDomain() {Name = "Distribuidaora", CNPJ = "65986598", Address = "rua 2", Email = "Teste@gmail.com" };
                var business = new ProviderBusiness();

                var result = business.Save(provider);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var providerDuplicate = new ProviderDomain() { Name = "Distribuidaora", CNPJ = "65986598", Address = "rua 2", Email = "Teste@gmail.com" };
                var resultDuplicate = business.Save(providerDuplicate);

                Assert.AreEqual(EnumReply.BusinessError, resultDuplicate.Reply);
                Assert.IsNull(resultDuplicate.Entity);

            }
        }

        [TestMethod]
        [TestCategory("ProviderBusiness_GetByID")]
        public void ProviderBusiness_GetByID_WhenDoesntExistProvider()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {

                var business = new ProviderBusiness();
                var result = business.GetByID(5000);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }


        [TestMethod]
        [TestCategory("ProviderBusiness_GetByID")]
        public void ProviderBusiness_GetByID_WhenExistProvider()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var provider = new ProviderDomain() {Name = "Distribuidaora", CNPJ = "65986598", Address = "rua 2", Email = "Teste@gmail.com" };
                var business = new ProviderBusiness();

                business.Save(provider);

                var result = business.GetByID(provider.ID);


                Assert.IsNotNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("providerBusiness_GetAll")]
        public void ProviderBusiness_GetAll_WhenExistprovider()
        {
            var business = new ProviderBusiness();

            var Providers = business.GetAll();
        }

        [TestMethod]
        [TestCategory("providerBusiness_Delete")]

        public void ProviderBusiness_Delete()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var provider = new ProviderDomain() { Name = "Distribuidaora", CNPJ = "65986598", Address = "rua 2", Email = "Teste@gmail.com" };
                var business = new ProviderBusiness();

                business.Save(provider);

                var result = business.Delete(provider.ID);

                Assert.AreEqual(EnumReply.Success, result.Reply);

                var resultConsult = business.GetByID(provider.ID);
                Assert.AreEqual(null, resultConsult.Entity);
            }
        }

        [TestMethod]
        [TestCategory("ProviderBusiness_Save")]
        public void ClientBusiness_Save_New_WithoutCNPJ()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var provider = new ProviderDomain() {Name = "Distribuidaora", Address = "rua 2", Email = "Teste@gmail.com" };
                var business = new ProviderBusiness();

                var result = business.Save(provider);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }

        }

        [TestMethod]
        [TestCategory("ProviderBusiness_Save")]
        public void pROVIDERBusiness_Save_New_WithoutName()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var provider = new ProviderDomain() { CNPJ = "CNPJ Test", Email= "Teste@gmail.com" };
                var business = new ProviderBusiness();

                var result = business.Save(provider);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("providerBusiness_Save")]
        public void ProviderBusiness_Save_Edit()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var provider = new ProviderDomain() {Name = "Distribuidaora", CNPJ = "65986598", Address = "rua 2", Email = "Teste@gmail.com" };
                var business = new ProviderBusiness();

                var result = business.Save(provider);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                provider.CNPJ = "65412356";
                provider.Name = "Sra Teste";
                provider.Address = "rua 2";
                provider.Email = "Teste@email";
                

                var resultUpdate = business.Save(provider);

                var resultConsult = business.GetByID(provider.ID);
                Assert.AreEqual(provider.CNPJ, result.Entity.CNPJ);
                Assert.AreEqual(provider.Name, result.Entity.Name);
                Assert.AreEqual(provider.Address, result.Entity.Address);
                Assert.AreEqual(provider.Email, result.Entity.Email);
              

            }
        }
    }  
}
