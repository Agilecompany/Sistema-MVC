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

    public class ClienteBusinessTest
    {
        [TestMethod]
        [TestCategory("ClientBusiness_Save")]
        public void ClientBusiness_Save_New()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var client = new ClientDomain() { Email = "teste@gmail.com", Name = "Sr Teste", CPF = "395.659.698.10", Phone = "2944-3956" };
                var business = new ClientBusiness();

                var result = business.Save(client);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

            }
        }

        [TestMethod]
        [TestCategory("ClientBusiness_Save")]
        public void ClientBusiness_Save_New_DuplicateCPF()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var client = new ClientDomain() { Email = "teste2@gmail.com", Name = "Sr Teste", CPF = "395.659.698.10", Phone = "2944-3956" };
                var business = new ClientBusiness();

                var result = business.Save(client);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var clientDuplicate = new ClientDomain() { Email = "teste@gmail.com", Name = "Sr Teste", CPF = "395.659.698.10", Phone = "2944-3956" };
                var resultDuplicate = business.Save(clientDuplicate);

                Assert.AreEqual(EnumReply.BusinessError, resultDuplicate.Reply);
                Assert.IsNull(resultDuplicate.Entity);

            }
        }

        [TestMethod]
        [TestCategory("ClientBusiness_Save")]
        public void ClientBusiness_Save_New_DuplicateEmail()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var client = new ClientDomain() { Email = "teste@gmail.com", Name = "Sr Teste", CPF = "395.657.698.10", Phone = "2944-3956" };
                var business = new ClientBusiness();

                var result = business.Save(client);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var clientDuplicate = new ClientDomain() { Email = "teste@gmail.com", Name = "Sr Teste", CPF = "395.659.698.10", Phone = "2944-3956" };
                var resultDuplicate = business.Save(clientDuplicate);

                Assert.AreEqual(EnumReply.BusinessError, resultDuplicate.Reply);
                Assert.IsNull(resultDuplicate.Entity);

            }
        }

        [TestMethod]
        [TestCategory("ClientBusiness_GetByID")]
        public void ClientBusiness_GetByID_WhenDoesntExistClient()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {

                var business = new ClientBusiness();
                var result = business.GetByID(5000);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("ClientBusiness_GetByID")]
        public void ClientBusiness_GetByID_WhenExistClient()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var client = new ClientDomain() { CPF = "CPF Test", Phone = "8986-8956", Name = "Sr Teste" };
                var business = new ClientBusiness();

                business.Save(client);

                var result = business.GetByID(client.ID);


                Assert.IsNotNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("ClientBusiness_GetAll")]
        public void ClientBusiness_GetAll_WhenExistUsers()
        {
            var business = new ClientBusiness();

            var Clients = business.GetAll();
        }


        [TestMethod]
        [TestCategory("ClientBusiness_Delete")]

        public void ClientBusiness_Delete()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var client = new ClientDomain() { CPF = "CPF Test",  Name = "Sr Teste", Phone = "8986-8956" };
                var business = new ClientBusiness();

                business.Save(client);

                var result = business.Delete(client.ID);

                Assert.AreEqual(EnumReply.Success, result.Reply);

                var resultConsult = business.GetByID(client.ID);
                Assert.AreEqual(null, resultConsult.Entity);
            }
        }


        [TestMethod]
        [TestCategory("ClientBusiness_Save")]
        public void ClientBusiness_Save_New_WithoutCPF()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var client = new ClientDomain() { Phone = "8986-8956", Name = "Sr Teste"};
                var business = new ClientBusiness();

                var result = business.Save(client);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }

        }


        [TestMethod]
        [TestCategory("ClientBusiness_Save")]
        public void ClientBusiness_Save_New_WithoutName()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var client = new ClientDomain() { CPF = "CPF Test", Phone = "8986-8956"};
                var business = new ClientBusiness();

                var result = business.Save(client);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("ClientBusiness_Save")]
        public void ClientBusiness_Save_Edit()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var client = new ClientDomain() { CPF = "123654", Email = "teste@gmail.com", Name = "Sr Teste", Phone = "1236547899", CellPhone = "456985"};
                var business = new ClientBusiness();

                var result = business.Save(client);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                client.CPF = "654123";
                client.Email = "teste@gmai";
                client.Name = "Sra Teste";
                client.Phone = "99999999";
                client.CellPhone = "8888888";

                var resultUpdate = business.Save(client);

                var resultConsult = business.GetByID(client.ID);
                Assert.AreEqual(client.CPF, result.Entity.CPF);
                Assert.AreEqual(client.Email, result.Entity.Email);
                Assert.AreEqual(client.Name, result.Entity.Name);
                Assert.AreEqual(client.Phone, result.Entity.Phone);
                Assert.AreEqual(client.CellPhone, result.Entity.CellPhone);

            }
        }

    }
}

