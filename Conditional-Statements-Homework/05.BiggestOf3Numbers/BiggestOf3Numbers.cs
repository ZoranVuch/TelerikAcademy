using System;

    class BiggestOf3Numbers
    {
        static void Main()
        {
            double a, b, c, biggest;

            Console.WriteLine("Enter first real number a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second real number b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third real number c:");
            c = double.Parse(Console.ReadLine());

            if (a > b) biggest = a; 
               else biggest =b;

            if (c > biggest) biggest=c;


            Console.WriteLine("\nBiggest of a, b and c is: {0}", biggest);
                   

        }
    }
