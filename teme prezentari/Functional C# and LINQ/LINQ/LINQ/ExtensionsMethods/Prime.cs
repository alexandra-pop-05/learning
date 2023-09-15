namespace LINQ.ExtensionsMethods
{
    public static class IntExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class PrimeNumber
    {
        public bool IsPrime2(int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
