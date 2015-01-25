using System;
    class Rectangles
    {
        static void Main()
        {
            double width, height, perimeter, area;  //definition of variables

            //example 1
            width = 3;      //Assigning value to width
            height = 4;     //Assigning value to height

            perimeter = 2 * (width + height);     //calculation of perimeter;
            area = width * height;                  // calculation of area

            //Print results
            Console.WriteLine("Rectangle with sides width={0} and height={1} has the following:", width, height);
            Console.WriteLine("Perimeter {0} and Area {1}\n", perimeter, area);


            //example 2
            width = 2.5;      //Assigning value to width
            height = 3;     //Assigning value to height

            perimeter = 2 * (width + height);     //calculation of perimeter;
            area = width * height;                  // calculation of area

            //Print results
            Console.WriteLine("Rectangle with sides width={0} and height={1} has the following:", width, height);
            Console.WriteLine("Perimeter {0} and Area {1}\n", perimeter, area);


            //example 3
            width = 5;      //Assigning value to width
            height = 5;     //Assigning value to height

            perimeter = 2 * (width + height);     //calculation of perimeter;
            area = width * height;                  // calculation of area

            //Print results
            Console.WriteLine("Rectangle with sides width={0} and height={1} has the following:", width, height);
            Console.WriteLine("Perimeter {0} and Area {1}\n", perimeter, area);
        }
    }

