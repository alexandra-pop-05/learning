namespace YieldReturnExample
{
    public class Program
    {
        public static void Main()
        {
            var enumerable = EnumerateMethod();

            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<int> EnumerateMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return i;
            }
        }
    }
}

