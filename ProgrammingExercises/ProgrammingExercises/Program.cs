using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ProgrammingExercises
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            Calculator doCalculator = new Calculator();
            doCalculator.CalculatorConsole();
        }
    }


}

