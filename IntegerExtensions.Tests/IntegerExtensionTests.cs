using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegerExtensions.Tests
{
    [TestClass]
    public class IntegerExtensionTests
    {
        [TestMethod]
        public void InsertNumber_Test1_Success()
        {
            int expected = 15;

            int actual = IntegerExtension.InsertNumber(15, 15, 0, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertNumber_Test2_Success()
        {
            int expected = 9;

            int actual = IntegerExtension.InsertNumber(8, 15, 0, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertNumber_Test3_Success()
        {
            int expected = 120;

            int actual = IntegerExtension.InsertNumber(8, 15, 3, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_WithPositionsOutOfRange_ThrowArgumentOutOfRangeException()
        {
            int actual = IntegerExtension.InsertNumber(8, 15, -3, 8);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void InsertNumber_WithIncorrectPositions_ThrowArgumentException()
        {
            int actual = IntegerExtension.InsertNumber(8, 15, 9, 8);
        }
    }
}
