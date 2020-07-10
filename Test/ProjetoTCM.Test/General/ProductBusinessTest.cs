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
    public class ProductBusinessTest
    {

        [TestMethod]
        [TestCategory("ProductBusiness_Save")]
        public void ProductBusiness_Save_New() 
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var product= new ProductDomain() { ExternalCode = "20195655", Name = "camisa do brasil", Description = "tenis", Model="calca" };
                var business = new ProductBusiness();

                var result = business.Save(product);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

            }
        }


        [TestMethod]
        [TestCategory("ProductBusiness_Save")]
        public void ProductBusiness_Save_New_ExternalCodeDuplicate()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var product = new ProductDomain() { ExternalCode = "20195655", Name = "camisa do brasil", Description = "tenis", Model = "calca" };
                var business = new ProductBusiness();

                var result = business.Save(product);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var productDuplicate = new ProductDomain() { ExternalCode = "20195655", Name = "camisa do brasil", Description = "tenis", Model = "calca" };
                var resultDuplicate = business.Save(productDuplicate);

                Assert.AreEqual(EnumReply.BusinessError, resultDuplicate.Reply);
                Assert.IsNull(resultDuplicate.Entity);

            }
        }

        [TestMethod]
        [TestCategory("ProductBusiness_GetByID")]
        public void ProductBusiness_GetByID_WhenDoesntExistClient()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {

                var business = new ProductBusiness();
                var result = business.GetByID(5000);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("ProductBusiness_GetAll")]
        public void ProductBusiness_GetAll_WhenExistUsers()
        {
            var business = new ProductBusiness();

            var Products = business.GetAll();
        }

        [TestMethod]
        [TestCategory("ProductBusiness_Delete")]

        public void ProductBusiness_Delete()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var product = new ProductDomain() { ExternalCode = "20195655", Name = "camisa do brasil" };
                var business = new ProductBusiness();

                business.Save(product);

                var result = business.Delete(product.ID);

                Assert.AreEqual(EnumReply.Success, result.Reply);

                var resultConsult = business.GetByID(product.ID);
                Assert.AreEqual(null, resultConsult.Entity);
            }
        }

        [TestMethod]
        [TestCategory("ProductBusiness_Save")]
        public void ProductBusiness_Save_New_WithoutExternalCod()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var product = new ProductDomain() {  Name = "camisa do brasil" };
                var business = new ProductBusiness();

                var result = business.Save(product);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }

        }

        [TestMethod]
        [TestCategory("ProductBusiness_Save")]
        public void ProductBusiness_Save_New_WithoutName()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var product = new ProductDomain() { ExternalCode = "20195655" };
                var business = new ProductBusiness();

                var result = business.Save(product);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }

        }

        [TestMethod]
        [TestCategory("ProductBusiness_Save")]
        public void ProductBusiness_Save_Edit()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var product = new ProductDomain() { ExternalCode = "20195655", Name = "camisa do brasil" };
                var business = new ProductBusiness();

                var result = business.Save(product);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                product.ExternalCode = "20195655";
                product.Name = "Sra Teste";

                var resultUpdate = business.Save(product);

                var resultConsult = business.GetByID(product.ID);
                Assert.AreEqual(product.Name, result.Entity.Name);
                Assert.AreEqual(product.ExternalCode, result.Entity.ExternalCode);

            }
        }
    }
}
