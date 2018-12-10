using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public static class Factorial
    {
        public static int GetFactorial(int input)
        {
            if (input <= 0)
                throw new ArgumentException("Unsupported input");
            if (input == 1)
                return 1;

            int result = 1;
            while(input > 1)
            {
                result *= input;
                input--;
            }
            return result;
        }

        public static int GetFactorialRecursive(int input)
        {
            if (input <= 0)
                throw new ArgumentException("Unsupported input");

            if (input == 1)
                return 1;
            int result = 1;
            result = GetFactorialRecursive(input - 1) * input;
            return result;
        }
    }
}
