using System;

    class StringsAndObjects
    {
        static void Main()
        {
            string stringVariable1 = "Hello";
            string stringVariable2 = "World";

            object objectVariable = stringVariable1 + " " + stringVariable2;

            string stringVariable3 = (string)objectVariable;

            Console.WriteLine("Printing the object variable:  " + objectVariable);
            Console.WriteLine("Printing the third string variable:  " + stringVariable3);

        }
    }
