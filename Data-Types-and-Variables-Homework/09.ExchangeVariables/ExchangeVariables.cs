using System;

    class ExchangeVariables
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            int temp;

            // Print variables initial values;
            Console.WriteLine("Printing variables initial values:");
            Console.WriteLine("a={0}\nb={1}", a, b);
           
            //Exchange variable values using third variable.
            temp = b;
            b = a;
            a = temp;

            // Print variables exchanged values;
            Console.WriteLine("\nPrinting variables exchnaged values:");
            Console.WriteLine("a={0}\nb={1}", a, b);
        }
    }
