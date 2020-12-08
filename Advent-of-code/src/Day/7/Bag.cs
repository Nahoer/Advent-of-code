using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.Day._7
{

    public class Bag
    {
        public List<Child> Children { get; private set; }
        public string Name { get; private set; }

        /// <summary>
        /// Bag's Constructor
        /// </summary>
        /// <param name="name">node's name, referring to its color in this case</param>
        public Bag(string name)
        {
            this.Children = new List<Child>();
            this.Name = name;
        }

        /// <summary>
        /// Add a child node with its corresponding weight
        /// </summary>
        /// <param name="bag">Child node</param>
        /// <param name="weight">link's Weight</param>
        public void AddChild(Bag bag, int weight)
        {
            this.Children.Add(new Child(bag, weight));
        }

        /// <summary>
        /// Recursive function that returns sum of weights + 1
        /// </summary>
        /// <returns>Returns an int corresponding to sum of weights + 1</returns>
        private int WeightSum()
        {
            int sum = 0;
            if (this.Children.Count != 0)
            {
                foreach(Child child in this.Children)
                {
                    sum += child.Bag.WeightSum() * child.Weight;
                }
            }

            return sum + 1;
        }

        /// <summary>
        /// Function that returns sum of weight
        /// </summary>
        /// <returns>Returns an int corresponding to sum of weights</returns>
        public int TotalWeightSum()
        {
            return this.WeightSum() - 1;
        }


        /// <summary>
        /// Function that returns a List of bags that is able to contain the bag given in parameters
        /// </summary>
        /// <param name="name">Bag's name/color</param>
        /// <param name="first">First node</param>
        /// <returns></returns>
        public List<Bag> CanContain(string name, Bag first)
        {
            List<Bag> markedBags = new List<Bag>();
            if (this.Children.Count != 0)
            {
                foreach(Child child in this.Children)
                {
                    markedBags.AddRange(child.Bag.CanContain(name, first));
                    if (child.Bag.Name.Equals(name))
                    {
                        if (!markedBags.Contains(first))
                        {
                            markedBags.Add(first);
                        }
                        
                    }
                }
            }
            return markedBags;
        }


        public String ToString()
        {
            String str = "";
            str += this.Name += " bags contain";
            if (this.Children.Count !=0)
            {
                foreach (Child child in this.Children)
                {
                    str += " " + child.Weight + " " + child.Bag.Name + ",";
                }
                char[] str2 = str.ToCharArray();
                str2[str.Length - 1] = '.';
                str = new string(str2);
            }
            else
            {
                str += " no other bags";
            }
            
            return str;
        }

    }
}
