using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    class Point
    {
        private int x;
        private int y;
        private string name;

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public int X { get; }
        public int Y { get; }
        public string NAME { get; }
    }
}
