using System;

    class NumberComparer
    {
        static void Main()
        {
            double a, b;
            bool compare;

            Console.WriteLine("Enter number a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number b:");
            b = double.Parse(Console.ReadLine());

            compare = a > b;
            Console.WriteLine("\nGreater between a={0} and b={1} is {2}", a, b, compare ? a : b);
        }
    }
