using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using Task5;

namespace UnitTestProject2
{
    [TestClass]
    public class ObserverTests
    {
        [TestMethod]
        public void CalculateWagonsCountTest()
        {
            var expected = 50;
            Train train = new Train(expected);

            var actual = Observer.CalculateWagonsCount(train);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateWagonsCountInvalidValueTest()
        {
            var invalidValue = -1;
            Assert.ThrowsException<ArgumentException>(new Action(() => new Train(invalidValue)));
        }
    }
}
