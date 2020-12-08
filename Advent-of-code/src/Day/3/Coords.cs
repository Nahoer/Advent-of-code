using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._3
{
    public class Coords
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coords(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Coords operator+ (Coords c1, Coords c2)
        {
            return new Coords(c1.X + c2.X, c1.Y + c2.Y);
        }
    }
}
