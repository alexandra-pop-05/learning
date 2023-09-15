namespace Vertices
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 25, 38, 147, 2022, 2023 };
            string[] countries = { "Romania", "Moldova", "Austria", "Australia" };
            char[] characters = { 'a', 'r', 'u', 'i' };

            /*var result = numbers
                .Where(number => number > 5)
                .Filter(number => number % 2 == 0)
                .Where(number => number < 2000)
            ;*/
            var result = countries
                .Filter(country => country.StartsWith("A"))
            ;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

static class IntArrayExtensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> numbers, Func<T, bool> predicate)
    {
        foreach (var number in numbers)
        {
            if (predicate(number))
            {
                yield return number;
            }
        }
    }
}
