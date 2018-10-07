using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReferenceTracker.Tests
{
    [TestClass]
    public class UserServiceTests
    {
        [TestMethod]
        public void CheckUserID()
        {
            UserService us = new UserService();
            int id = us.GetLoginUserID("what", "what");
            Assert.AreEqual(0, id):
        }
    }
}
