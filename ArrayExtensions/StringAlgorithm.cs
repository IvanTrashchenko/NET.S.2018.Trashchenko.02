namespace ArrayExtensions
{
    /// <summary>
    /// Algorithm which uses strings.
    /// </summary>
    public class StringAlgorithm : IAlgorithm
    {
        public bool IsDigit(int number, int digit)
        {
            return number.ToString().Contains(digit.ToString());
        }
    }
}
