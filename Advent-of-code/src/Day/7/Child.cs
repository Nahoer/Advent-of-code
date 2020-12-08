using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.Day._7
{
    public class Child
    {
        public Bag Bag { get; private set; }
        public int Weight { get; private set; }

        /// <summary>
        /// Child's constructor
        /// </summary>
        /// <param name="bag">Bag child</param>
        /// <param name="weight">link's weight</param>
        public Child(Bag bag, int weight)
        {
            this.Bag = bag;
            this.Weight = weight;
        }

    }
}
