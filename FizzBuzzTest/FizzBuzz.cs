using System;

namespace FizzBuzzTest
{
    public class FizzBuzz
    {
        public string Evaluate(int input)
        {

            if (input >= 100) throw (new Exception("Not Allowed beacause it is Greather Than 100"));

            if (IsDividedByThree(input) && IsDividedByFive(input)) return "FizzBuzz";
            if (IsDividedByThree(input)) return "Fizz";
            if (IsDividedByFive(input)) return "Buzz";


            return input.ToString();
        }

        private static bool IsDividedByFive(int input)
        {
            return input % 5 == 0;
        }

        private static bool IsDividedByThree(int input)
        {
            return input % 3 == 0 ;
        }
    }
}