using System;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTCM.Business.Security;
using ProjetoTCM.Domain.Enum;
using ProjetoTCM.Domain.Security;
using ProjetoTCM.Infrastructure.Common.Enum;

namespace ProjetoTCM.Test.Security
{
    [TestClass]
    public class UserBusinessTest
    {
        [TestMethod]
        [TestCategory("UserBusiness_Authentication")]
        public void UserBusiness_Authentication_True()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "teste", Password = "123456", Email = "teste@gmail.com", Name = "Sr Teste" };
                var business = new UserBusiness();

                business.Save(user);

                var result = business.Authentication(user.Login, user.Password);

                Assert.AreEqual(EnumReply.Success, result.Reply);
            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_Authentication")]
        public void UserBusiness_Authentication_Login_False()
        {
            var user = new UserDomain() { Login = "teste", Password = "1234567" };
            var business = new UserBusiness();
            var result = business.Authentication("TesteNew", user.Password);

            Assert.AreEqual(EnumReply.BusinessError, result.Reply);
        }

        [TestMethod]
        [TestCategory("UserBusiness_Authentication")]
        public void UserBusiness_Authentication_Password_False()
        {
            var user = new UserDomain() { Login = "teste", Password = "1234567" };
            var business = new UserBusiness();
            var result = business.Authentication(user.Login, "12345");

            Assert.AreEqual(EnumReply.BusinessError, result.Reply);
        }

        [TestMethod]
        [TestCategory("UserBusiness_Save")]
        public void UserBusiness_Save_NewAdmin()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "teste", Password = "123456", Email = "teste@gmail.com", Name = "Sr Teste", Profile = EnumProfile.Admin };
                var business = new UserBusiness();

                var result = business.Save(user);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var resultConsult = business.GetByID(user.ID);
                Assert.AreEqual(EnumProfile.Admin, result.Entity.Profile);

            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_Save")]
        public void UserBusiness_Save_New_LoginDuplicate()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "teste", Password = "123456", Email = "teste@gmail.com", Name = "Sr Teste", Profile = EnumProfile.Admin };
                var business = new UserBusiness();

                var result = business.Save(user);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var userDuplicate = new UserDomain() { Login = "teste", Password = "123456", Email = "tdeste@gmail.com", Name = "Sr Teste", Profile = EnumProfile.Admin };
                var resultDuplicate = business.Save(userDuplicate);

                Assert.AreEqual(EnumReply.BusinessError, resultDuplicate.Reply);
                Assert.IsNull(resultDuplicate.Entity);
            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_Save")]
        public void UserBusiness_Save_New_EmailDuplicate()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "teste", Password = "123456", Email = "teste@gmail.com", Name = "Sr Teste", Profile = EnumProfile.Admin };
                var business = new UserBusiness();

                var result = business.Save(user);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var userDuplicate = new UserDomain() { Login = "teste2", Password = "123456", Email = "teste@gmail.com", Name = "Sr Teste", Profile = EnumProfile.Admin };
                var resultDuplicate = business.Save(userDuplicate);

                Assert.AreEqual(EnumReply.BusinessError, resultDuplicate.Reply);
                Assert.IsNull(resultDuplicate.Entity);
            }
        }


        [TestMethod]
        [TestCategory("UserBusiness_Save")]
        public void UserBusiness_Save_NewCashier()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "teste", Password = "123456", Email = "teste@gmail.com", Name = "Sr Teste", Profile = EnumProfile.Cashier };
                var business = new UserBusiness();

                var result = business.Save(user);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                var resultConsult = business.GetByID(user.ID);
                Assert.AreEqual(EnumProfile.Cashier, result.Entity.Profile);

            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_Save")]
        public void UserBusiness_Save_Edit()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "teste", Password = "123456", Email = "teste@gmail.com", Name = "Sr Teste", Profile = EnumProfile.Cashier };
                var business = new UserBusiness();

                var result = business.Save(user);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.AreNotEqual(0, result.Entity.ID);

                user.Name = "Sr Teste New";
                user.Login = "testeNew";
                user.Password = "123456New";
                user.Email = "testenew@gmail.com";
                user.Profile = EnumProfile.Admin;
                
                var resultUpdate = business.Save(user);

                var resultConsult = business.GetByID(user.ID);
                Assert.AreEqual(user.Name, result.Entity.Name);
                Assert.AreEqual(user.Login, result.Entity.Login);
                Assert.AreEqual(user.Password, result.Entity.Password);
                Assert.AreEqual(user.Email, result.Entity.Email);
                Assert.AreEqual(user.Profile, result.Entity.Profile);

            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_Save")]
        public void UserBusiness_Save_New_WithoutLogin()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() {  Password = "123456", Email = "teste@gmail.com", Name = "Sr Teste", Profile = EnumProfile.Cashier };
                var business = new UserBusiness();

                var result = business.Save(user);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_Save")]
        public void UserBusiness_Save_New_WithoutPassword()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "123456", Email = "teste@gmail.com", Name = "Sr Teste", Profile = EnumProfile.Cashier };
                var business = new UserBusiness();

                var result = business.Save(user);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_Save")]
        public void UserBusiness_Save_New_WithoutEmail()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "123456", Password = "teste", Name = "Sr Teste", Profile = EnumProfile.Cashier };
                var business = new UserBusiness();

                var result = business.Save(user);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_Save")]
        public void UserBusiness_Save_New_WithoutName()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "123456", Email = "teste@gmail.com", Password = "SrTeste", Profile = EnumProfile.Cashier };
                var business = new UserBusiness();

                var result = business.Save(user);

                Assert.AreEqual(EnumReply.BusinessError, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_Delete")]
        public void UserBusiness_Delete()
        {
            using(TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "teste", Password = "123456", Email = "teste@gmail.com", Name = "Sr Teste" };
                var business = new UserBusiness();

                business.Save(user);

                var result = business.Delete(user.ID);

                Assert.AreEqual(EnumReply.Success, result.Reply);

                var resultConsult = business.GetByID(user.ID);
                Assert.AreEqual(null, resultConsult.Entity);
            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_GetAll")]
        public void UserBusiness_GetAll_WhenExistUsers()
        {
            var business = new UserBusiness();

            var users = business.GetAll();
        }


        [TestMethod]
        [TestCategory("UserBusiness_GetByID")]
        public void UserBusiness_GetByID_WhenDoesntExistUser()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                
                var business = new UserBusiness();
                var result = business.GetByID(5000);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.IsNull(result.Entity);
            }
        }

        [TestMethod]
        [TestCategory("UserBusiness_GetByID")]
        public void UserBusiness_GetByID_WhenExistUser()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var user = new UserDomain() { Login = "teste", Password = "123456", Email = "teste@gmail.com", Name = "Sr Teste" };
                var business = new UserBusiness();

                business.Save(user);

                var result = business.GetByID(user.ID);

                Assert.AreEqual(EnumReply.Success, result.Reply);
                Assert.IsNotNull(result.Entity);
            }
        }
    }
}
