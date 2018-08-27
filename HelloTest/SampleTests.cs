using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloTest
{
    [TestClass]
    public class SampleTests
    {
        [TestMethod]
        public void SuccessTest()
        {
            Assert.IsNotNull(1);
        }

        [TestMethod]
        public void FailTest()
        {
            int? nullableObject = null;
            Assert.IsNotNull(nullableObject);
        }
    }
}
