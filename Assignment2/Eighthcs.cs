using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Eighthcs
    {
        static void Main(string[] args)
        {
            bool m;
            string str1, str2;
            Console.WriteLine("Enter the string:");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the substring:");
            str2 = Console.ReadLine();
            m = str1.Contains(str2);
            if (m)
            {
                Console.WriteLine("The substring is present in the string");
            }
            else
            {
                Console.WriteLine("The substring is not present in the string");
            }
            Console.ReadLine();
        }
    }
}
