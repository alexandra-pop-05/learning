namespace TestingExamples
{
    public class Tests
    {

        public static class TestableCode
        {
            public static int Sum(int x, int y)
            {
                return x + y;
            }

            public static int Divide(int x, int y)
            {
                return x / y;
            }
        }

        /*  [SetUp]
          public void Setup()
          {
          }*/

        [TestFixture]
        public class MathTest
        {
            [Test]
            [TestCase(1, 1, ExpectedResult = 2)]
            [TestCase(2, 2, ExpectedResult = 4)]
            public int TestSum(int x, int y)
            {
                // Act
                var result = TestableCode.Sum(x, y);

                return result;
            }

            [Test]
            [TestCase(4, 2, ExpectedResult = 2)]
            [TestCase(6, 3, ExpectedResult = 2)]
            public int TestDivide(int x, int y)
            {
                //Assert.Throws<DivideByZeroException>(() => TestableCode.Divide(x, y));
                var result = TestableCode.Divide(x, y);

                return result;
            }
        }

        /* [Test]
         public void Test1()
         {
             Assert.Pass();
         }*/
    }
}