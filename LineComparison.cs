using System;
using System.ComponentModel.DataAnnotations;

namespace LineCamparisonProblem
{
    class LineComparison
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Problem");

            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double length = CalculateLineLength(x1,y1, x2, y2);

            Console.WriteLine($"Length of the line between ({x1}, {y1}) and ({x2}, {y2}) is: {length:F2}");

           
        }
        // method to calculate the length of the line 
        public static double CalculateLineLength(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
