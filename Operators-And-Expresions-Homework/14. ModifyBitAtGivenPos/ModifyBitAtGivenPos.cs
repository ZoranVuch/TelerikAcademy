using System;

    class ModifyBitAtGivenPos
    {
        static void Main()
        {
            //definition of variables
            int number;
            int bitShift;
            int mask;
            int maskAndNumber;
            string binaryNumber;
            string binaryResult;
            int bitValue;


            //example 1
            number = 5;
            bitShift = 2;               //bitshift - we are looking for bit at position 2 (counting from 0)
            bitValue = 0;               //new bitValue to be set at bitShift position
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = ~(1 << bitShift);
            maskAndNumber = number & mask;
            binaryResult = Convert.ToString(maskAndNumber, 2).PadLeft(16, '0');

            //printing the result
            Console.WriteLine("Chnage the bit at position {0} for the number {1} ({2}) at new bit value: {3}.", bitShift, number, binaryNumber, bitValue);
            Console.WriteLine("Result is {0} ({1}).", maskAndNumber, binaryResult);

            //example 2
            number = 0;
            bitShift = 9;           //bitshift - we are looking for bit at position 9 (counting from 0)
            bitValue = 1;               //new bitValue to be set at bitShift position
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number | mask;
            binaryResult = Convert.ToString(maskAndNumber, 2).PadLeft(16, '0');

            //printing the result
            Console.WriteLine("Chnage the bit at position {0} for the number {1} ({2}) at new bit value: {3}.", bitShift, number, binaryNumber, bitValue);
            Console.WriteLine("Result is {0} ({1}).", maskAndNumber, binaryResult);

            //example 3
            number = 15;
            bitShift = 1;           //bitshift - we are looking for bit at position 1 (counting from 0)
            bitValue = 1;               //new bitValue to be set at bitShift position
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = 1 << bitShift;
            maskAndNumber = number | mask;
            binaryResult = Convert.ToString(maskAndNumber, 2).PadLeft(16, '0');

            //printing the result
            Console.WriteLine("Chnage the bit at position {0} for the number {1} ({2}) at new bit value: {3}.", bitShift, number, binaryNumber, bitValue);
            Console.WriteLine("Result is {0} ({1}).", maskAndNumber, binaryResult);

            //example 4
            number = 5343;
            bitShift = 7;       //bitshift - we are looking for bit at position 7 (counting from 0)
            bitValue = 0;               //new bitValue to be set at bitShift position
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = ~(1 << bitShift);
            maskAndNumber = number & mask;
            binaryResult = Convert.ToString(maskAndNumber, 2).PadLeft(16, '0');

            //printing the result
            Console.WriteLine("Chnage the bit at position {0} for the number {1} ({2}) at new bit value: {3}.", bitShift, number, binaryNumber, bitValue);
            Console.WriteLine("Result is {0} ({1}).", maskAndNumber, binaryResult);

            //example 5
            number = 62241;
            bitShift = 11;          //bitshift - we are looking for bit at position 11 (counting from 0)
            bitValue = 0;               //new bitValue to be set at bitShift position
            binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            mask = ~(1 << bitShift);
            maskAndNumber = number & mask;
            binaryResult = Convert.ToString(maskAndNumber, 2).PadLeft(16, '0');

            //printing the result
            Console.WriteLine("Chnage the bit at position {0} for the number {1} ({2}) at new bit value: {3}.", bitShift, number, binaryNumber, bitValue);
            Console.WriteLine("Result is {0} ({1}).", maskAndNumber, binaryResult);

        }
    }
