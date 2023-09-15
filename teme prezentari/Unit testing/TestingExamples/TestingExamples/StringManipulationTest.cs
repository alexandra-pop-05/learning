using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExamples
{
    internal class StringManipulationTest
    {
        [TestFixture]
        internal class StringManipulation
        {
            private Strings stringManipulator;

            [SetUp]
            public void SetUp()
            {
                stringManipulator = new Strings();
            }

            [Test]
            public void TestConcatenateStrings()
            {
                string str1 = "Hello, ";
                string str2 = "world!";

                // Act
                string result = stringManipulator.ConcatenateStrings(str1, str2);

                // Asserts
                Assert.That(result, Is.EqualTo("Hello, world!")); // Pass
                Assert.That(result, Is.Not.Empty); // Pass
                Assert.That(result.Length, Is.EqualTo(5)); // Fail. It has to be 13
            }

            [Test]
            public void TestUpperCase()
            {
                string input = "hello";

                // Act
                string result = stringManipulator.UpperCase(input);

                // Assert

                Assert.That(result, Is.EqualTo("HELLO")); // Pass
                Assert.That(result, Is.Not.EqualTo("hello")); // Pass
                Assert.That(result, Is.EqualTo("hello")); // Fail
            }

            [Test]
            public void TestReverseString()
            {
                // Arrange
                string input = "abcdef";

                // Act
                string result = stringManipulator.ReverseString(input);

                // Assert
                Assert.That(result, Is.EqualTo("fedcba")); // Pass
                Assert.That(result.Length, Is.EqualTo(6)); // Pass
            }
        }

        internal class Strings
        {
            public string ConcatenateStrings(string str1, string str2)
            {
                return str1 + str2;
            }

            public string UpperCase(string input)
            {
                return input.ToUpper();
            }

            public string ReverseString(string input)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
    }
}
