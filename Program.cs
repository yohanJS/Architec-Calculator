using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            //this variable stores the total area of Teotihuacan
            double totalArea;

            totalArea = CalculateTotalCost(2500, 1500, 375, 500, 750);

            Console.WriteLine($"The total area of Teotihuacan is {Math.Round(totalArea, 2)}");


        }

        static double CalculateTotalCost(double length, double width, double radius, double bottom, double height)
        {

            //This calculates the area of a rectangle and returns the value
            double rect = length * width;

            //This calculates the area of a circle and returns the value
            double circle = Math.PI * Math.Pow(radius, 2);

            //This method calcuates the area of a triangle
            double triangle = 0.5 * bottom * height;

            return rect + circle + triangle;
        }
    }
}
