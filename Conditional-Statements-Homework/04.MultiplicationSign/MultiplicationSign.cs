using System;

    class MultiplicationSign
    {
        static void Main()
        {
            double a, b, c;
            int countNeg=0;

            Console.WriteLine("Enter first real number a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second real number b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third real number c:");
            c = double.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
                {
                    Console.WriteLine("\nProduct of a, b and c is: 0");
                }
            else
                {
                    if (a < 0) countNeg++;
                    if (b < 0) countNeg++;
                    if (c < 0) countNeg++;

                    if (countNeg % 2 == 0) Console.WriteLine("\nProduct of a, b and c is: +");
                    else Console.WriteLine("\nProduct of a, b and c is: -");

                }

        }
    }

