using System;

    class SumOf5Numbers
    {
        static void Main()
        {
            // I couldn't do it myself So I've copied code from Boyan Todorov:
            //https://github.com/BoyanTodorov
            //I find the solution below as comprehensive and understood it after additioonal reading

       

            Console.WriteLine("Enter 5 numbers (given in a single line, separated by a space) :");
            string strNumbers = Console.ReadLine();
            double sum = 0;
            string[] Numbers = strNumbers.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < Numbers.Length; i++)
            {
                sum += double.Parse(Numbers[i]);
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
