using System;
using System.Collections.Generic;

namespace ArrayExtensions
{
    /// <summary>
    /// Class of filter method.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Method that filters array by specific digit. 
        /// </summary>
        /// <param name="digit">Digit to be filtered by.</param>
        /// <param name="algorithm">Algorithm to be used: with strings or with division.</param>
        /// <param name="array">Array to be filtered.</param>
        /// <returns>Filtered array.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when digit is incorrect.</exception>
        public static int[] FilterDigit(int digit, IAlgorithm algorithm, params int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{array} cannot be null.");
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException($"{digit} is out of range.");
            }

            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (algorithm.IsDigit(Math.Abs(array[i]), digit))
                {
                    list.Add(array[i]);
                }
            }

            return list.ToArray();
        }
    }
}
