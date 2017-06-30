using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Calculator
    {
        private string _dispOp = "";

        public void CalculatorConsole()
        {
            string cont = "Y";
            do
            {
                Console.WriteLine("\n\tWelcome to the Calculator!");
                double operand1 = GetInput1();
                double operand2 = GetInput2();
                int stringOperation = GetOperator();
                double result = GetResults(stringOperation, operand1, operand2);
                Console.WriteLine("\n\tResult of {0} {1} {2} = {3}", operand1, _dispOp, operand2, result);
                Console.Write("\n\tDo you want to try again? Y/N: ");
                cont = Console.ReadLine();
            } while (cont == "Y" || cont == "y");
        }

        private double GetInput1()
        {

            Console.Write("\n\n\tType you first number: ");
            string stringFirstNumber = Console.ReadLine();
            double firstNumber = Convert.ToDouble(stringFirstNumber);
            return firstNumber;
        }

        private double GetInput2()
        {
            Console.Write("\n\tType you second number: ");
            string stringSecondNumber = Console.ReadLine();
            double secondNumber = Convert.ToDouble(stringSecondNumber);
            return secondNumber;
        }

        private int GetOperator()
        {
            int operation = 0;

            //Ask user operation to use
            Console.Write("\n\t[+] add" +
                          "\n\t[-] subtract" +
                          "\n\t[*] multiply" +
                          "\n\t[/] divide" +
                          "\n\t[^] power of" +
                          "\n\t[%] modulo" +
                          "\n\tEnter the operation:");
            string stringOperation = Console.ReadLine();

            // Convert string choice to integral
            if (stringOperation == "+" || stringOperation == "add")
            {
                operation = 1;
                _dispOp = "+";
            }
            else if (stringOperation == "-" || stringOperation == "subtract")
            {
                operation = 2;
                _dispOp = "-";
            }
            else if (stringOperation == "*" || stringOperation == "multiply")
            {
                operation = 3;
                _dispOp = "*";
            }
            else if (stringOperation == "/" || stringOperation == "divide")
            {
                operation = 4;
                _dispOp = "/";
            }
            else if (stringOperation == "^" || stringOperation == "power of")
            {
                operation = 5;
                _dispOp = "^";
            }
            else if (stringOperation == "%" || stringOperation == "modulo")
            {
                operation = 6;
                _dispOp = "%";
            }

            return operation;
        }

        private double GetResults(int operation, double firstNumber, double secondNumber)
        {


            double result = 0;

            switch (operation)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    break;

                case 2:
                    result = firstNumber - secondNumber;
                    break;

                case 3:
                    result = firstNumber * secondNumber;
                    break;

                case 4:
                    result = firstNumber / secondNumber;
                    break;

                case 5:
                    result = Math.Pow(firstNumber, secondNumber);
                    break;

                case 6:
                    result = firstNumber % secondNumber;
                    break;

                default: Console.WriteLine("\n\tWrong Input!"); break;
            }


            return result;

        }
    }
}
