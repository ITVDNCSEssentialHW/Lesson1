using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(2, 3, "A"), new Point(5, 7, "B"), new Point(8, 2, "C"));

            Console.WriteLine($"Figure type is {figure.Type}");

            figure.CalculatePerimeter();

            Console.ReadLine();
        }
    }
}
