using System;
    class SumOfThreeNumbers
    {
        static void Main()
        {
            double a, b, c;

                Console.WriteLine("Enter first real number:");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second real number:");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter third real number:");
                c = double.Parse(Console.ReadLine());

                Console.WriteLine("The sum of {0}, {1} and {2} is: {3}", a, b, c, a + b + c);

        }
    }
