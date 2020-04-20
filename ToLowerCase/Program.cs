using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello"; 
            Console.WriteLine(ToLowerCase(test));
            Console.ReadLine();
        }
        public static string ToLowerCase(string str)
        {
            return str.ToLower();
        }
    }
}
