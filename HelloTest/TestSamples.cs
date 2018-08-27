using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloTest
{
    [TestClass]
    public class TestSamples
    {
        [TestMethod]
        public void SuccessTest()
        {
        }

        [TestMethod]
        public void FailTest()
        {
            int? nullable = null;
            Assert.IsNotNull(nullable);
        }
    }
}
