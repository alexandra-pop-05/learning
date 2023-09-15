namespace LINQ.Delegates
{
    internal class DelegateExample
    {
        //define a delegate method
        public delegate int PerformCalculation(int x, int y);

        int TwoNumbersCalculator(int first, int second, PerformCalculation calculator)
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
        /*public static void Main(string[] args)
        {
            // Create an instance of class DelegateExample
            DelegateExample calculator = new DelegateExample();

            // Create delegate instances
            PerformCalculation multiplyDelegate = calculator.Multiply;
            PerformCalculation addDelegate = calculator.Add;

            // Use the delegate to perform calculations
            int product = calculator.TwoNumbersCalculator(4, 4, multiplyDelegate);
            int sum = calculator.TwoNumbersCalculator(4, 4, addDelegate);

            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Sum: {sum}");
        }*/
    }

}
