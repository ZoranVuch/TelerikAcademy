using System;
    class PointInCircle
    {
        static void Main()
        {
            //Define variables for coordinates x and y.
            double x, y;

            //define temp variable for the calculations
            double temp; 

            //Define temp string
            string stringVariable = @"K({0, 0}, 2)";

            //Circle with R=2 and center {0,0} will have all points in for 
            // which it is true that X^2 + Y^2 <= R^2


        //Exmaple 1
            //Assign values to x and y.
            x = 0;
            y = 1;

            //make the calculation if the point is inside the circle
            temp = Math.Pow(x,2.0) + Math.Pow(y, 2.0);
            if (temp <= Math.Pow(2.0, 2.0)) Console.WriteLine("Point ({0},{1}) is within the circle {2}.\n", x, y , stringVariable);
            else Console.WriteLine("Point ({0},{1}) is outside the circle {2}.\n", x, y, stringVariable);

       //Exmaple 2
            //Assign values to x and y.
            x = -2;
            y = 0;

            //make the calculation if the point is inside the circle
            temp = Math.Pow(x, 2.0) + Math.Pow(y, 2.0);
            if (temp <= Math.Pow(2.0, 2.0)) Console.WriteLine("Point ({0},{1}) is within the circle {2}.\n", x, y, stringVariable);
            else Console.WriteLine("Point ({0},{1}) is outside the circle {2}.\n", x, y, stringVariable);

       //Exmaple 3
            //Assign values to x and y.
            x = -1;
            y = 2;

            //make the calculation if the point is inside the circle
            temp = Math.Pow(x, 2.0) + Math.Pow(y, 2.0);
            if (temp <= Math.Pow(2.0, 2.0)) Console.WriteLine("Point ({0},{1}) is within the circle {2}.\n", x, y, stringVariable);
            else Console.WriteLine("Point ({0},{1}) is outside the circle {2}.\n", x, y, stringVariable);

       //Exmaple 4
            //Assign values to x and y.
            x = 1.5;
            y = -1;

            //make the calculation if the point is inside the circle
            temp = Math.Pow(x, 2.0) + Math.Pow(y, 2.0);
            if (temp <= Math.Pow(2.0, 2.0)) Console.WriteLine("Point ({0},{1}) is within the circle {2}.\n", x, y, stringVariable);
            else Console.WriteLine("Point ({0},{1}) is outside the circle {2}.\n", x, y, stringVariable);

       //Exmaple 5
            //Assign values to x and y.
            x = -1.5;
            y = -1.5;

            //make the calculation if the point is inside the circle
            temp = Math.Pow(x, 2.0) + Math.Pow(y, 2.0);
            if (temp <= Math.Pow(2.0, 2.0)) Console.WriteLine("Point ({0},{1}) is within the circle {2}.\n", x, y, stringVariable);
            else Console.WriteLine("Point ({0},{1}) is outside the circle {2}.\n", x, y, stringVariable);

       //Exmaple 6
            //Assign values to x and y.
            x = 100;
            y = -30;

            //make the calculation if the point is inside the circle
            temp = Math.Pow(x, 2.0) + Math.Pow(y, 2.0);
            if (temp <= Math.Pow(2.0, 2.0)) Console.WriteLine("Point ({0},{1}) is within the circle {2}.\n", x, y, stringVariable);
            else Console.WriteLine("Point ({0},{1}) is outside the circle {2}.\n", x, y, stringVariable);

       //Exmaple 7
            //Assign values to x and y.
            x = 0;
            y = 0;

            //make the calculation if the point is inside the circle
            temp = Math.Pow(x, 2.0) + Math.Pow(y, 2.0);
            if (temp <= Math.Pow(2.0, 2.0)) Console.WriteLine("Point ({0},{1}) is within the circle {2}.\n", x, y, stringVariable);
            else Console.WriteLine("Point ({0},{1}) is outside the circle {2}.\n", x, y, stringVariable);

     //Exmaple 8
            //Assign values to x and y.
            x = 0.2;
            y = -0.8;

            //make the calculation if the point is inside the circle
            temp = Math.Pow(x, 2.0) + Math.Pow(y, 2.0);
            if (temp <= Math.Pow(2.0, 2.0)) Console.WriteLine("Point ({0},{1}) is within the circle {2}.\n", x, y, stringVariable);
            else Console.WriteLine("Point ({0},{1}) is outside the circle {2}.\n", x, y, stringVariable);

       //Exmaple 9
            //Assign values to x and y.
            x = 0.9;
            y = 1.93;

            //make the calculation if the point is inside the circle
            temp = Math.Pow(x, 2.0) + Math.Pow(y, 2.0);
            if (temp <= Math.Pow(2.0, 2.0)) Console.WriteLine("Point ({0},{1}) is within the circle {2}.\n", x, y, stringVariable);
            else Console.WriteLine("Point ({0},{1}) is outside the circle {2}.\n", x, y, stringVariable);

       //Exmaple 10
            //Assign values to x and y.
            x = 1;
            y = 1.655;

            //make the calculation if the point is inside the circle
            temp = Math.Pow(x, 2.0) + Math.Pow(y, 2.0);
            if (temp <= Math.Pow(2.0, 2.0)) Console.WriteLine("Point ({0},{1}) is within the circle {2}.\n", x, y, stringVariable);
            else Console.WriteLine("Point ({0},{1}) is outside the circle {2}.\n", x, y, stringVariable);
           
        }
    }
