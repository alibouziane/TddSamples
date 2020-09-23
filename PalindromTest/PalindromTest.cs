using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromTest
{
    [TestFixture]
    public class PalindromTest
    {
        [TestCase("civic",true)]
        [TestCase("loto", false)]
        [TestCase("lol", true)]


        public void IspalindroTest(string input,bool expected)

        {
            var palindrom = new Palindrom();

            var output = palindrom.IsPalindromEvaluate(input);

            Assert.AreEqual(output,expected );

        }
    }
}
