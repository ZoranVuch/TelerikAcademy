using System;

    class AgeAfterTen
    {
        static void Main()
        {
            DateTime curDate = DateTime.Now;  // check current date
            int myAge, ageAfterTen;           // define variables

            Console.WriteLine("I was born on 12 April 1976.");

            myAge = curDate.Year - 1976;        // estimates my age today.

            if (curDate.Month >= 4)             // comapres the months and prints the relevant message.
            {  
                Console.WriteLine("I am " + myAge + " years old now.");
            }
            else
            {
                Console.WriteLine("I will become " + myAge + " years old this year.");
            }
            
            ageAfterTen = myAge + 10;       //Estimates my age after ten years

            Console.WriteLine("After ten years I will become " + ageAfterTen + " years old.");

            // Additional code 
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();                              //Keeps the console window open in debug mode. Alows one to read the result and exit by pressing any key.

        }
    }
