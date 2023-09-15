#define Feature_x 
//#undef Feature_x
namespace ConditionalCompilation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //#if: This directive tests a condition and includes the code block that follows it if the condition is true.

            //#else: This directive is used in conjunction with #if. If the condition of #if is false, the code block following #else will be included.

            //#elif: Short for "else if," this directive allows you to add additional conditions to check after an #if. If the condition is true, the corresponding code block will be included.

            //#endif: This directive marks the end of a conditional block of code.
#if DEBUG
            Console.WriteLine("Debug mode is enabled.");
#elif STAGE
        Console.WriteLine("Release mode is enabled.");
#else
        Console.WriteLine("Debug mode is disabled.");
#endif

            //#define: This directive defines a symbol that can be later used with #if to check for its existence.
#if Feature_x
            Console.WriteLine("Feature X is enabled.");
#else
            Console.WriteLine("Feature X is disabled.");
#endif
            //#undef: This directive undefines a previously defined symbol.

            //#warning: This directive generates a warning message during compilation but does not stop the compilation process.
#warning 'this is a warding'

            //#error: This directive generates an error message during compilation, causing the build to fail.
#error 'this is an error'
        }
    }
}