namespace ArrayExtensions
{
    /// <summary>
    /// Interface class for implementing IsDigit method.
    /// </summary>
    public interface IAlgorithm
    {
        /// <summary>
        /// Method for finding specific digit in number.
        /// </summary>
        /// <param name="number">Number in which the search is performed.</param>
        /// <param name="digit">Digit to be found.</param>
        /// <returns>True, if the number contains the digit; otherwise, false.</returns>
        bool IsDigit(int number, int digit);
    }
}
