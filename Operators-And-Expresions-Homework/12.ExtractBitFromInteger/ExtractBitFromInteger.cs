using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            //definition of variables
            int number;
            int bitShift;      
            int mask;
            int maskAndNumber;
            string binaryNumber;

            //example 1
            number = 5;
            bitShift = 2;               //bitshift - we are looking for bit at position 2 (counting from 0)
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;

            //printing the result
            if ((maskAndNumber >> bitShift) == 0) Console.WriteLine("Bit at position 2 for decimal number {0} (binary representation {1}) is 0", number, binaryNumber);
            else Console.WriteLine("Bit at position 2 for decimal number {0} (binary representation {1}) is 1", number, binaryNumber);
            Console.WriteLine("\n");

            //example 2
            number = 0;
            bitShift = 9;           //bitshift - we are looking for bit at position 9 (counting from 0)
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;

            //printing the result
            if ((maskAndNumber >> bitShift) == 0) Console.WriteLine("Bit at position 9 for decimal number {0} (binary representation {1}) is 0", number, binaryNumber);
            else Console.WriteLine("Bit at position 9 for decimal number {0} (binary representation {1}) is 1", number, binaryNumber);
            Console.WriteLine("\n");

            //example 3
            number = 15;
            bitShift = 1;           //bitshift - we are looking for bit at position 1 (counting from 0)
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;

            //printing the result
            if ((maskAndNumber >> bitShift) == 0) Console.WriteLine("Bit at position 1 for decimal number {0} (binary representation {1}) is 0", number, binaryNumber);
            else Console.WriteLine("Bit at position 1 for decimal number {0} (binary representation {1}) is 1", number, binaryNumber);
            Console.WriteLine("\n");

            //example 4
            number = 5343;
            bitShift = 7;       //bitshift - we are looking for bit at position 7 (counting from 0)
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;

            //printing the result
            if ((maskAndNumber >> bitShift) == 0) Console.WriteLine("Bit at position 7 for decimal number {0} (binary representation {1}) is 0", number, binaryNumber);
            else Console.WriteLine("Bit at position 7 for decimal number {0} (binary representation {1}) is 1", number, binaryNumber);
            Console.WriteLine("\n");

            //example 5
            number = 62241;
            bitShift = 11;          //bitshift - we are looking for bit at position 11 (counting from 0)
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;

            //printing the result
            if ((maskAndNumber >> bitShift) == 0) Console.WriteLine("Bit at position 11 for decimal number {0} (binary representation {1}) is 0", number, binaryNumber);
            else Console.WriteLine("Bit at position 11 for decimal number {0} (binary representation {1}) is 1", number, binaryNumber);
            Console.WriteLine("\n");


        }
    }
