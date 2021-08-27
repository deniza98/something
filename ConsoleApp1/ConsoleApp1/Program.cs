using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu();
        }
        private static void mainMenu()
        {

            bool correction = false;
            ConsoleKey a;
            while (!correction)
            {
                Console.WriteLine("Welcome to Math Game!");
                Console.WriteLine("1-) Factorial Calculation");
                Console.WriteLine("2-) Minimum Number Calculation");
                Console.WriteLine("3-) Maximum Number Calculation");
                Console.WriteLine("4-) Sorting Calculation");
                Console.WriteLine("Choose one of them or \"q\" for quit");
                a = Console.ReadKey(true).Key;
                switch (a)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("You pressed 1");

                        factorialMenu();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("You pressed 2");

                        minMenu();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("You pressed 3");

                        maxMenu();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("You pressed 4");

                        sortMenu();
                        break;
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("You pressed 1");

                        factorialMenu();
                        break;
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("You pressed 2");

                        minMenu();
                        break;
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("You pressed 3");

                        maxMenu();
                        break;
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("You pressed 4");

                        sortMenu();
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("You pressed q");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You pressed Wrong. Try Again...");

                        break;


                }
            }
        }
        static void factorialMenu()
        {
            Console.WriteLine("Welcome to Factorial Calculator");

            bool correctNumber = false;
            int facNum;
            while (!correctNumber)
            {
                Console.WriteLine("Type a natural number you want to know its factorial then press ENTER.");
                try
                {
                    facNum = Convert.ToInt32(Console.ReadLine());
                    int a = Maths.factorial(facNum);
                    Console.WriteLine(a);
                    correctNumber = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("You entered wrong input.");
                    Console.WriteLine(ex.Message);

                }
            }

            ConsoleKey ans;
            bool correctInp = false;
            while (!correctInp)
            {
                Console.WriteLine("Do you wanna calculate more ?");
                Console.WriteLine("\"Y\" for YES, \"M\" for Main Menu");
                ans = Console.ReadKey(true).Key;
                if (ans == ConsoleKey.Y)
                {
                    factorialMenu();
                    break;

                }
                else if (ans == ConsoleKey.M)
                {
                    mainMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Input is wrong. Try Again");
                }
            }




        }
        static void minMenu()
        {
            Console.WriteLine("Welcome to minimum calculator.");
            Console.WriteLine("Type two numbers to learn which is minimum than other.");
            bool b1 = false;
            bool b2 = false;
            int n1 = 0;
            int n2;
            while (!b1)
            {
                Console.WriteLine("Type first number then press ENTER.");
                try
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                    b1 = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You entered wrong input.");
                    Console.WriteLine(ex.Message);
                }
            }
            while (!b2)
            {
                Console.WriteLine("Type second number then press ENTER.");
                try
                {
                    n2 = Convert.ToInt32(Console.ReadLine());
                    int result = Maths.min(n1, n2);
                    Console.WriteLine("The result is " + result);
                    b2 = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You entered wrong input.");
                    Console.WriteLine(ex.Message);
                }
            }
            ConsoleKey ans;
            bool correctInp = false;
            while (!correctInp)
            {
                Console.WriteLine("Do you wanna calculate more ?");
                Console.WriteLine("\"Y\" for YES, \"M\" for Main Menu");
                ans = Console.ReadKey(true).Key;
                if (ans == ConsoleKey.Y)
                {
                    minMenu();
                    break;
                }
                else if (ans == ConsoleKey.M)
                {
                    mainMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Input is wrong. Try Again");
                }
            }
        }
        static void maxMenu()
        {
            Console.WriteLine("Welcome to maximum calculator.");
            Console.WriteLine("Type two numbers to learn which is maximum than other.");
            bool b1 = false;
            bool b2 = false;
            int n1 = 0;
            int n2;
            while (!b1)
            {
                Console.WriteLine("Type first number then press ENTER.");
                try
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                    b1 = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You entered wrong input.");
                    Console.WriteLine(ex.Message);
                }
            }
            while (!b2)
            {
                Console.WriteLine("Type second number then press ENTER.");
                try
                {
                    n2 = Convert.ToInt32(Console.ReadLine());
                    int result2 = Maths.max(n1, n2);
                    Console.WriteLine("The result is " + result2);
                    b2 = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You entered wrong input.");
                    Console.WriteLine(ex.Message);
                }
            }
            ConsoleKey ans;
            bool correctInp = false;
            while (!correctInp)
            {
                Console.WriteLine("Do you wanna calculate more ?");
                Console.WriteLine("\"Y\" for YES, \"M\" for Main Menu");
                ans = Console.ReadKey(true).Key;
                if (ans == ConsoleKey.Y)
                {
                    maxMenu();
                    break;
                }
                else if (ans == ConsoleKey.M)
                {
                    mainMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Input is wrong. Try Again");
                }
            }
        }
        static void sortMenu()
        {
            Console.WriteLine("Welcome to sorting ascendingly!");

            int size = 0;
            bool correc1 = false;

            while (!correc1)
            {
                Console.WriteLine("Type your array size for sorting then press ENTER");
                try
                {
                    size = Convert.ToInt32(Console.ReadLine());
                    correc1 = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Input is wrong. Try Again");
                    Console.WriteLine(ex.Message);
                }

            }
            int[] arrayS = new int[size];
            for (int i = 0; i < size; i++)
            {
                bool correc2 = false;
                int num = 0;
                while (!correc2)
                {
                    Console.WriteLine("Type " + (i + 1) + ". number.");
                    try
                    {
                        num = Convert.ToInt32(Console.ReadLine());
                        correc2 = true;
                        arrayS[i] = num;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Input is not an integer.");
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            Console.WriteLine("You typed : ");

            Console.WriteLine(string.Join(" ", arrayS));


            Maths.sort(arrayS);

            Console.WriteLine("New order is : ");

            Console.WriteLine(string.Join(" ", Maths.sort(arrayS)));



            ConsoleKey ans;
            bool correctInp = false;
            while (!correctInp)
            {
                Console.WriteLine("Do you wanna calculate more ?");
                Console.WriteLine("\"Y\" for YES, \"M\" for Main Menu");
                ans = Console.ReadKey(true).Key;
                if (ans == ConsoleKey.Y)
                {
                    sortMenu();
                    break;

                }
                else if (ans == ConsoleKey.M)
                {
                    mainMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Input is wrong. Try Again");
                }

            }

        }

    }

    static class Maths
    {

        public static int factorial(int a)
        {
            int multiplier = 1;
            if (a >= 0)
            {
                while (a >= 1)
                {

                    multiplier = multiplier * a;
                    a--;

                }
                return multiplier;
            }
            else
            {
                Console.WriteLine("You need to enter positive integer");
                return 0;

            }

        }
        public static int min(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else if (b > a)
            {
                return a;
            }
            else
            {
                Console.WriteLine("These are equal");
                return b;
            }
        }
        public static int max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a)
            {
                return b;
            }
            else
            {

                Console.WriteLine("These are equal");
                return a;

            }
        }
        public static int[] sort(int[] a)
        {
            bool b = true;
            int temp;

            while (b)
            {
                b = false;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        b = true;
                        temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;


                    }
                }

            }
            return a;


        }
    }
}
