using System;

    class BankAccount
    {
        static void Main()
        {
            string custFirstName = "Anton";
            string custMiddleName = "Petrov";
            string custLastName = "Antonov";
            decimal accBalance = 1234.56M;
            string bankName = "Bank Sofia";
            string custIBAN = "BGSOFBANK1234567890";
            ulong creditCard1 = 123456789123;
            ulong creditCard2 = 123456789789;
            ulong creditCard3 = 123456789456;
            

            Console.WriteLine("Customer first name: " + custFirstName);
            Console.WriteLine("Customer middle name: " + custMiddleName);
            Console.WriteLine("Customer last name: " + custLastName);
            Console.WriteLine("Customer account balance: " + accBalance);
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("Customer IBAN: " + custIBAN);
            Console.WriteLine("Customer credit card #1: " + creditCard1);
            Console.WriteLine("Customer credit card #2: " + creditCard2);
            Console.WriteLine("Customer credit card #3: " + creditCard3);
        }
    }
