using System;

    class EmployeeData
    {
        static void Main()
        {
            string empFirstName = "Anton";
            string empLastName = "Antonov";
            sbyte empAge = 58;
            char empGender = 'm';
            ulong empPersonalId = 8306112507;
            uint empUniqueNumber = 27569999;

            Console.WriteLine("Employee first name: " + empFirstName);
            Console.WriteLine("Employee last name: " + empLastName);
            Console.WriteLine("Emplyee age: " + empAge);
            Console.WriteLine("Employee gender: " + empGender);
            Console.WriteLine("Employee personal ID: " + empPersonalId);
            Console.WriteLine("Employee unique number: " + empUniqueNumber);
        }
    }
