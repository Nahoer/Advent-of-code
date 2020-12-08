using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._3
{
    public class Container
    {
        public Type Type { get; private set; }
        public Container(Type type)
        {
            this.Type = type;
        }
    }

    public enum Type
    {
        Square,
        Tree
    }
}
