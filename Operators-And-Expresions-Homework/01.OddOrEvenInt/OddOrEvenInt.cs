using System;

class OddOrEvenInt
{
    static void Main()
    {
        int intNumber;

        for (intNumber = 3; intNumber > -3; intNumber--) //Assign integer values to intNumber from 3 to -2
        {
            //Check if intNumber is odd or even and print the result.
            if (Math.Abs(intNumber % 2) == 1) Console.WriteLine("Integer n={0} is odd\n", intNumber);
            else Console.WriteLine("Integer n={0} is even\n", intNumber);
        }
    }
}