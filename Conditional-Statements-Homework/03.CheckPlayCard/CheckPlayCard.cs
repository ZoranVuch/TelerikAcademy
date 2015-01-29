using System;

    class CheckPlayCard
    {
        static void Main()
        {
            string cardSign;
            int cardNumber;

            Console.WriteLine("Enter card sign");
            cardSign= Console.ReadLine();
            Int32.TryParse(cardSign, out cardNumber);

            if ((cardNumber>=2 && cardNumber<=10) || cardSign == "J" || cardSign == "Q" || cardSign == "K" || cardSign == "A")
            {
                Console.WriteLine("\nIs it a valid card sign? Yes");
            }
            else
            {
                Console.WriteLine("\nIs it a valid card sign? No");
            }
        }
    }