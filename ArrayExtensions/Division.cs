namespace ArrayExtensions
{
    /// <summary>
    /// Algorithm which uses division.
    /// </summary>
    public class Division : IAlgorithm
    {
        public bool IsDigit(int number, int digit)
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
    }
}
