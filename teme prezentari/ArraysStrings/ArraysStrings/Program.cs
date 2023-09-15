using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ArraysStrings
{
    internal class Program
    {

        class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public User(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            //GREETING USING INTERPOLATED STRING
            public string Greeting()
            {
                return $"Hello, I am {FirstName} {LastName} and I have {Age} years old!";
            }

            //GREETING USING RAW AND VERBATIM INTERPOLATED STRINGS
            public string Greeting2()
            {
                return $@"Hello, I am {FirstName} \ {LastName} and I have {Age} years old!";
            }
            public string Greeting3()
            {
                return $$"""Hello, I am {{FirstName}} \ {LastName} and I have {{Age}} years old!""";
            }

            //FORMAT STRINGS
            public string Greeting4()
            {
                string format = "Hello, I am {0} {1} and I have {2} years old.";
                return String.Format(format, FirstName, LastName, Age);
            }
            //STRING BUILDER
            public string Greeting5()
            {
                var sb = new StringBuilder();
                sb.Append($"Hello, I am {FirstName} {LastName} and I have {Age} years old!");
                sb.Replace("Hello", "Hi");
                sb.Insert(sb.Length, "!!!");
                string result = sb.ToString();
                return result;
            }
        }

        class Strings
        {
            //REVERSE ANY GIVEN STRING
            public string Reverse(string input)
            {
                var sb = new StringBuilder();

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    // Append each character to the StringBuilder
                    sb.Append(input[i]);
                }
                string result = sb.ToString();

                return result;
            }

        }

        static int[] GetOddNumbers(int[] inputArray)
        {
            int[] oddNumbers = new int[0];

            foreach (int num in inputArray)
            {
                if (num % 2 != 0) // If the number is odd
                {
                    // Resize the oddNumbers array and add the odd number to it
                    Array.Resize(ref oddNumbers, oddNumbers.Length + 1);
                    oddNumbers[oddNumbers.Length - 1] = num;
                }
            }

            return oddNumbers;
        }
        static void Main(string[] args)
        {
            User user = new User("Alexandra", "Pop", 22);
            Console.WriteLine(user.Greeting());
            Console.WriteLine(user.Greeting2());
            Console.WriteLine(user.Greeting3());
            Console.WriteLine(user.Greeting4());
            Console.WriteLine(user.Greeting5());

            //PRECISION OF A FLOAT

            double speed = 60.222555;
            string precision = String.Format("Speed is: {0:00.000}",speed);
            Console.WriteLine(precision);

            //REVERSE INPUT STRINNG
            var MyString = new Strings();
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) Console.WriteLine("String is empty!");
            else
            {
                Console.WriteLine("Reversed input: ");
                Console.WriteLine(MyString.Reverse(input));
            }

            string text = "   ";
            if (string.IsNullOrWhiteSpace(text)) Console.WriteLine("The text is empty");

            string Name = string.Empty;
            Console.WriteLine(Name);

            //SPLIT
            string greeting = $"Hello, I am Ale and I have 22 years old!";
            var textSplit = greeting.Split(new char[] { ' ' });

            foreach (var item in textSplit)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(greeting.StartsWith("Hello"));
            Console.WriteLine(greeting.EndsWith("Hello"));

            //TRIM
            string words = "     Hello, I am Ale!    ";
            Console.WriteLine($"String before trimming: {words} - done");
            Console.WriteLine($"String after trimming: {words.Trim()} - done");
            Console.WriteLine($"String after trimming at the end: {words.TrimEnd()} - done");

            Console.WriteLine($"Text to lower case: \"{words.ToLower()}\"");
            Console.WriteLine($"Text to upper case: \"{words.ToUpper()}\"");

            Console.WriteLine($"Index of \"!\" in text \"{words}\" is: {words.IndexOf("!")}");

            //REPLACE
            string s1 = "word1 word2";
            Console.WriteLine(s1);
            Console.WriteLine("After replacing: ");
            string s2 = s1.Replace("word1", "nothing");
            Console.WriteLine("s2: " + s2);
            Console.WriteLine("s1 after replacing remains the same: " + s1);

            //SUBSTRING
            string mainString = "Hello, I am Ale";
            Console.WriteLine(mainString);
            Console.WriteLine($"Substring is: {mainString.Substring(4, 6)}");

            //ARRAY
            int[] inputArray = { 1, 2, 3, 5, 10, 11, 14, 15 };
            int[] oddNumbers = GetOddNumbers(inputArray);
            Console.WriteLine("Original Array: " + string.Join(", ", inputArray));
            Console.WriteLine("Odd Numbers Array: " + string.Join(", ", oddNumbers));

        }
    }
}

