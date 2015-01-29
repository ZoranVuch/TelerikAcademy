using System;

    class IntDoubleAndString
    {
        static void Main()
        {
            int number, intNumber;
            double doubleNumber;
            string input, strString;

            Console.WriteLine("Please. choose a type:\n1 --> int\n2 --> double\n3 --> string");
            input = Console.ReadLine();

            if (Int32.TryParse(input, out number))
            {
                switch (number)
                {
                    case 1:
                            Console.WriteLine("\nPlease enter a integer: ");
                            intNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("\n{0}", intNumber + 1);
                            break;
                    case 2: 
                            Console.WriteLine("\nPlease enter a double: ");
                            doubleNumber = double.Parse(Console.ReadLine());
                            Console.WriteLine("{0}", doubleNumber + 1);
                            break;
                    case 3: 
                            Console.WriteLine("\nPlease enter a string: ");
                            strString = Console.ReadLine();
                            Console.WriteLine(strString + "*");
                            break;
                    default: Console.WriteLine("invalid choise"); break;

                }
            }
            else Console.WriteLine("invalid choise");

        }
    }
