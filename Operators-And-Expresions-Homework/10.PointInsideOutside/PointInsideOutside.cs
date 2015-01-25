using System;

    class PointInsideOutside
    {
        static void Main()
        {
            //definition of variables
            double x, y, temp;

            bool inCircle, outOfRectangle;

            //Circle with R=1.5 and center {1,1} will have all points in for 
            // which it is true that (X-1)^2 + (Y-1)^2 <= R^2.
            //Point is outside of rectangle if x < 1 or x> 7 or y <-3 or y>-1
            

      //Example 1
            //assigning values to variables
            x = 1;
            y = 2;

            //Calculation if the point is inside the circle
            temp = Math.Pow((x-1), 2.0) + Math.Pow((y-1), 2.0);

            if (temp <= Math.Pow(1.5, 2.0)) inCircle = true;
            else inCircle = false;

            //calculation if the point is out of the rectangle
            if (x < 1 || x > 7 || y < -3 || y > -1) outOfRectangle = true;
            else outOfRectangle = false;

            //Check the point and print the result
            if (inCircle == true && outOfRectangle == true) Console.WriteLine("Point ({0},{1}) meets the requirement to be in circle and out of the rectangle", x, y);
            else Console.WriteLine("Point ({0},{1}) does not meet the requirement to be in circle and out of the rectangle", x, y);
            Console.WriteLine("\n");

     //Example 2
            //assigning values to variables
            x = 2.5;
            y = 2;

            //Calculation if the point is inside the circle
            temp = Math.Pow((x - 1), 2.0) + Math.Pow((y - 1), 2.0);

            if (temp <= Math.Pow(1.5, 2.0)) inCircle = true;
            else inCircle = false;

            //calculation if the point is out of the rectangle
            if (x < 1 || x > 7 || y < -3 || y > -1) outOfRectangle = true;
            else outOfRectangle = false;

            //Check the point and print the result
            if (inCircle == true && outOfRectangle == true) Console.WriteLine("Point ({0},{1}) meets the requirement to be in circle and out of the rectangle", x, y);
            else Console.WriteLine("Point ({0},{1}) does not meet the requirement to be in circle and out of the rectangle", x, y);
            Console.WriteLine("\n");

      //Example 3
            //assigning values to variables
            x = 0;
            y = 1;

            //Calculation if the point is inside the circle
            temp = Math.Pow((x - 1), 2.0) + Math.Pow((y - 1), 2.0);

            if (temp <= Math.Pow(1.5, 2.0)) inCircle = true;
            else inCircle = false;

            //calculation if the point is out of the rectangle
            if (x < 1 || x > 7 || y < -3 || y > -1) outOfRectangle = true;
            else outOfRectangle = false;

            //Check the point and print the result
            if (inCircle == true && outOfRectangle == true) Console.WriteLine("Point ({0},{1}) meets the requirement to be in circle and out of the rectangle", x, y);
            else Console.WriteLine("Point ({0},{1}) does not meet the requirement to be in circle and out of the rectangle", x, y);
            Console.WriteLine("\n");

       //Example 4
            //assigning values to variables
            x = 2.5;
            y = 1;

            //Calculation if the point is inside the circle
            temp = Math.Pow((x - 1), 2.0) + Math.Pow((y - 1), 2.0);

            if (temp <= Math.Pow(1.5, 2.0)) inCircle = true;
            else inCircle = false;

            //calculation if the point is out of the rectangle
            if (x < 1 || x > 7 || y < -3 || y > -1) outOfRectangle = true;
            else outOfRectangle = false;

            //Check the point and print the result
            if (inCircle == true && outOfRectangle == true) Console.WriteLine("Point ({0},{1}) meets the requirement to be in circle and out of the rectangle", x, y);
            else Console.WriteLine("Point ({0},{1}) does not meet the requirement to be in circle and out of the rectangle", x, y);
            Console.WriteLine("\n");


      //Example 5
            //assigning values to variables
            x = 2;
            y = 0;

            //Calculation if the point is inside the circle
            temp = Math.Pow((x - 1), 2.0) + Math.Pow((y - 1), 2.0);

            if (temp <= Math.Pow(1.5, 2.0)) inCircle = true;
            else inCircle = false;

            //calculation if the point is out of the rectangle
            if (x < 1 || x > 7 || y < -3 || y > -1) outOfRectangle = true;
            else outOfRectangle = false;

            //Check the point and print the result
            if (inCircle == true && outOfRectangle == true) Console.WriteLine("Point ({0},{1}) meets the requirement to be in circle and out of the rectangle", x, y);
            else Console.WriteLine("Point ({0},{1}) does not meet the requirement to be in circle and out of the rectangle", x, y);
            Console.WriteLine("\n");


       //Example 6
            //assigning values to variables
            x = 4;
            y = 0;

            //Calculation if the point is inside the circle
            temp = Math.Pow((x - 1), 2.0) + Math.Pow((y - 1), 2.0);

            if (temp <= Math.Pow(1.5, 2.0)) inCircle = true;
            else inCircle = false;

            //calculation if the point is out of the rectangle
            if (x < 1 || x > 7 || y < -3 || y > -1) outOfRectangle = true;
            else outOfRectangle = false;

            //Check the point and print the result
            if (inCircle == true && outOfRectangle == true) Console.WriteLine("Point ({0},{1}) meets the requirement to be in circle and out of the rectangle", x, y);
            else Console.WriteLine("Point ({0},{1}) does not meet the requirement to be in circle and out of the rectangle", x, y);
            Console.WriteLine("\n");


       //Example 7
            //assigning values to variables
            x = 2.5;
            y = 1.5;

            //Calculation if the point is inside the circle
            temp = Math.Pow((x - 1), 2.0) + Math.Pow((y - 1), 2.0);

            if (temp <= Math.Pow(1.5, 2.0)) inCircle = true;
            else inCircle = false;

            //calculation if the point is out of the rectangle
            if (x < 1 || x > 7 || y < -3 || y > -1) outOfRectangle = true;
            else outOfRectangle = false;

            //Check the point and print the result
            if (inCircle == true && outOfRectangle == true) Console.WriteLine("Point ({0},{1}) meets the requirement to be in circle and out of the rectangle", x, y);
            else Console.WriteLine("Point ({0},{1}) does not meet the requirement to be in circle and out of the rectangle", x, y);
            Console.WriteLine("\n");


      //Example 8
            //assigning values to variables
            x = 2;
            y = 1.5;

            //Calculation if the point is inside the circle
            temp = Math.Pow((x - 1), 2.0) + Math.Pow((y - 1), 2.0);

            if (temp <= Math.Pow(1.5, 2.0)) inCircle = true;
            else inCircle = false;

            //calculation if the point is out of the rectangle
            if (x < 1 || x > 7 || y < -3 || y > -1) outOfRectangle = true;
            else outOfRectangle = false;

            //Check the point and print the result
            if (inCircle == true && outOfRectangle == true) Console.WriteLine("Point ({0},{1}) meets the requirement to be in circle and out of the rectangle", x, y);
            else Console.WriteLine("Point ({0},{1}) does not meet the requirement to be in circle and out of the rectangle", x, y);
            Console.WriteLine("\n");


     //Example 9
            //assigning values to variables
            x = 1;
            y = 2.5;

            //Calculation if the point is inside the circle
            temp = Math.Pow((x - 1), 2.0) + Math.Pow((y - 1), 2.0);

            if (temp <= Math.Pow(1.5, 2.0)) inCircle = true;
            else inCircle = false;

            //calculation if the point is out of the rectangle
            if (x < 1 || x > 7 || y < -3 || y > -1) outOfRectangle = true;
            else outOfRectangle = false;

            //Check the point and print the result
            if (inCircle == true && outOfRectangle == true) Console.WriteLine("Point ({0},{1}) meets the requirement to be in circle and out of the rectangle", x, y);
            else Console.WriteLine("Point ({0},{1}) does not meet the requirement to be in circle and out of the rectangle", x, y);
            Console.WriteLine("\n");

      //Example 10
            //assigning values to variables
            x = -100;
            y = -100;

            //Calculation if the point is inside the circle
            temp = Math.Pow((x - 1), 2.0) + Math.Pow((y - 1), 2.0);

            if (temp <= Math.Pow(1.5, 2.0)) inCircle = true;
            else inCircle = false;

            //calculation if the point is out of the rectangle
            if (x < 1 || x > 7 || y < -3 || y > -1) outOfRectangle = true;
            else outOfRectangle = false;

            //Check the point and print the result
            if (inCircle == true && outOfRectangle == true) Console.WriteLine("Point ({0},{1}) meets the requirement to be in circle and out of the rectangle", x, y);
            else Console.WriteLine("Point ({0},{1}) does not meet the requirement to be in circle and out of the rectangle", x, y);
            Console.WriteLine("\n");




        }
    }
