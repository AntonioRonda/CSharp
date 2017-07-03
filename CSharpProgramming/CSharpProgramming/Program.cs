using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace CSharpProgramming
{
    class Program
    {


        public static void ExerciseSeven()
        {


            while (TryAgain)
            {
                {
                    int[] numbers = new int[5];
                    Console.WriteLine("\n\n\tWelcome to Exercise Seven");
                    Console.WriteLine("\n\n\tWrite a program that finds the greatest of given 5 numbers");
                    for (int ctr = 0; ctr < 5; ctr++)
                    {
                        int num = ctr + 1;
                        try
                        {
                            Console.Write("\n\tEnter integer " + num + ": ");
                            numbers[ctr] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n\tWrong Input! No Value is assigned.");
                        }

                    }

                    int maximumNumber = numbers.Max();
                    Console.WriteLine("\n\tMaximum Number is = {0}", maximumNumber);

                }
            }
        }

        public static void ExerciseEight()
        {

            while (TryAgain)

            {
                Console.WriteLine("\n\n\tWelcome to Exercise Eight");
                Console.WriteLine("\n\n\tWrite a program that, depending on the user’s choice, inputs int," +
                                  "double or string variable.\n\tIf the variable is int or double, the program increases it by 1." +
                                  "\n\tIf the variable is a string, the program appends \" * \" at the end." +
                                  "\n\tPrint the result at the console. Use switch statement.");
                Console.Write("\n\n\tEnter variable type (0 - int, 1 - double, 2 string): ");
                int intVar = Int32.Parse(Console.ReadLine());
                switch (intVar)
                {
                    case 0:
                    {
                        Console.Write("\n\tEnter int variable: ");
                        intVar = Int32.Parse(Console.ReadLine());
                        intVar++;
                        Console.WriteLine("\n\tInt variable +1 = {0}", intVar);
                        break;
                    }
                    case 1:
                    {
                        Console.Write("\n\tEnter double variable: ");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("\n\tDouble variable +1 = {0}", doubleVar);
                        break;
                    }
                    case 2:
                    {
                        Console.Write("\n\tEnter string variable: ");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine("\n\tString variable +* = {0}", stringVar);
                        break;
                    }
                    default:
                        Console.WriteLine("\n\tWrong input");
                        break;
                }

            }
        }

        public static void ExerciseTen()
        {


            do
            {
                Console.WriteLine("\n\n\tWelcome to Exercise Ten");
                Console.WriteLine(
                    "\n\tWrite a program that applies bonus points to given scores in the range [1…9] by the following rules:" +
                    "\n\t\t- If the score is between 1 and 3, the program multiplies it by 10." +
                    "\n\t\t- If the score is between 4 and 6, the program multiplies it by 100." +
                    "\n\t\t- If the score is between 7 and 9, the program multiplies it by 1000." +
                    "\n\t\t- If the score is 0 or more than 9, the program prints an error message.");
                Console.Write("\n\n\tEnter points between 1 and 9: ");


                byte points = Convert.ToByte(Console.ReadLine());
                if (points >= 1 && points <= 3)
                    Console.WriteLine("\n\tPoints multiplied by 10: {0}", points * 10);
                else if (points >= 4 && points <= 6)
                    Console.WriteLine("\n\tPoints multiplied by 100: {0}", points * 100);
                else if (points >= 7 && points <= 9)
                    Console.WriteLine("\n\tPoints multiplied by 1000: {0}", points * 1000);
                else
                    Console.WriteLine("\n\tWrong Input!");


            } while (TryAgain);
        }

        public static void ExerciseEleven()
        {
            while (TryAgain)
            {


                Console.WriteLine("\n\tWelcome to Exercise Eleven\n");
                Console.WriteLine("\n\t*Write a program that converts a number in the range [0…999] to words, " +
                                  "\n\tcorresponding to the English pronunciation. Examples:" +
                                  "\n\t- 0-- > \"Zero\"" +
                                  "\n\t- 12-- > \"Twelve\"" +
                                  "\n\t- 98-- > \"Ninety Eight\"" +
                                  "\n\t- 273-- > \"Two Hundred Seventy Three\"" +
                                  "\n\t- 400-- > \"Four Hundred\"" +
                                  "\n\t- 501-- > \"Five Hundred and One\"" +
                                  "\n\t- 711-- > \"Seven Hundred and Eleven\"");
                Console.Write("\n\tEnter a number between 0 and 999: ");

                short number = Convert.ToInt16(Console.ReadLine());

                byte hundreds = (byte)(number / 100 | 0);

                byte tensAndOnes;

                if (number > 99) tensAndOnes = (byte)(number % 100);

                else tensAndOnes = (byte)(number * 1);


                byte ones = (byte)(number % 10);

                Console.Write("\n\tNumber in the range [0...999] to English words: ");

                switch (hundreds)
                {
                    case 1:
                        Console.Write("One Hundred ");
                        break;
                    case 2:
                        Console.Write("Two Hundred ");
                        break;
                    case 3:
                        Console.Write("Three Hundred ");
                        break;
                    case 4:
                        Console.Write("Four Hundred ");
                        break;
                    case 5:
                        Console.Write("Five Hundred ");
                        break;
                    case 6:
                        Console.Write("Six Hundred ");
                        break;
                    case 7:
                        Console.Write("Seven Hundred ");
                        break;
                    case 8:
                        Console.Write("Eight Hundred ");
                        break;
                    case 9:
                        Console.Write("Nine Hundred ");
                        break;
                }


                if (hundreds >= 1 && tensAndOnes >= 1) Console.Write("and ");


                if (tensAndOnes >= 20 && tensAndOnes < 30) Console.Write("Twenty");
                else if (tensAndOnes >= 30 && tensAndOnes < 40) Console.Write("Thirty");
                else if (tensAndOnes >= 40 && tensAndOnes < 50) Console.Write("Fourty");
                else if (tensAndOnes >= 50 && tensAndOnes < 60) Console.Write("Fifty");
                else if (tensAndOnes >= 60 && tensAndOnes < 70) Console.Write("Sixty");
                else if (tensAndOnes >= 70 && tensAndOnes < 80) Console.Write("Seventy");
                else if (tensAndOnes >= 80 && tensAndOnes < 90) Console.Write("Eighty");
                else if (tensAndOnes >= 90 && tensAndOnes < 100) Console.Write("Ninety");


                switch (tensAndOnes)
                {
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;
                    case 10:
                        Console.Write("Ten");
                        break;
                    case 11:
                        Console.Write("Eleven");
                        break;
                    case 12:
                        Console.Write("Twelve");
                        break;
                    case 13:
                        Console.Write("Thirteen");
                        break;
                    case 14:
                        Console.Write("Fourteen");
                        break;
                    case 15:
                        Console.Write("Fifteen");
                        break;
                    case 16:
                        Console.Write("Sixteen");
                        break;
                    case 17:
                        Console.Write("Seventeen");
                        break;
                    case 18:
                        Console.Write("Eighteen");
                        break;
                    case 19:
                        Console.Write("Nineteen");
                        break;
                }
                if (tensAndOnes > 20)
                {
                    switch (ones)
                    {
                        case 1:
                            Console.Write("-One");
                            break;
                        case 2:
                            Console.Write("-Two");
                            break;
                        case 3:
                            Console.Write("-Three");
                            break;
                        case 4:
                            Console.Write("-Four");
                            break;
                        case 5:
                            Console.Write("-Five");
                            break;
                        case 6:
                            Console.Write("-Six");
                            break;
                        case 7:
                            Console.Write("-Seven");
                            break;
                        case 8:
                            Console.Write("-Eight");
                            break;
                        case 9:
                            Console.Write("-Nine");
                            break;
                    }
                }
                if (number == 0) Console.Write("Zero");


            }
        }

        public static Boolean TryAgain
        {
            get
            {


                try
                {
                    Console.Write("\n\tDo you want to try again? Y/N: ");
                    string cont = Console.ReadLine();
                    if (cont == "Y" || cont == "y") return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }


            }
        }

        static void Main(string[] args)
        {
            while (TryAgain)

            {
                Console.Write("\n\tExercise [7]" +
                              "\n\tExercise [8]" +
                              "\n\tExercise [10]" +
                              "\n\tExercise [11]" +
                              "\n\t[C]alculator" +
                              "\n\t[X] Exit" +
                              "\n\n\tPlease choose your Exercise: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "7":
                        ExerciseSeven();
                        break;
                    case "8":
                        ExerciseEight();
                        break;
                    case "10":
                        ExerciseTen();
                        break;
                    case "11":
                        ExerciseEleven();
                        break;
                    case "C":
                    case "c":
                        Calculator calcu = new Calculator();
                        calcu.CalculatorConsole();
                        break;
                    case "X":
                    case "x": break;



                }
            }



        }

    }


}

