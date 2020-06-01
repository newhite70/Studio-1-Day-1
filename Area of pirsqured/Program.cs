using System;

namespace Area_of_pirsqured
{
    class Program
    {
        static void Main()
        {
            double radius;
            double areaofC;
            double circofC;
            double diaofC;
            double gallonsUsed;
            double mpg;

            Console.WriteLine("What is the radius of the circle?");
            string radiusinput = Console.ReadLine();
            radius = double.Parse(radiusinput);

            areaofC = Math.PI * (radius * radius);
            circofC = 2 * Math.PI * radius;
            diaofC = 2 * radius;

            Console.WriteLine("How many miles per gallon does your car get?");
            string mpgIn = Console.ReadLine();
            mpg = double.Parse(mpgIn);
            gallonsUsed = (circofC / mpg);

            Console.WriteLine($"Your car would use {gallonsUsed} gallons of fuel to travel around this circle.");

        }
    }
}
