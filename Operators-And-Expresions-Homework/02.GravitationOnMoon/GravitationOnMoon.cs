using System;

class GravitationOnMoon
{
    static void Main()
    {
        double weightOnEarth, weightOnMoon; // Define variables for weight on Earth and Moon.
        weightOnEarth = 86;                   // Assign value for weight on Earth.
        weightOnMoon = 0.17 * weightOnEarth;    //Calculate the weight on Moon as 17% that of Earth's.

        // Print the results.
        Console.WriteLine("if weight on Earth is {0}, then the weight on Moon is {1}.\n", weightOnEarth, weightOnMoon);

        //Repeat for other input values of weight on Earth
        weightOnEarth = 74.6;                   // Assign value for weight on Earth.
        weightOnMoon = 0.17 * weightOnEarth;    //Calculate the waight on Moon as 17% that of Earth's.

        // Print the results.
        Console.WriteLine("if weight on Earth is {0}, then the weight on Moon is {1}.\n", weightOnEarth, weightOnMoon);

        weightOnEarth = 53.7;                   // Assign value for weight on Earth.
        weightOnMoon = 0.17 * weightOnEarth;    //Calculate the waight on Moon as 17% that of Earth's.

        // Print the results.
        Console.WriteLine("if weight on Earth is {0}, then the weight on Moon is {1}.\n", weightOnEarth, weightOnMoon);


    }
}