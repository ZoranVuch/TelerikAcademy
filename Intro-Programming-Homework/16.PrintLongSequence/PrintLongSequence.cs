using System;

    class PrintLongSequence
    {
        static void Main()
        {
            int i, a, b;
            a = 2;
            b= -3;

            for (i = 0; i < 499; i++)
            {
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a + 2;
            b = b -2;

            }
        }
    }
