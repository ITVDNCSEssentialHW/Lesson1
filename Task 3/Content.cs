using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Content
    {
        public string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine(content);
        }
    }
}
