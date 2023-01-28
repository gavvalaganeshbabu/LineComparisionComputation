using System;

namespace LineComparisionComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation :");
            Console.WriteLine("Calculating the Length of a Lines are Equal Or Not :");
            Console.WriteLine("Enter the Cooradinates of First Line  (x1,y1) and (x2,y2) ");
            double x1=double.Parse(Console.ReadLine());
            double y1=double.Parse(Console.ReadLine());
            double x2=double.Parse(Console.ReadLine());
            double y2=double.Parse(Console.ReadLine());           
            double FirstLineLength=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
            Console.WriteLine("Enter the Cooradinates of Second Line  (x3,y3) and (x4,y4) ");
            double x3=double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double SecondLineLength = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            bool x=(FirstLineLength==SecondLineLength);
            if (x == true) { Console.WriteLine("Two Line Length are Equal  "); }
            else { Console.WriteLine("Two Lines are Not Equal :"); }


        }
    }
}
