using System;
using System.CodeDom;

namespace Learning
{
    internal class Partial
    {
        //EXAMPLE 1 OF PARTIAL CLASSES
        public interface IRotate
        {
             void Rotate();
        }
        public interface IWheather
        {

        }

        public class Planet
        {

        }

        partial class Earth : Planet, IRotate
        {
            public void Rotate()
            {
                throw new NotImplementedException();
            }
        }

        partial class Earth : IWheather
        {

        }

        //equivalent to
        //class Earth : Planet, IRotate, IWheather { }


        //EXAMPLE 2 OF PARTIAL CLASSES
        public partial class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public partial class Person
        {

            public string GetFullName()
            {
                return $"{FirstName} {LastName}";
            }


            public void Greet()
            {
                Console.WriteLine($"Hello, {GetFullName()}!");
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                Person person = new Person
                {
                    FirstName = "Ale",
                    LastName = "Pop"
                };

                Console.WriteLine(person.GetFullName()); // Output: "Ale Pop"
                person.Greet(); // Output: "Hello, ALe Pop!"
            }*/
        }

    }
}
