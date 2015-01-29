using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            int n, i, currentNumber;
            int fN1 = 1, fN2 = 0;        // intialize the fibonacci seed values

            Console.WriteLine("Enter a integer n: ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write("{0}, ", i);
                }

                if (i == 1)
                {
                    Console.Write("{0}, ", i);
                }

                if (i > 1)
                {
                    currentNumber = fN1 + fN2;
                    Console.Write("{0}, ", currentNumber);
                    fN2 = fN1;
                    fN1 = currentNumber;
                }
            }

        }
    }
