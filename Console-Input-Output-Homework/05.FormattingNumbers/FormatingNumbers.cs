using System;

    class FormatingNumbers
    {
        static void Main()
        {
            int a;
            double b, c;
            string binary;

            Console.WriteLine("Enter integer a within range 0<= a <=500: ");
            a = int.Parse(Console.ReadLine());

            while (a < 0 || a > 500)
                 {
                      Console.WriteLine("Enter a valid integer within the range 0<= a <=500: ");
                      a = int.Parse(Console.ReadLine());
                 }

            binary = Convert.ToString(a, 2);
            binary = binary.PadLeft(10, '0');

            Console.WriteLine("Enter b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter c: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("\n{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, binary, b, c);


        }
    }
