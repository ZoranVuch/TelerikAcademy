using System;

    class PrintASCII
    {
        static void Main()
        {
            for (int i = 0; i <= 255; i++)
            {
                if (i==0 || i==7 || i==8 || i==9 || i==10 || i==13 || i==32 || i==160 )  // c# special character
                {
                    Console.WriteLine("This is a C# special character and I have to learn how to print it.");
                }
                else
                {
                    Console.WriteLine("{0} = {1}", i, (char)i);
                }
                

            }
        }
    }
