using System;
    class PrimeNumberCheck
    {
        static void Main()
        {
            int intNumber;       //define the variable for input of integer number

            //checks to be made:
            //The number have to be between 2 and 100. 1 is by theory not a prime number.
            // 2 and 3 are prime numbers by theory.
            // check if the number is divisable by 2 or 3. If not it is a prime number.


    //Example 1
            //Assign value to intNumber
            intNumber = 1;

            if (intNumber <= 100 && intNumber > 0)
            {
                if (intNumber == 2 || intNumber == 3) Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
                else
                    if (intNumber % 2 == 0 || intNumber % 3 == 0 || intNumber==1) Console.WriteLine("Integer {0} is not a prime.\n", intNumber);
                    else Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
            }
            else Console.WriteLine("By definition the number {0} is not a prime.\n", intNumber);

    //Example 2
            //Assign value to intNumber
            intNumber = 2;

            if (intNumber <= 100 && intNumber > 0)
            {
                if (intNumber == 2 || intNumber == 3) Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
                else
                    if (intNumber % 2 == 0 || intNumber % 3 == 0 || intNumber == 1) Console.WriteLine("Integer {0} is not a prime.\n", intNumber);
                    else Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
            }
            else Console.WriteLine("By definition the number {0} is not a prime.\n", intNumber);

    //Example 3
            //Assign value to intNumber
            intNumber = 3;

            if (intNumber <= 100 && intNumber > 0)
            {
                if (intNumber == 2 || intNumber == 3) Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
                else
                    if (intNumber % 2 == 0 || intNumber % 3 == 0 || intNumber == 1) Console.WriteLine("Integer {0} is not a prime.\n", intNumber);
                    else Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
            }
            else Console.WriteLine("By definition the number {0} is not a prime.\n", intNumber);


      //Example 4
            //Assign value to intNumber
            intNumber = 4;

            if (intNumber <= 100 && intNumber > 0)
            {
                if (intNumber == 2 || intNumber == 3) Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
                else
                    if (intNumber % 2 == 0 || intNumber % 3 == 0 || intNumber == 1) Console.WriteLine("Integer {0} is not a prime.\n", intNumber);
                    else Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
            }
            else Console.WriteLine("By definition the number {0} is not a prime.\n", intNumber);


    //Example 5
            //Assign value to intNumber
            intNumber = 9;

            if (intNumber <= 100 && intNumber > 0)
            {
                if (intNumber == 2 || intNumber == 3) Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
                else
                    if (intNumber % 2 == 0 || intNumber % 3 == 0 || intNumber == 1) Console.WriteLine("Integer {0} is not a prime.\n", intNumber);
                    else Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
            }
            else Console.WriteLine("By definition the number {0} is not a prime.\n", intNumber);


     //Example 6
            //Assign value to intNumber
            intNumber = 97;

            if (intNumber <= 100 && intNumber > 0)
            {
                if (intNumber == 2 || intNumber == 3) Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
                else
                    if (intNumber % 2 == 0 || intNumber % 3 == 0 || intNumber == 1) Console.WriteLine("Integer {0} is not a prime.\n", intNumber);
                    else Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
            }
            else Console.WriteLine("By definition the number {0} is not a prime.\n", intNumber);


     //Example 7
            //Assign value to intNumber
            intNumber = 51;

            if (intNumber <= 100 && intNumber > 0)
            {
                if (intNumber == 2 || intNumber == 3) Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
                else
                    if (intNumber % 2 == 0 || intNumber % 3 == 0 || intNumber == 1) Console.WriteLine("Integer {0} is not a prime.\n", intNumber);
                    else Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
            }
            else Console.WriteLine("By definition the number {0} is not a prime.\n", intNumber);

      //Example 8
            //Assign value to intNumber
            intNumber = -3;

            if (intNumber <= 100 && intNumber > 0)
            {
                if (intNumber == 2 || intNumber == 3) Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
                else
                    if (intNumber % 2 == 0 || intNumber % 3 == 0 || intNumber == 1) Console.WriteLine("Integer {0} is not a prime.\n", intNumber);
                    else Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
            }
            else Console.WriteLine("By definition the number {0} is not a prime.\n", intNumber);


     //Example 9
            //Assign value to intNumber
            intNumber = 0;

            if (intNumber <= 100 && intNumber > 0)
            {
                if (intNumber == 2 || intNumber == 3) Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
                else
                    if (intNumber % 2 == 0 || intNumber % 3 == 0 || intNumber == 1) Console.WriteLine("Integer {0} is not a prime.\n", intNumber);
                    else Console.WriteLine("Integer {0} is a prime number.\n", intNumber);
            }
            else Console.WriteLine("By definition the number {0} is not a prime.\n", intNumber);



        }
    }
