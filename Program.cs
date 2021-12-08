using System;

namespace pracadomowa4
{
    class Program
    {
        static void ScoreTest(int percentage)
        {
            if (percentage < 30)
            {
                Console.WriteLine("1");
            }
            else if (percentage >= 30 && percentage < 50)
            {
                Console.WriteLine("2");
            }
            else if (percentage >= 50 && percentage < 70)
            {
                Console.WriteLine("3");
            }
            else if (percentage >= 70 && percentage < 90)
            {
                Console.WriteLine("4");
            }
            else if (percentage >= 90 && percentage < 98)
            {
                Console.WriteLine("5");
            }
            else if (percentage >= 98 && percentage < 101)
            {
                Console.WriteLine("6");
            }
            else
            {
                Console.WriteLine("NIEPRAWIDLOWY WYNIK");
            }
        }
        static double TaxCalculator(int income)
        {
            if(income<=85528)
            {
                return income * 0.17;
            }
            else if(income>85528 && income<=1000000)
            {
                return income * 0.32;
            }
            else if(income>1000000)
            {
                return income * 0.36;
            }
            else
            {
                return 0;
            }

        }
        static double Addiction(double a, double b)
        {

           return a+b;
        }
        static double Subtraction(double a, double b)
        {

            return a - b;
        }
        static double Multiplication(double a, double b)
        {
            return a *b;
        }
        static void Division(double a,double b)
        {
            if (b == 0)
            {
                string x = "DON'T DIVIDE BY ZERO!!!";
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(a / b);
            }

        }

        static void Main(string[] args)
        {
                ScoreTest(187);
                Console.WriteLine(TaxCalculator(22));
                Division(7, 2);
             }
        }
    }

