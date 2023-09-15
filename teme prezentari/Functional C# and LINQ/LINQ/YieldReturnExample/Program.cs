namespace YieldReturnExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var enumerable = EnumerateMethod();

            foreach (var item in enumerable)
            {
                Console.WriteLine("reparing to return the element: " +item);
            }
        }

        private static IEnumerable<int> EnumerateMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("IEnumerable created!");
              yield return i;
                Console.WriteLine("Returned: " + i);
            }
        }
    }
}
