using System;

namespace LineComparisonProblem
{
    // Class representing a Point with X and Y coordinates
    public class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    // Class representing a Line, implementing IComparable for compareTo-like behavior
    public class Line : IComparable<Line>
    {
        private Point start;
        private Point end;

        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        // Calculate length of the line
        public double Length
        {
            get
            {
                double deltaX = end.X - start.X;
                double deltaY = end.Y - start.Y;
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
        }

        // Override Equals to compare based on length
        public override bool Equals(object obj)
        {
            if (obj is Line otherLine)
            {
                return this.Length.Equals(otherLine.Length);
            }
            return false;
        }

        // Override GetHashCode when overriding Equals (best practice)
        public override int GetHashCode()
        {
            return Length.GetHashCode();
        }

        // CompareTo method to compare line lengths
        public int CompareTo(Line other)
        {
            return this.Length.CompareTo(other.Length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem - UC4 (OOP Version)");

            // Input for Line 1
            Console.WriteLine("Enter coordinates for Line 1:");
            Point p1 = ReadPoint("Start");
            Point p2 = ReadPoint("End");
            Line line1 = new Line(p1, p2);

            // Input for Line 2
            Console.WriteLine("Enter coordinates for Line 2:");
            Point p3 = ReadPoint("Start");
            Point p4 = ReadPoint("End");
            Line line2 = new Line(p3, p4);

            // Display lengths
            Console.WriteLine($"\nLength of Line 1: {line1.Length:F2}");
            Console.WriteLine($"Length of Line 2: {line2.Length:F2}");

            // Equality check
            if (line1.Equals(line2))
                Console.WriteLine("Result: Both lines are equal in length.");
            else
                Console.WriteLine("Result: Lines are not equal in length.");

            // Comparison check
            int result = line1.CompareTo(line2);
            if (result == 0)
                Console.WriteLine("Result: Lines are equal in length.");
            else if (result > 0)
                Console.WriteLine("Result: Line 1 is longer than Line 2.");
            else
                Console.WriteLine("Result: Line 1 is shorter than Line 2.");
        }

        // Helper method to read point input from user
        static Point ReadPoint(string label)
        {
            Console.Write($"Enter {label} X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter {label} Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            return new Point(x, y);
        }
    }
}
