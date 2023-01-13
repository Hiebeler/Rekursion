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
            int faculty5= Program.faculty(5);
            int faculty6= Program.faculty(6);
            Assert.AreEqual(faculty5, 120);
            Assert.AreEqual(faculty6, 720);
        }

        [Test]
        public void Fibonacci_FixNumber_ReturnsCorrectFibonacci()
        {
            int faculty5 = Program.Fibonacci(5);
            int faculty6 = Program.Fibonacci(10);
            Assert.AreEqual(faculty5, 5);
            Assert.AreEqual(faculty6, 55);
        }
    }
}