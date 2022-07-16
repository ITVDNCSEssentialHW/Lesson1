using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }
        
        public void Show()
        {
            Console.WriteLine(author);
        }
    }
}
