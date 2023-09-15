using static LINQ.Delegates.DelegateExample;

namespace LINQ.Delegates
{
    internal class FuncExample
    {
        //before -- using delegate
        /*public delegate int PerformCalculation(int x, int y);*/

        /*int TwoNumbersCalculator(int first, int second, PerformCalculation calculator)
        {
            return calculator.Invoke(first, second);
        }*/
        int TwoNumbersCalculator(int first, int second, Func<int, int, int> calculator)
        {
            return calculator.Invoke(first, second);
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public static void Main(string[] args)
        {
            /* // Create an instance of class DelegateExample
             FuncExample calculator = new FuncExample();

             // Create delegate instances
             PerformCalculation multiplyDelegate = calculator.Multiply;
             PerformCalculation addDelegate = calculator.Add;

             // Use the delegate to perform calculations
             int product = calculator.TwoNumbersCalculator(4, 4, multiplyDelegate);
             int sum = calculator.TwoNumbersCalculator(4, 4, addDelegate);

             Console.WriteLine($"Product: {product}");
             Console.WriteLine($"Sum: {sum}");*/

            FuncExample calculator = new FuncExample();
            var product = calculator.TwoNumbersCalculator(4, 4, calculator.Multiply);
            Console.WriteLine(product);

            var sum = calculator.TwoNumbersCalculator(4, 4, calculator.Add);
            Console.WriteLine(sum); 
        }
    }
}
