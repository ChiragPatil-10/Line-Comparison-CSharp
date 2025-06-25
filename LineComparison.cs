using System;

namespace LineCamparisonProblem
{
    class LineComparison
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Problem");

            Console.WriteLine("Enter coordinates for Line 1:");

            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
  
            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Input are for the line 2

            Console.WriteLine("Enter coordinates for Line 2:");

            Console.Write("Enter a1: ");
            double a1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a2: ");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            double length1 = CalculateLineLength(x1,y1, x2, y2);
            double length2 = CalculateLineLength(a1, b1, a2, b2);

            Console.WriteLine($"\nLength of Line 1: {length1:F2}");
            Console.WriteLine($"Length of Line 2: {length2:F2}");

            if (length1.Equals(length2))
            {
                Console.WriteLine("Result: Both lines are equal in length.");
            }
            else
            {
                Console.WriteLine("Result: The lines are not equal in length.");
            }

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
