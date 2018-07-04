using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayExtensions.Tests
{
    using System.Diagnostics;

    [TestClass]
    public class ArrayExtensionTests
    {
        [TestMethod]
        public void FilterDigit_WithDigit7_Success()
        {
            int[] array = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int digit = 7;

            int[] expected = { 7, 7, 70, 17 };

            int[] actual = ArrayExtension.FilterDigit(digit, new Division(), array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterDigit_WithDigit7_AndNegativeElementsInArray_Success()
        {
            int[] array = { 7, 1, 2, 3, 4, 5, 6, -7, 68, 69, -70, 15, 17 };
            int digit = 7;

            int[] expected = { 7, -7, -70, 17 };

            int[] actual = ArrayExtension.FilterDigit(digit, new Division(), array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterDigit_WithDigit7_AndOneElementInArray_Success()
        {
            int[] array = { 1 };
            int digit = 7;

            int[] expected = { };

            int[] actual = ArrayExtension.FilterDigit(digit, new Division(), array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void FilterDigit_WithNullArgument_ThrowArgumentNullException()
        {
            int[] array = null;
            int digit = 7;

            int[] actual = ArrayExtension.FilterDigit(digit, new Division(), array);
        }

        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FilterDigit_WithDigitMinus7_ThrowArgumentOutOfRangeException()
        {
            int[] array = { 7, 1, 2, 3, 4, 5, 6, -7, 68, 69, -70, 15, 17 };
            int digit = -7;

            int[] actual = ArrayExtension.FilterDigit(digit, new Division(), array);
        }
    }
}
