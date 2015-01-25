using System;

    class ThirdDigit7
    {
        static void Main()
        {
            int number;     //definition of int variable
            double tempVariable;           //temp variable needed for the calcualtions

        //example 1
            number = 5;     //assigning value to number

            //check if the 3rd digit is 7 and print the results
            tempVariable = Math.Pow(10.00, 2.00);        //to check the third digit I put 10 on power of 3-1. If we are to check the forth digit I'll put it at 10 on 4-1 and etc.

            //print the result
            if ((number / (int)tempVariable) % 10 == 7) Console.WriteLine("Third digit of {0} (right to left) is 7\n", number);
            else Console.WriteLine("Third digit of {0} (right to left) is not 7\n", number);


         //example 2
            number = 701;     //assigning value to number

            //check if the 3rd digit is 7 and print the results
            tempVariable = Math.Pow(10.00, 2.00);        //to check the third digit I put 10 on power of 3-1. If we are to check the forth digit I'll put it at 10 on 4-1 and etc.

            //print the result
            if ((number / (int)tempVariable) % 10 == 7) Console.WriteLine("Third digit of {0} is 7\n", number);
            else Console.WriteLine("Third digit of {0} is not 7\n", number);


        //example 3
            number = 9703;     //assigning value to number

            //check if the 3rd digit is 7 and print the results
            tempVariable = Math.Pow(10.00, 2.00);        //to check the third digit I put 10 on power of 3-1. If we are to check the forth digit I'll put it at 10 on 4-1 and etc.

            //print the result
            if ((number / (int)tempVariable) % 10 == 7) Console.WriteLine("Third digit of {0} is 7\n", number);
            else Console.WriteLine("Third digit of {0} is not 7\n", number);


        //example 4
            number = 877;     //assigning value to number

            //check if the 3rd digit is 7 and print the results
            tempVariable = Math.Pow(10.00, 2.00);        //to check the third digit I put 10 on power of 3-1. If we are to check the forth digit I'll put it at 10 on 4-1 and etc.

            //print the result
            if ((number / (int)tempVariable) % 10 == 7) Console.WriteLine("Third digit of {0} is 7\n", number);
            else Console.WriteLine("Third digit of {0} is not 7\n", number);


        //example 5
            number = 777877;     //assigning value to number

            //check if the 3rd digit is 7 and print the results
            tempVariable = Math.Pow(10.00, 2.00);        //to check the third digit I put 10 on power of 3-1. If we are to check the forth digit I'll put it at 10 on 4-1 and etc.

            //print the result
            if ((number / (int)tempVariable) % 10 == 7) Console.WriteLine("Third digit of {0} is 7\n", number);
            else Console.WriteLine("Third digit of {0} is not 7\n", number);


       //example 6
            number = 9999799;     //assigning value to number

            //check if the 3rd digit is 7 and print the results
            tempVariable = Math.Pow(10.00, 2.00);        //to check the third digit I put 10 on power of 3-1. If we are to check the forth digit I'll put it at 10 on 4-1 and etc.

            //print the result
            if ((number / (int)tempVariable) % 10 == 7) Console.WriteLine("Third digit of {0} is 7\n", number);
            else Console.WriteLine("Third digit of {0} is not 7\n", number);

       //bonus example
            number = 9999799;     //assigning value to number

            //check if the 4rd digit is 7 and print the results
            tempVariable = Math.Pow(10.00, 3.00);        //to check the fourth digit I put 10 on power of 4-1. 

            //print the result
            Console.WriteLine("Bonus example. Check if the fourth digit of {0} is 7.", number);
            if ((number / (int)tempVariable) % 10 == 7) Console.WriteLine("Fourht digit of {0} is 7\n", number);
            else Console.WriteLine("Fourht digit of {0} is not 7\n", number);
          
        }
    }
