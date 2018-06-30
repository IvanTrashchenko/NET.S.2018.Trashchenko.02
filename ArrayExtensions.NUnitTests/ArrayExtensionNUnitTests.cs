using System;
using NUnit.Framework;

namespace ArrayExtensions.NUnitTests
{
    [TestFixture]
    public class ArrayExtensionNUnitTests
    {
        [TestCase(7, 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17, ExpectedResult = new int[] { 7, 7, 70, 17 })]
        [TestCase(7, new int[] { 7, 1, 2, 3, 4, 5, 6, -7, 68, 69, -70, 15, 17 }, ExpectedResult = new int[] { 7, -7, -70, 17 })]
        [TestCase(7, 1, ExpectedResult = new int[] { })]
        public int[] FilterDigitTest(int digit, params int[] array)
        {
            return ArrayExtension.FilterDigit(digit, array);
        }

        [TestCase(7, null)]
        public void FilterDigitTest_ThrowArgumentNullException(int digit, int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => ArrayExtension.FilterDigit(digit, array));
        }

        [TestCase(-7, 7, 1, 2, 3, 4, 5, 6, -7, 68, 69, -70, 15, 17)]
        public void FilterDigitTest_ThrowArgumentOutOfRangeException(int digit, params int[] array)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtension.FilterDigit(digit, array));
        }
    }
}