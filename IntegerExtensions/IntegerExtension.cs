using System;

namespace IntegerExtensions
{
    /// <summary>
    /// Class of inserting bits method.
    /// </summary>
    public static class IntegerExtension
    {
        private const int MaxBitValue = 31;

        /// <summary>
        /// Method which inserts bits from one number to another.
        /// </summary>
        /// <param name="numberSource">Number to take bits from.</param>
        /// <param name="numberIn">Number to insert bits to.</param>
        /// <param name="i">Start position at which the bits are taken.</param>
        /// <param name="j">End position at which the bits are taken.</param>
        /// <returns>Result.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when position values are out of range.</exception>
        /// <exception cref="ArgumentException">Thrown when position values are incorrect.</exception>
        public static int InsertNumber(int numberSource, int numberIn, int i, int j)
        {
            if (i < 0 || i > MaxBitValue)
            {
                throw new ArgumentOutOfRangeException($"{i} is out of range.");
            }

            if (j < 0 || j > MaxBitValue)
            {
                throw new ArgumentOutOfRangeException($"{j} is out of range.");
            }

            if (j < i)
            {
                throw new ArgumentException($"{i} is greater than {j}.");
            }

            int mask1 = (1 << (j - i + 1)) - 1;
            numberIn = (numberIn & mask1) << i;

            int mask2 = ~((1 << i) - 1);
            numberSource &= mask2;

            return numberSource | numberIn;
        }
    }
}