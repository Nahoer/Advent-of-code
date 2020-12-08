using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._2
{
    public class PolicyVersion1 : Policy
    {
        public PolicyVersion1(char key, int min, int max) : base(key, min, max)
        {

        }
        public override bool IsValid(string content)
        {
            Boolean isValid = false;

            

            int count = 0;
            foreach (char c in content)
            {
                if (c.Equals(this.Key))
                {
                    count++;
                }
            }

            if (count <= this.Max && count >= this.Min)
            {
                isValid = true;
            }


            return isValid;
        }
    }
}
