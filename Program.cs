using System;

namespace LineComparisionComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation :");
            LengthOfLine();
        }
        static void LengthOfLine()
        {
            Console.WriteLine("Calculating the Length of a Line :");
            Console.WriteLine("Enter the Cooradinates of Two Lines  (x1,y1) and (x2,y2) ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The Length of the Line = " + length);
        }
    }
}
