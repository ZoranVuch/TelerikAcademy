using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            string companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerPhone;
            int managerAge;

            Console.WriteLine("Enter company name:");
            companyName = Console.ReadLine();

            Console.WriteLine("Enter company address:");
            companyAddress = Console.ReadLine();

            Console.WriteLine("Enter phone number:");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter fax number:");
            faxNumber = Console.ReadLine();

            Console.WriteLine("Enter web site:");
            webSite = Console.ReadLine();

            Console.WriteLine("Enter manager first name:");
            managerFirstName = Console.ReadLine();

            Console.WriteLine("Enter manager last name:");
            managerLastName = Console.ReadLine();

            Console.WriteLine("Enter manager age:");
            managerAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter manager phone:");
            managerPhone = Console.ReadLine();

            Console.WriteLine("\n" + companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: " + faxNumber);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);

        }
    }
