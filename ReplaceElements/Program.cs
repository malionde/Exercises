using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 17, 18, 5, 4, 6, 1 };

            Console.WriteLine(ReplaceElements(nums));
            Console.ReadLine();
        }
        public static int[] ReplaceElements(int[] arr)
        {
            //last element is -1
            var biggest = -1;

            for (var i = arr.Length - 1; i >= 0; i--)
            {
                var t = arr[i];
                arr[i] = biggest;
                if (t > biggest)
                    biggest = t;
            }
            return arr;
        }
    }
}

//Given an array arr, replace every element in that array with the greatest element among the elements to its right, and replace the last element with -1.

//After doing so, return the array.



//Example 1:

//Input: arr = [17, 18, 5, 4, 6, 1]
//Output: [18,6,6,6,1,-1]


//Constraints:

//1 <= arr.length <= 10^4
//1 <= arr[i] <= 10^5