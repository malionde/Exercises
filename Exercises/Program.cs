using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseInteger(-154));
            Console.ReadLine();
        }
        public static int ReverseInteger(int x)
        {
            int result = 0;
            if (x > 0)
            {
                try
                {
                    while (x != 0)
                    {
                        result = checked(result * 10 + x % 10);
                        x /= 10;
                    }
                }
                catch (OverflowException)
                {
                    return 0;
                }
                return result;
            }
            else
            {
                try
                {
                    x = x * -1;
                    while (x != 0)
                    {
                        result = checked(result * 10 + x % 10);
                        x /= 10;
                    }
                }
                catch (OverflowException)
                {
                    return 0;
                }
                return result * -1;
            }
        }
    }
}


//Given a 32-bit signed integer, reverse digits of an integer.

//Example 1:

//Input: 123
//Output: 321
//Example 2:

//Input: -123
//Output: -321
//Example 3:

//Input: 120
//Output: 21
//Note:
//Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.