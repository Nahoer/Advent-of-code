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

        public void SetPolicy(Policy policy)
        {
            this.Policy = policy;
        }

        public Boolean IsValid()
        {
            Boolean isValid = false;
            if (this.Policy != null)
            {
                isValid = this.Policy.IsValid(this.Content);
            }
            return isValid;
        }
    }
}
