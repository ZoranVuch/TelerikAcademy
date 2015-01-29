using System;

class SumOfnNumbers
{
    static void Main()
    {

        int n, i;
        double sum = 0;
        Console.WriteLine("Enter a integer n: ");
        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            Console.WriteLine("\nEnter number {0} of {1}: ", i, n);
            sum = sum + double.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nThe sum of numbers is: {0} ", sum);
    }
}