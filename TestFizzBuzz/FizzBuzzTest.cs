using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oponeo.UnitTests.Implementation;

namespace TestFizzBuzz
{
    [TestClass]
    public class FizzBuzzTest
    {

        FizzBuzz fizzBuzzImplementation;

        const string fizz = "Fizz";
        const string buzz = "Buzz";
        const string fizzBuzz = "FizzBuzz";

        [TestInitialize]
        public void Initializer()
        {
            fizzBuzzImplementation = new FizzBuzz();
        }

        [TestMethod]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Expect_Throw_ArgumentOutOfRangeException(int number)
        {
            fizzBuzzImplementation.CalculateFizzBuzzForNumber(number);
            Assert.Fail("An exception should have been thrown");
        }

        [TestMethod]
        [DataRow(3)]
        public void Expect_Return_Fizz(int number)
        {
            var fizzBuzzOutput = fizzBuzzImplementation.CalculateFizzBuzzForNumber(number);
            Assert.AreEqual(fizz, fizzBuzzOutput);
        }

        [TestMethod]
        [DataRow(5)]
        public void Expect_Return_Buzz(int number)
        {
            var fizzBuzzOutput = fizzBuzzImplementation.CalculateFizzBuzzForNumber(number);
            Assert.AreEqual(buzz, fizzBuzzOutput);
        }

        [TestMethod]
        [DataRow(15)]
        [DataRow(30)]
        public void Expect_Return_FizzBuzz(int number)
        {
            var fizzBuzzOutput = fizzBuzzImplementation.CalculateFizzBuzzForNumber(number);
            Assert.AreEqual(fizzBuzz, fizzBuzzOutput);

        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(1)]
        public void Expect_Return_Integer(int number)
        {
            var fizzBuzzOutput = fizzBuzzImplementation.CalculateFizzBuzzForNumber(number);
            Assert.AreEqual(number.ToString(), fizzBuzzOutput);
        }
    }
}