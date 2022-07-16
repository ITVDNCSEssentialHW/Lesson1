using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Book
    {
        private Author author;
        private Title title;
        private Content content;

        public Book(string author, string title, string content)
        {
            this.author = new Author(author);
            this.title = new Title(title);
            this.content = new Content(content);
        }

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
