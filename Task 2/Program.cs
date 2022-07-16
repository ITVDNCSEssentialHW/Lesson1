using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first side");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enteer the second side");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle1 = new Rectangle(side1, side2);

            double area = rectangle1.Area;
            double perimeter = rectangle1.Perimeter;

            Console.WriteLine($"The area of the rectangle is {area}");
            Console.WriteLine($"The perimeter of the rectangle is {perimeter}");

            Console.ReadLine();
        }
    }
}
