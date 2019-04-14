using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5;

namespace UnitTestProject2
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void CreateTrainTest()
        {
            var expected = 10;
            Train train = new Train(expected);
            var actual = train.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateTrainNullWagonsTest()
        {
            Train train = new Train(20);
            foreach(Wagon wagon in train)
            {
                Assert.IsNotNull(wagon.Next);
                Assert.IsNotNull(wagon.Previous);
            }
        }
    }
}
