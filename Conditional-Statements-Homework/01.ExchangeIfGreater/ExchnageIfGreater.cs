using System;

    class ExchnageIfGreater
    {
        static void Main()
        {
            double a, b;

            Console.WriteLine("Enter number a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number b:");
            b = double.Parse(Console.ReadLine());

            if (a > b)  Console.WriteLine("\n{0} {1}", b, a);
            else Console.WriteLine("\n{0} {1}", a, b);
        }
    }
