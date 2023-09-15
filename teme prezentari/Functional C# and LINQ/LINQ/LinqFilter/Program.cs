namespace LinqFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 25, 38, 147, 2022, 2023, 2024 };
            string[] countries = { "Romania", "Moldova", "Austria", "Australia" };
            char[] characters = { 'a', 'r', 'u', 'i' };

            //if i want to apply multiple filters at the same time - NOT IDEAL
            //var biggerThanFive = Filter(numbers, number => number > 5);
            //var evenNumbers = Filter(biggerThanFive, number => number % 2 == 0);
            //  var result = Filter(evenNumbers, number => number > 2000);

            //if i want to apply multiple filters at the same time - IDEAL
            //declar o clasa IntArrayExtnsions si folosesc THIS keyword
            var result = numbers
                .Filter(number => number > 5)
                .Where(number => number % 2 == 0)
                .Filter(number => number < 2000)
            ;

            //vrem ca filtrul sa poata fi utilizat si pe ate tipuri: string => folosim generics

            var countriesStartingWithA = countries
                .Filter(country => country.StartsWith("A"))
            ;
            var charactersA = characters
                .Filter(character => character == 'i')
            ;


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        /*static int[] Filter(int[] numbers, Func<int, bool> predicate)
        {
            var result = new List<int>();

            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    result.Add(number);
                }
            }
            return result.ToArray();
        }*/
    }

}
//using generics
/*static class IntArrayExtensions
{
    public static T[] Filter<T>(this T[] numbers, Func<T, bool> predicate)
    {
        var result = new List<T>();

        foreach (var number in numbers)
        {
            if (predicate(number))
            {
                result.Add(number);
            }
        }
        return result.ToArray();
    }
}*/


//using yield return cu IEnumerable pentru a nu astepta sa luam un anumit element doar cand se adauga toate elementele in lista si doar apoi intoarcem toate elementele. 
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

//functia implementata mai sus e corpul metodei WHERE din LINQ