using System;

namespace Learning
{
    internal class Program
    {
        class RefKeyword
        {
            public void MethodWithRef(ref int refArgument)
            {
                refArgument++;
            }
            public void MethodWithoutRef(int refArgument)
            {
                refArgument++;
            }
        }

        class OutParameter
        {
            public void MethodWithOut(out int number)
            {
                number = 44;
            }
        }

        class Container
        {
            private readonly int _capacity; //read only property

            public int FullSpace { get; set; }
            public string Color { get; set; }


            public Container(int capacity)
            {
                _capacity = capacity;
            }

            public override string ToString()
            {
                return $"Container with capacity {_capacity}, Full space: {FullSpace}, Color: {Color}";
            }

            /*void ChangeCapacity()
            {
                _capacity = 11; //error because field _capacity is read only
            }*/
        }

        //fields example
        public class CalendarEntry
        {
            public string Day;
            public static int Sunday = 7;

        }

        //method overloading
        public class Methods
        {
            public void WriteLine()
            {
                Console.WriteLine("Hello");
            }
            public void WriteLine(string value)
            {
                Console.WriteLine("Hello " + value);
            }
            public void WriteLine(bool value)
            {
                Console.WriteLine("value is " + value);
            }
        }

        //virtual 
        class Animal
        {
            public virtual string Name { get; set; }

            private int _age;
            public virtual int Age
            {
                get { return _age; }
                set => _age = value;
            }
        }

        class Dog : Animal
        {
            private string _age;

            public override string Name { get => base.Name; set => base.Name = value; }
            public override int Age { get => base.Age; set => base.Age = value; }

            public override string ToString()
            {
                return $"Dog's name is {Name}, Age is {Age}";
            }
        }

        //SEALED modifier
        class X
        {
            protected virtual void F()
            {
                Console.WriteLine("X.F");
            }
            protected virtual void F2()
            {
                Console.WriteLine("X.F2");
            }
        }
        class Y : X
        {
            sealed protected override void F()
            {
                Console.WriteLine("Y.F");
            }
            protected override void F2()
            {
                Console.WriteLine("Y.F2");
            }
        }
        class Z : Y
        {
            //ERROR because method F in class Y is sealed
            /*protected override void F()
            {
                Console.WriteLine("Z.F");
            }*/

            protected override void F2()
            {
                Console.WriteLine("Z.F2");
            }
        }

        //ABSTRACT MODIFIER
        abstract class Shape
        {
            public abstract int GetArea();
        }
        class Square : Shape
        {
            private int _side;

            public Square(int n) => _side = n;
            public override int GetArea() => _side * _side;
        }

        //INTERFACES
        interface IPoint
        {
            //property signatures
            int X { get; set; }
            int Y { get; set; }

            double Distance { get; }
        }

        class Point : IPoint
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            //property implementation
            public int X { get; set; }
            public int Y { get; set; }

            //property implementation
            public double Distance => Math.Sqrt(X * X + Y * Y);
        }

        //STRUCTS
        public struct Coords
        {
            public double X { get; }
            public double Y { get; }

            public Coords(double x, double y)
            {
                X = x;
                Y = y;

            }
            public override string ToString() => $"( {X},{Y} )";
        }

       /* static void Main(string[] args)
        {
            // ref keyword
            int number1 = 1; //first, initialize the argument, tehn pass it to the ref param
            int number2 = 1;
            var m = new RefKeyword();
            m.MethodWithRef(ref number1);
            m.MethodWithoutRef(number2);
            Console.WriteLine(number1); //returns 2
            Console.WriteLine(number2); //returns 1

            //out parameter
            int number3;
            var o = new OutParameter();
            o.MethodWithOut(out number3); //error without out parameter - use of unassigned variable
            Console.WriteLine(number3);

            *//*OutParameter o2;
            Console.WriteLine(o2); //error. unasigned object*//*

            //Container class
            int capacity = 10;
            var c1 = new Container(capacity);
            Console.WriteLine(c1);
            var p1 = new Container(capacity) { Color = "black", FullSpace = 20 };
            Console.WriteLine(p1);

            //fields
            var birthday = new CalendarEntry();
            birthday.Day = "Saturday";
            Console.WriteLine(CalendarEntry.Sunday);

            //method overloading
            var method1 = new Methods();
            method1.WriteLine();
            method1.WriteLine("my value");
            method1.WriteLine(true);

            //CONST KEYWORD
            //const int x = 0;
            *//*public const double GravitationalConstant = 6.673e-11;
            private const string ProductName = "Visual C#";*//*

            //VIRTUAL KEYWORD
            Dog dog1 = new Dog();
            dog1.Name = "Puppy";
            dog1.Age = 1;
            Console.WriteLine(dog1);

            //ABSTRCT 
            var sq = new Square(12);
            Console.WriteLine($"Area of the square = {sq.GetArea()}"); //output = 144

            //INTERFACES
            var point = new Point(1, 1);
            Console.WriteLine($"The distance of the point is: {point.Distance}");

            //STRUCTS
            var coord = new Coords(5, 5.2);
            Console.WriteLine("Coordinates are: " + coord);

        }*/
    }
}
