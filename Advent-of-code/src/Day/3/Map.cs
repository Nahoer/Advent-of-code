using System;
using System.Collections.Generic;
using Advent_of_code.src.Day._3;
using System.Text;

namespace Advent_of_code.src.Day._3
{
    public class Map
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Container[,] Content { get; private set; }

        public Map(Container[,] content, int height, int width)
        {
            this.Content = content;
            this.Height = height;
            this.Width = width;
        }

        public Container GetContainer(Coords coords)
        {
            return this.Content[coords.X, coords.Y];
        }

        public Dictionary<Type, int> Cross(Coords coords, Coords move)
        {
            
            Dictionary<Type, int> containers = new Dictionary<Type, int>();

            containers[Type.Square] = 0;
            containers[Type.Tree] = 0;
            if (this.Width>coords.X+move.X && this.Height > coords.Y + move.Y)
            {
                Dictionary<Type, int> containers2 = this.Cross(coords + move, move);
                
                containers[Type.Square] += containers2[Type.Square];
                containers[Type.Tree] += containers[Type.Tree];
            }
            Console.WriteLine(coords.X + "|" + coords.Y + " " +this.GetContainer(coords).Type);
            containers[this.GetContainer(coords).Type]++;

            return containers;
        }

        public string ToString()
        {
            string str="";
            for(int i=0;i<this.Height; i++)
            {
                for (int j = 0; j < this.Width ; j++)
                {
                    if (this.GetContainer(new Coords(j,i)).Type == Type.Tree)
                    {
                        str += "#";
                    }
                    else
                    {
                        str += ".";
                    }
                }
                str += "\n";
            }

            return str;
        }

    }
}
