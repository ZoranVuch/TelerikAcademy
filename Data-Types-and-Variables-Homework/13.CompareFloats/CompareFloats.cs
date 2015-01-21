using System;

    class CompareFloats
    {
        static void Main()
        {  
            // Comapre variables with values 5.3 and 6.01 
            double a, b, eps = 0.000001;
            a = 5.3;
            b = 6.01;
            Console.WriteLine("Comparison between variable a=" + a + " and variable b=" + b + " with precision 0.000001");

            if (Math.Abs(b-a)<eps)      // Compare the absolute value of the difference with the precision 0.000001.
                {
                Console.WriteLine("Variables a and b are equal with precision 0.000001\n"); 
                }
            else
                {
                 Console.WriteLine("Variables a and b are different\n");
                }

            // Comapre variables with values 5.00000001 and 5.00000003 
            a = 5.00000001;
            b = 5.00000003;
            Console.WriteLine("Comparison between variable a=" + a + " and variable b=" + b + " with precision 0.000001");
            if (Math.Abs(b - a) < eps)
            {
                Console.WriteLine("Variables a and b are equal with precision 0.000001\n");
            }
            else
            {
                Console.WriteLine("Variables a and b are different\n");
            }

            // Comapre variables with values 5.00000005 and 5.00000001 
            a = 5.00000005;
            b = 5.00000001;
            Console.WriteLine("Comparison between variable a=" + a + " and variable b=" + b + " with precision 0.000001");
            if (Math.Abs(b - a) < eps)
            {
                Console.WriteLine("Variables a and b are equal with precision 0.000001\n");
            }
            else
            {
                Console.WriteLine("Variables a and b are different\n");
            }

            // Comapre variables with values -0.0000007 and 0.00000007
            a = -0.0000007;
            b = 0.00000007;
            Console.WriteLine("Comparison between variable a=" + a + " and variable b=" + b + " with precision 0.000001");
            if (Math.Abs(b - a) < eps)
            {
                Console.WriteLine("Variables a and b are equal with precision 0.000001\n");
            }
            else
            {
                Console.WriteLine("Variables a and b are different\n");
            }

            // Comapre variables with values -4.999999 and -4.999998
            a = -4.999999;
            b = -4.999998;
            Console.WriteLine("Comparison between variable a=" + a + " and variable b=" + b + " with precision 0.000001");
            if (Math.Abs(b - a) < eps)
            {
                Console.WriteLine("Variables a and b are equal with precision 0.000001\n");
            }
            else
            {
                Console.WriteLine("Variables a and b are different\n");
            }

            // Comapre variables with values 4.999999 and 4.999998
            a = 4.999999;
            b = 4.999998;
            Console.WriteLine("Comparison between variable a=" + a + " and variable b=" + b + " with precision 0.000001");
            if (Math.Abs(b - a) < eps)
            {
                Console.WriteLine("Variables a and b are equal with precision 0.000001\n");
            }
            else
            {
                Console.WriteLine("Variables a and b are different\n");
            }
        }
    }
