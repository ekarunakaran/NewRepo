using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Test1");
        }

        [Test]
        public void Test1()
        {
            System.Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}