using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTest

    {
        [TestCase(1, "1")]

        public void WhenOneReturnOne(int input, string expected)
        {
            var fuzzBuzz = new FizzBuzz();

            var output = fuzzBuzz.Evaluate(input);

            Assert.AreEqual(output, expected);
        }


        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        public void WhenMultipleThreeReturnFizz(int input, string expected)
        {
            var fizbuzz = new FizzBuzz();
            var output = fizbuzz.Evaluate(input);
            Assert.AreEqual(output, expected);
        }

        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]

        public void WHenMultipleFiveReturnBuzz(int input, string expected)
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.Evaluate(input);
            Assert.AreEqual(output, expected);
        }


        [TestCase(15, "FizzBuzz")]
        public void WHenMultipleFiveAndMultipleThreeThanReturnFizzBuzz(int input, string expected)
        {
            var fizBuzz = new FizzBuzz();
            var output = fizBuzz.Evaluate(input);
            Assert.AreEqual(output,expected);

        }

        [TestCase(100, "Not Allowed beacause it is Greather Than 100")]
        public void WhenGreatherThan100ReturnException(int input, string expected)
        {
            var fizzBuzz=new FizzBuzz();
            var output = Assert.Throws<Exception>(() => fizzBuzz.Evaluate(input)).Message;
            Assert.AreEqual(output,expected );

        }
    }
}
