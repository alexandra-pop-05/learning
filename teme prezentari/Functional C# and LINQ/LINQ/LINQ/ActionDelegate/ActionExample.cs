namespace LINQ.ActionDelegate
{
    internal class ActionExample
    {
        static void PerformAction(Action action)
        {
            Console.WriteLine("Before action...");
            action();
            Console.WriteLine("After actuon...");
        }
        /*static void Main(string[] args)
        {
            //Action with params
            Action<int, int> add = (x, y) => Console.WriteLine($"Sum: {x + y}");
            add(1, 2);

            //Action without params
            Action greet = () => Console.WriteLine("Hello");
            greet();

            //Using Action in a method
            PerformAction(()=> Console.WriteLine("Action performed!"));

        }*/

    }
}
