using System;

    class ExtractBit3
    {
        static void Main()
        {
            //definition of variables
            int number;
            int bitShift= 3;      //bitshift - we are looking for bit at position 3 (counting from 0)
            int mask;
            int maskAndNumber;
            string binaryNumber;

      //example 1
            number = 5;
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;
            
            //printing the result
            if ((maskAndNumber >> bitShift) == 0) Console.WriteLine("Bit at position 3 for decimal number {0} (binary representation {1}) is 0", number, binaryNumber);
            else Console.WriteLine("Bit at position 3 for decimal number {0} (binary representation {1}) is 1", number, binaryNumber);
            Console.WriteLine("\n");

       //example 2
            number = 0;
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;

            //printing the result
            if ((maskAndNumber >> bitShift) == 0) Console.WriteLine("Bit at position 3 for decimal number {0} (binary representation {1}) is 0", number, binaryNumber);
            else Console.WriteLine("Bit at position 3 for decimal number {0} (binary representation {1}) is 1", number, binaryNumber);
            Console.WriteLine("\n");

       //example 3
            number = 15;
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;

            //printing the result
            if ((maskAndNumber >> bitShift) == 0) Console.WriteLine("Bit at position 3 for decimal number {0} (binary representation {1}) is 0", number, binaryNumber);
            else Console.WriteLine("Bit at position 3 for decimal number {0} (binary representation {1}) is 1", number, binaryNumber);
            Console.WriteLine("\n");

      //example 4
            number = 5343;
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;

            //printing the result
            if ((maskAndNumber >> bitShift) == 0) Console.WriteLine("Bit at position 3 for decimal number {0} (binary representation {1}) is 0", number, binaryNumber);
            else Console.WriteLine("Bit at position 3 for decimal number {0} (binary representation {1}) is 1", number, binaryNumber);
            Console.WriteLine("\n");

       //example 5
            number = 62241;
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;

            //printing the result
            if ((maskAndNumber >> bitShift) == 0) Console.WriteLine("Bit at position 3 for decimal number {0} (binary representation {1}) is 0", number, binaryNumber);
            else Console.WriteLine("Bit at position 3 for decimal number {0} (binary representation {1}) is 1", number, binaryNumber);
            Console.WriteLine("\n");

        }
    }
