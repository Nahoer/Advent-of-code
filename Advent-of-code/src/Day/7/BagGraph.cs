using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent_of_code.Day._7
{
    public class BagGraph
    {
        public Dictionary<string,Bag> Bags { get; private set; } 

        /// <summary>
        /// Graph's constructor
        /// </summary>
        public BagGraph()
        {
            this.Bags = new Dictionary<string, Bag>();
        }

        /// <summary>
        /// Add a node in the graph
        /// </summary>
        /// <param name="name"></param>
        /// <param name="bag"></param>
        public void AddBag(string name, Bag bag)
        {
            this.Bags.Add(name, bag);
        }

        /// <summary>
        /// Function that returns a List of  the sum of bags that is able to contain the bag given in parameters
        /// </summary>
        /// <param name="name">Bag's name/color</param>
        /// <returns></returns>
        public List<Bag> CanContain(string name)
        {
            List<Bag> listToReturn = new List<Bag>();
            foreach (KeyValuePair<string, Bag> entry in this.Bags)
            {
                foreach(Bag b in entry.Value.CanContain(name, entry.Value))
                {
                    if (!listToReturn.Contains(b))
                    {
                        listToReturn.Add(b);
                    }
                }
            }

            return listToReturn;

        } 
    }
}
