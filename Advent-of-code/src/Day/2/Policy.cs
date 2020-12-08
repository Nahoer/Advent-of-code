using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._2
{
    public class Policy
    {
        public char Key { get; private set; }
        public int Min { get; private set; }
        public int Max { get; private set; }

        public Policy(char key, int min, int max)
        {
            this.Key = key;
            this.Min = min;
            this.Max = max;
        }
    }
}
