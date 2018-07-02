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

        [TestMethod]
        public void Comparison_Of_ComputationalSpeed_Of_Algorithms()
        {
            
            int[] array = { 7, 1, 2, 3, 443, 5, 6, 7, 68, 69, 70, 15, 17, -23, 0, 23, 3456, 967, 111, 3456, 7, 321, -2344, -27 };
            int digit = 7;

            int[] expected = { 7, 7, 70, 17, 967, 7, -27 };

            Stopwatch watch1 = Stopwatch.StartNew();
            int[] actual = ArrayExtension.FilterDigit(digit, new Division(), array);
            watch1.Stop();

            Stopwatch watch2 = Stopwatch.StartNew();
            actual = ArrayExtension.FilterDigit(digit, new StringAlgorithm(), array);
            watch2.Stop();

            Debug.WriteLine($"Time elapsed for division algorithm: {watch1.Elapsed} milliseconds.");
            Debug.WriteLine($"Time elapsed for string algorithm: {watch2.Elapsed} milliseconds.");

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
