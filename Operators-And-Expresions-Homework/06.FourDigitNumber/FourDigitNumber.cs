using System;
    class FourDigitNumber
    {
        static void Main()
        {
            int number;          // defines variable for the four digit number
            int sum;             // defines variable for the sum of the digits

            int numberPos1;     //definition of int variable for digit at position 1 (left to right)
            int numberPos2;     //definition of int variable for digit at position 2 (left to right)
            int numberPos3;     //definition of int variable for digit at position 3 (left to right)
            int numberPos4;     //definition of int variable for digit at position 4 (left to right)

      //example 1
            number = 2011;     //assigning value to number

            numberPos4 = number % 10;          //  check the last digit form left to right
            numberPos3 = (number/10) % 10;      //check the the 3rd digit from left to right
            numberPos2 = (number/100) % 10;     //check the second digit from left to right
            numberPos1 = (number/1000) % 10;    // check the first digit left to right

            sum = numberPos1 + numberPos2 + numberPos3 + numberPos4;    //calculates the sum of digits

            //print the results
            Console.WriteLine("The sum of the digits in number {0} is {1}", number, sum);
            Console.WriteLine("The number {0} in reversed order is {1}{2}{3}{4}", number, numberPos4, numberPos3, numberPos2, numberPos1);
            Console.WriteLine("Put the last digit in front for number {0} will be {1}{2}{3}{4}", number, numberPos4, numberPos1, numberPos2, numberPos3);
            Console.WriteLine("Exchnage the second and the third digits for number {0} will be {1}{2}{3}{4}\n", number, numberPos1, numberPos3, numberPos2, numberPos4);


     //example 2
            number = 3333;     //assigning value to number

            numberPos4 = number % 10;          //  check the last digit form left to right
            numberPos3 = (number / 10) % 10;      //check the the 3rd digit from left to right
            numberPos2 = (number / 100) % 10;     //check the second digit from left to right
            numberPos1 = (number / 1000) % 10;    // check the first digit left to right

            sum = numberPos1 + numberPos2 + numberPos3 + numberPos4;    //calculates the sum of digits

            //print the results
            Console.WriteLine("The sum of the digits in number {0} is {1}", number, sum);
            Console.WriteLine("The number {0} in reversed order is {1}{2}{3}{4}", number, numberPos4, numberPos3, numberPos2, numberPos1);
            Console.WriteLine("Put the last digit in front for number {0} will be {1}{2}{3}{4}", number, numberPos4, numberPos1, numberPos2, numberPos3);
            Console.WriteLine("Exchnage the second and the third digits for number {0} will be {1}{2}{3}{4}\n", number, numberPos1, numberPos3, numberPos2, numberPos4);


    //example 3
            number = 9876;     //assigning value to number

            numberPos4 = number % 10;          //  check the last digit form left to right
            numberPos3 = (number / 10) % 10;      //check the the 3rd digit from left to right
            numberPos2 = (number / 100) % 10;     //check the second digit from left to right
            numberPos1 = (number / 1000) % 10;    // check the first digit left to right

            sum = numberPos1 + numberPos2 + numberPos3 + numberPos4;    //calculates the sum of digits

            //print the results
            Console.WriteLine("The sum of the digits in number {0} is {1}", number, sum);
            Console.WriteLine("The number {0} in reversed order is {1}{2}{3}{4}", number, numberPos4, numberPos3, numberPos2, numberPos1);
            Console.WriteLine("Put the last digit in front for number {0} will be {1}{2}{3}{4}", number, numberPos4, numberPos1, numberPos2, numberPos3);
            Console.WriteLine("Exchnage the second and the third digits for number {0} will be {1}{2}{3}{4}\n", number, numberPos1, numberPos3, numberPos2, numberPos4);
        }
    }
