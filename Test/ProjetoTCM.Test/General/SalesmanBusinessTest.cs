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
    public class SalesmanBusinessTest
    {
        [TestMethod]
        [TestCategory("SalesmanBusiness_Save")]
        public void SalesmanBusiness_Save_New()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var salesman = new SalesmanDomain() { Email = "teste123@gmail.com", Name = "Sr Teste", Address ="rua 2", CPF = "495.659.698.10", Phone = "2944-4956" };
                var business = new SalesmanBusiness();

                var result = business.Save(salesman);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

            }
        }


        [TestMethod]
        [TestCategory("SalesmanBusiness_Save")]
        public void SalesmanBusiness_Save_New_CPFDuplicate()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var salesman = new SalesmanDomain() { Email = "teste123@gmail.com", Name = "Sr Teste", Address = "rua 2", CPF = "495.659.698.10", Phone = "2944-4956" };
                var business = new SalesmanBusiness();

                var result = business.Save(salesman);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var salesmanDuplicate = new SalesmanDomain() { Email = "te2ste@gmail.com", Name = "Sr Teste", Address = "rua 2", CPF = "495.659.698.10", Phone = "2944-4956" };
                var resultDuplicate = business.Save(salesmanDuplicate);

                Assert.AreEqual(EnumReply.BusinessError, resultDuplicate.Reply);
                Assert.IsNull(resultDuplicate.Entity);

            }
        }

        [TestMethod]
        [TestCategory("SalesmanBusiness_Save")]
        public void SalesmanBusiness_Save_New_EmailDuplicate()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var salesman = new SalesmanDomain() { Email = "teste123@gmail.com", Name = "Sr Teste", Address = "rua 2", CPF = "495.659.698.10", Phone = "2944-4956" };
                var business = new SalesmanBusiness();

                var result = business.Save(salesman);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var salesmanDuplicate = new SalesmanDomain() { Email = "teste123@gmail.com", Name = "Sr Teste", Address = "rua 2", CPF = "495.657.698.10", Phone = "2944-4956" };
                var resultDuplicate = business.Save(salesmanDuplicate);


                Assert.AreEqual(EnumReply.BusinessError, resultDuplicate.Reply);
                Assert.IsNull(resultDuplicate.Entity);

            }
        }


        [TestMethod]
        [TestCategory("SalesmanBusiness_GetByID")]
        public void SalesmanBusiness_GetByID_WhenDoesntExistSalesman()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {

                var business = new SalesmanBusiness();
                var result = business.GetByID(5000);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("SalesmanBusiness_GetAll")]
        public void SalesmanBusiness_GetAll_WhenExistUsers()
        {
            var business = new SalesmanBusiness();

            var Salesman = business.GetAll();
        }

        [TestMethod]
        [TestCategory("SalesmaBusiness_Delete")]

        public void SalesmanBusiness_Delete()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var salesman = new SalesmanDomain() { Email = "teste123@gmail.com", Name = "Sr Teste", Address = "rua 2", CPF = "495.659.698.10", Phone = "2944-4956" };
                var business = new SalesmanBusiness();

                business.Save(salesman);

                var result = business.Delete(salesman.ID);

                Assert.AreEqual(EnumReply.Success, result.Reply);

                var resultConsult = business.GetByID(salesman.ID);
                Assert.AreEqual(null, resultConsult.Entity);
            }
        }


        [TestMethod]
        [TestCategory("SalesmanBusiness_Save")]
        public void SalesmanBusiness_Save_New_WithoutCPF()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var salesman = new SalesmanDomain() { Email = "teste123@gmail.com", Name = "Sr Teste", Address = "rua 2", Phone = "2944-4956" };
                var business = new SalesmanBusiness();

                var result = business.Save(salesman);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }

        }

        [TestMethod]
        [TestCategory("SalesmanBusiness_Save")]
        public void SalesmanBusiness_Save_New_WithoutName()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var salesman = new SalesmanDomain() { Email = "teste123@gmail.com", CPF = "495.659.698.10", Address = "rua 2", Phone = "2944-4956" };
                var business = new SalesmanBusiness();

                var result = business.Save(salesman);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }

        }


        [TestMethod]
        [TestCategory("SalesmanBusiness_Save")]
        public void SalesmanBusiness_Save_New_WithoutAddress()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var salesman = new SalesmanDomain() { Email = "teste123@gmail.com", Name = "Sr Teste", CPF = "495.659.698.10", Phone = "2944-4956" };
                var business = new SalesmanBusiness();

                var result = business.Save(salesman);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }

        }

        [TestMethod]
        [TestCategory("SalesmanBusiness_Save")]
        public void SalesmanBusiness_Save_New_WithoutEmai()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var salesman = new SalesmanDomain() {  Name = "Sr Teste", Address = "rua 2", CPF = "495.659.698.10", Phone = "2944-4956" };
                var business = new SalesmanBusiness();

                var result = business.Save(salesman);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }

        }




    }
}
