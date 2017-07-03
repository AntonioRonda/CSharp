using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] expression = new string[2];
            Console.WriteLine("Enter the values:");
            for (int i = 0; i < 2; i++)
            {
                expression[i] = (Console.ReadLine());
                Console.WriteLine("expression[{0}]: {1}", i,expression[i]);
            }


        }
    }
}
