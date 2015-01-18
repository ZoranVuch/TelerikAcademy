using System;


    class NumberSquareRoot
    {
        static void Main()
        {
            //Double variables defined to calcualte the square root of a number.
            double a, square;

            // Square root calcualtion for number assigned to variable "a".
            a = 12345;
            square = Math.Sqrt(a);

            Console.WriteLine("Square root of number " + a + " is: " + square);
            
            // Additional code.
            Console.WriteLine("Press any key to exit...");  // Keeps the console window open in debug mode.
            Console.ReadKey(); 
        }
    }
