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
            for (int j = 1; j <= 100; j++ )
            {
                for (int k = 1; k <= 100; k++)
                {
                    Console.WriteLine("" + j + " * " + k + " = " + (j * k));
                }
            }

            Console.ReadLine();
        }
    }
}
