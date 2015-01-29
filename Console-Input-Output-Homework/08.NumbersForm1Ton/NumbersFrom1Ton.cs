using System;

class NumbersFrom1Ton
    {
        static void Main()
        {
            
            int n, i;
            Console.WriteLine("Enter a integer n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
