using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReferenceTracker;

namespace ReferenceTracker.Tests
{
    [TestClass]
    public class HelperTests
    {
        [TestMethod]
        public void CheckEmail_ReturnTrue()
        {
            Helper h = new Helper();
            Assert.AreEqual(true, h.CheckEmail("binod@test.com"));
        }
    }
}
