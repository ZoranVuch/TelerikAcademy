using System;

    class Sort3Numbers
    {
        static void Main()
        {
            double a, b, c;

            Console.WriteLine("Enter first real number a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second real number b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third real number c:");
            c = double.Parse(Console.ReadLine());

            if (a > b)
                {
                    if (b > c) Console.WriteLine("\n{0} {1} {2}", a, b, c);
                    else
                        {
                            if (a > c) Console.WriteLine("\n{0} {1} {2}", a, c, b);
                            else Console.WriteLine("\n{0} {1} {2}", c, a, b);
                        }
                }
            else
               {
                   if (a > c) Console.WriteLine("\n{0} {1} {2}", b, a, c);
                   else
                       {
                           if (b > c) Console.WriteLine("\n{0} {1} {2}", b, c, a);
                           else Console.WriteLine("\n{0} {1} {2}", c, b, a);
                       }
                
               }

        }
    }
