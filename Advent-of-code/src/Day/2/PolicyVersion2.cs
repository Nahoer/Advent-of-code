using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._2
{
    public class PolicyVersion2 : Policy
    {
        public PolicyVersion2(char key, int min, int max) : base(key, min, max)
        {

        }
        public override bool IsValid(string content)
        {
 
            return content[this.Min - 1].Equals(this.Key) ^ content[this.Max - 1].Equals(this.Key);
        }
    }
}
