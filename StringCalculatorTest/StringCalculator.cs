using System;
using System.Linq;
using NUnit.Framework;

namespace StringCalculatorTest
{
    public class StringCalculator
    {
        public int Evaluate(string input)
        {
            if (string.IsNullOrEmpty(input)) 
                return 0;
            else
            {
                var numbers = input.Split(new []{',','\n'});
                if (numbers.Any(n => int.Parse(n) >= 1000)) 
                    throw (new Exception("Greather Than 1000 Is Not Allowed"));

                return numbers.Where(n=>int.Parse(n)>=0).Sum(n=>int.Parse(n));

            }
        }
    }
}