using System;


    class PrintNumSequence
    {
        static void Main()
        {
            int a1 = 2, a2 = 4, a3 = 6, a4 = 8, a5 = 10;
            int b1 = -3, b2 = -5, b3 = -7, b4 = -9, b5 = -11;
            Console.WriteLine("Number sequence " + a1 + ", " + b1 + ", " + a2 + ", " + b2 + ", " + a3 + ", " + b3 + ", " + a4 + ", " + b4 + ", " + a5 + ", " + b5);

            // Additional code 
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();                              //Keeps the console window open in debug mode. Alows one to read the result and exit by pressing any key.
        }
    }
