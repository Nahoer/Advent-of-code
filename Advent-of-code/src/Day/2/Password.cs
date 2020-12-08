using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._2
{
    public class Password
    {
        public string Content { get; private set; }
        public Policy Policy { get; private set; }
        public Password(string content)
        {
            this.Content = content;
        }

        public void SetPolicy(char key, int min, int max)
        {
            this.Policy = new Policy(key, min, max);
        }

        public Boolean IsValid()
        {
            Boolean isValid = false;
            if (this.Policy != null)
            {
                int count = 0;
                foreach (char c in this.Content)
                {
                    if (c.Equals(this.Policy.Key))
                    {
                        count++;
                    }
                }

                if (count <= this.Policy.Max && count >= this.Policy.Min)
                {
                    isValid = true;
                }
            }

            return isValid;
        }
    }
}
