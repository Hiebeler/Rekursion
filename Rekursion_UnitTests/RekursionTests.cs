using NUnit.Framework;

namespace Rekursion_UnitTests
{
    public class RecursionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void faculty_FixNumber_ReturnsCorrectFaculty()
        {
            int faculty5= Rekursion.Faculty(5);
            int faculty6= Rekursion.Faculty(6);
            Assert.AreEqual(faculty5, 120);
            Assert.AreEqual(faculty6, 720);
        }

        [Test]
        public void Fibonacci_FixNumber_ReturnsCorrectFibonacciNumber()
        {
            int faculty5 = Rekursion.Fibonacci(5);
            int faculty6 = Rekursion.Fibonacci(10);
            Assert.AreEqual(faculty5, 5);
            Assert.AreEqual(faculty6, 55);
        }
    }
}