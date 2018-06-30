using System;
using NUnit.Framework;

namespace IntegerExtensions.NUnitTests
{
    [TestFixture]
    public class IntegerExtensionNUnitTests
    {
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(15, 15, 3, 8, ExpectedResult = 120)]
        public int InsertNumberTest(int numberSource, int numberIn, int i, int j)
        {
              return IntegerExtension.InsertNumber(numberSource, numberIn, i, j);
        }

        [TestCase(8, 15, 9, 8)]
        public void InsertNumberTest_ThrowArgumentException(int numberSource, int numberIn, int i, int j)
        {
            Assert.Throws<ArgumentException>(() => IntegerExtension.InsertNumber(numberSource, numberIn, i, j));
        }

        [TestCase(8, 15, -3, 8)]
        public void InsertNumberTest_ThrowArgumentOutOfRangeException(int numberSource, int numberIn, int i, int j)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => IntegerExtension.InsertNumber(numberSource, numberIn, i, j));
        }
    }
}