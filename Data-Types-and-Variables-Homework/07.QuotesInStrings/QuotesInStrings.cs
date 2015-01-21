using System;
using System.Text;

    class QuotesInStrings
    {
        static void Main()
        {
            string stringVariable1 = "The \"use\" of quotations causes difficulties.";
            string stringVariable2 = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine("Printing string 1: " + stringVariable1);
            Console.WriteLine("Printing string 2: " + stringVariable2);
        }
    }
