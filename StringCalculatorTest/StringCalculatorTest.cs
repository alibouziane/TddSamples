//using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using NUnit.Framework;

namespace StringCalculatorTest
{
    [TestFixture]
    public class StringCalculatorTest
    {
        [TestCase("", 0)]
        public void WhenEmptyReturnZero(string input, int expected)
        {
            //act
            var stringCalculator = new StringCalculator();

            //arrange
            int output = stringCalculator.Evaluate(input);

            // assert

            Assert.AreEqual(output, expected);

        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]

        public void WhenSingleNumberReturnValue(string input, int expected)
        {
            var stringCalculator = new StringCalculator();
            int output = stringCalculator.Evaluate(input);
            Assert.AreEqual(output, expected);
        }

        [TestCase("1,2", 3)]
        [TestCase("3,4", 7)]
        public void WhenNumbersSeparatedWithCommaReturnSum(string input, int expected)
        {
            var stringCalculator = new StringCalculator();
            int output = stringCalculator.Evaluate(input);
            Assert.AreEqual(output, expected);
        }

        [TestCase("3\n4", 7)]
        public void WhenNumbersSeparatedWithNewLineReturnSum(string input, int expected)
        {
            var stringCalculator = new StringCalculator();
            int output = stringCalculator.Evaluate(input);
            Assert.AreEqual(output, expected);
        }

        [TestCase("3\n4", 7)]
        [TestCase("1,2,-2", 3)]
        public void WhenNumbersSeparatedWithEitherNewLineANdCommaReturnSum(string input, int expected)
        {
            var stringCalculator = new StringCalculator();
            int output = stringCalculator.Evaluate(input);
            Assert.AreEqual(output, expected);
        }

        [TestCase("1000", "Greather Than 1000 Is Not Allowed")]
        public void WhenNumberIsGreatherThan100IsIgnored(string input, string expected)
        {
            var stringCalculator = new StringCalculator();

            string outmessage = Assert.Throws<Exception>(() => stringCalculator.Evaluate(input)).Message;

            Assert.AreEqual(outmessage, expected);
        }

        
    }
}