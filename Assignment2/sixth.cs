using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class sixth
    {
        static void Main(string[] args)
        {
            int i=0,count=1;
            string str;
            Console.WriteLine("Enter the string:");
            str=Console.ReadLine();

            while(i<=str.Length-1)
            {
                if(str[i] ==' ' || str[i]=='\n' || str[i]=='\t' )
                {
                    count=count+1;
                }
                i++;
            }
            Console.WriteLine("Total Number of words in the string:" + count);
            Console.ReadLine();
        }
    }
}
