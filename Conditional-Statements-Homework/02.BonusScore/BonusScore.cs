using System;

    class BonusScore
    {
        static void Main()
        {
            int score;

            Console.WriteLine("Enter score in the range [1…9]");
            score = int.Parse(Console.ReadLine());

            if (score <= 0 || score > 9)
            {
                Console.WriteLine("\nInvalid score");
            }
            else
            {
                if (score >= 1 && score <= 3) Console.WriteLine("\n{0}", score * 10);
                if (score >= 4 && score <= 6) Console.WriteLine("\n{0}", score * 100);
                if (score >= 7 && score <= 9) Console.WriteLine("\n{0}", score * 1000);
            }

        }
    }
        