using System;
    class CirclePerimeterArea
    {
        static void Main()
        {
            double r, perimeter, area;
            Console.WriteLine("Enter circle radius:");
            r = double.Parse(Console.ReadLine());
            perimeter = 2 * Math.PI * r;
            area = Math.PI * r * r;
            Console.WriteLine("\nCircle perimeter is: {0:F2}.\nCircle area is: {1:F2}", perimeter, area);
        }
    }
