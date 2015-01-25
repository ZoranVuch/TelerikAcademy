using System;

    class CheckBitAtPosition
    {
        static void Main()
        {
            //definition of variables
            int number;
            int bitShift;
            int mask;
            int maskAndNumber;
            string binaryNumber;
            bool result;

            //example 1
            number = 5;
            bitShift = 2;               //bitshift - we are looking for bit at position 2 (counting from 0)
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;
            result = (maskAndNumber >> bitShift) == 1;

            //printing the result
            Console.WriteLine("Is the bit at position {0} for the number {1} ({2}) 1? Result:{3}", bitShift, number, binaryNumber, result);

            //example 2
            number = 0;
            bitShift = 9;           //bitshift - we are looking for bit at position 9 (counting from 0)
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;
            result = (maskAndNumber >> bitShift) == 1;

            //printing the result
            Console.WriteLine("Is the bit at position {0} for the number {1} ({2}) 1? Result:{3}", bitShift, number, binaryNumber, result);

            //example 3
            number = 15;
            bitShift = 1;           //bitshift - we are looking for bit at position 1 (counting from 0)
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;
            result = (maskAndNumber >> bitShift) == 1;

            //printing the result
            Console.WriteLine("Is the bit at position {0} for the number {1} ({2}) 1? Result:{3}", bitShift, number, binaryNumber, result);

            //example 4
            number = 5343;
            bitShift = 7;       //bitshift - we are looking for bit at position 7 (counting from 0)
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;
            result = (maskAndNumber >> bitShift) == 1;

            //printing the result
            Console.WriteLine("Is the bit at position {0} for the number {1} ({2}) 1? Result:{3}", bitShift, number, binaryNumber, result);

            //example 5
            number = 62241;
            bitShift = 11;          //bitshift - we are looking for bit at position 11 (counting from 0)
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number & mask;
            result = (maskAndNumber >> bitShift) == 1;

            //printing the result
            Console.WriteLine("Is the bit at position {0} for the number {1} ({2}) 1? Result:{3}", bitShift, number, binaryNumber, result);

        }
    }
