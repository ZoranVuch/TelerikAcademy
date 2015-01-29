using System;

    class QuadraticEquation
    {
        static void Main()
        {
            double a, b, c, discriminant, x1, x2;

            Console.WriteLine("Enter a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter c:");
            c = double.Parse(Console.ReadLine());

            discriminant = b * b - 4 * a * c;

            if (discriminant < 0) Console.WriteLine("\nThere are no real roots.");

            if (discriminant == 0) Console.WriteLine("\nThere is one real root x1=x2={0}", -b/(2*a));

            if (discriminant > 0)
                {
                    x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("\nThe roots are x1={0} and x2={1}", x1, x2);
                }
        }
    }
