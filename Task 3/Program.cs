using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "Hello World!";

            Book book = new Book("I", "My book", content);
            book.Show();

            Console.ReadLine();
        }
    }
}
