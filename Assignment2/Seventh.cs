using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Seventh
    {
        static void Main(string[] args)
        {
            int i = 0, vowel= 0;
            string str;
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();
            for(i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i]=='U')
                {
                    vowel++;
                }
            }
            Console.WriteLine("The total Number of vowels in the string:{0}",vowel);
            Console.ReadLine();
        }
    }
}
