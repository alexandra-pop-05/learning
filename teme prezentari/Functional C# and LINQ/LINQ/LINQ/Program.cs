using LINQ.ExtensionsMethods;
using LINQ.Delegates;
using System.Linq.Expressions;

namespace LINQ
{
    public static class IntExtensions
    {

        internal class Program
        {
            static void Main(string[] args)
            {

              /*  //EXTENSION METHODS
                // using THIS keyword
                int number = 30;
                Console.WriteLine(number.IsPrime());

                // without using THIS keyword
                PrimeNumber prime = new PrimeNumber();
                int number2 = 30;
                Console.WriteLine(prime.IsPrime2(number2));
*/

                //LAMBDA EXPRESSIONS
                var sum = (int x, int y) => x + y;
                var product = (int x, int y) => x * y;

            }
        }
    }
}