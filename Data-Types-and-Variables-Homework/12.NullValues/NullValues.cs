using System;

    class NullValues
    {
        static void Main()
        {
            int? intVariable = null;
            double? doubleVariable = null;

            Console.WriteLine("Int variable with null value: " + intVariable);
            Console.WriteLine("Double variable with null value: " + doubleVariable);

            intVariable = 12;
            doubleVariable = 112.45;
            Console.WriteLine("\nInt variable with real value: " + intVariable);
            Console.WriteLine("Double variable with real value: " + doubleVariable);

        }
    }
