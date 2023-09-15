#pragma warning disable CS0219 // Variable is assigned but its value is never used
namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Nullable types
            int? nullableInt = null;
            //int notNullableInt = null; // Error: Cannot convert null to 'int' because it is a non-nullable value type
            double? nullableDouble = 3.14;
            bool? nullableBool = true;

            Person person = null;

            Example1();
        }

        private static void Example1()
        {
            int? nullableInt = null;
            int result = nullableInt ?? 42; // If nullableInt is null, result will be 42; otherwise, it will be the value of nullableInt.
        }
    }

    public record Person { }
}
#pragma warning restore CS0219