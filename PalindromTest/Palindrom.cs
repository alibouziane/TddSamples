using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromTest
{
    public class Palindrom
    {
        internal bool IsPalindromEvaluate(string input)
        {
            if (input==null)
            return false;

            var min = 0;
            var max = input.Length-1;

            while (min<=max)
            {
                if (input[min] != input[max])
                    return false;
                min++;
                max--;
            }
            return true;

        }

        public bool IsPalindromEvaluate2(string input)
        {
            return input != null && input.SequenceEqual(input.Reverse());
        }
    }
}
