using System;
using System.Collections.Generic;

namespace ArrayExtensions
{
    /// <summary>
    /// Class of filter method.
    /// </summary>
    public static class ArrayExtension
    {
        #region Filtering method
        /// <summary>
        /// Method that filters array by specific digit. 
        /// </summary>
        /// <param name="digit">Digit to be filtered by.</param>
        /// <param name="array">Array to be filtered.</param>
        /// <returns>Filtered array.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when digit is incorrect.</exception>
        public static int[] FilterDigit(int digit, params int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit));
            }

            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (IsDigit(Math.Abs(array[i]), digit))
                {
                    list.Add(array[i]);
                }
            }

            return list.ToArray();
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Method for finding specific digit in number.
        /// </summary>
        /// <param name="number">Number in which the search is performed.</param>
        /// <param name="digit">Digit to be found.</param>
        /// <returns>True, if the number contains the digit; otherwise, false.</returns>
        private static bool IsDigit(int number, int digit)
        {
            while (number != 0)
            {
                int t = number % 10;

                if (t == digit)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
        #endregion   
    }
}
