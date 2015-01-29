using System;

    class BiggestOf5Numbers
    {
        static void Main()
        {
            double a, b, c, d, e, biggestAB, biggestCD, biggest;

            Console.WriteLine("Enter first real number a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second real number b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third real number c:");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third real number d:");
            d = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter third real number e:");
            e = double.Parse(Console.ReadLine());


            if (a > b) biggestAB = a; 
               else biggestAB =b;

            if (c > d) biggestCD=c;
                else biggestCD =d;

            if (biggestAB > biggestCD) biggest=biggestAB;
                else biggest=biggestCD;

            if (biggest>e) Console.WriteLine("\nBiggest of a, b, c, d and e is: {0}", biggest);
                else Console.WriteLine("\nBiggest of a, b, c, d and e is: {0}", e);

        }
    }

