using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._10
{
    public class Node
    {
        public Adaptater Value { get; private set; }
        public Node Child { get; private set; }
        public Node Parent { get; private set; }

        public Node(int value)
        {
            this.Value = new Adaptater(value);
        }

        public void SetChild(Node child)
        {
            this.Child = child;
            this.Child.Parent = this;
        }

        public Dictionary<Difference,int> GetDifferences()
        {
            Dictionary<Difference, int> differences = new Dictionary<Difference, int>();
            differences[Difference.One] = 0;
            differences[Difference.Two] = 0;
            differences[Difference.Three] = 0;
            if (this.Child != null)
            {
                switch (this.GetDifference(this.Child))
                {
                    case 1:
                        differences[Difference.One]++;
                        break;
                    case 2:
                        differences[Difference.Two]++;
                        break;
                    case 3:
                        differences[Difference.Three]++;
                        break;
                }

                Dictionary<Difference, int> differences2 = this.Child.GetDifferences();
                differences[Difference.One] += differences2[Difference.One];
                differences[Difference.Three] += differences2[Difference.Three];
            }

            return differences;
        }

        public Dictionary<Difference, int> GetTotalDifferences()
        {
            Dictionary<Difference, int> differences = this.GetDifferences();
            if (differences[Difference.One] >= 1){
                differences[Difference.One]++;
            }
            if (differences[Difference.Three] >= 1)
            {
                differences[Difference.Three]++;
            }
            return differences;
        }

        public int GetDifference(Node child)
        {
            return Math.Abs(child.Value.Jolt - this.Value.Jolt);
        }

        public ulong GetNbrWays()
        {
            ulong nbrWays = 0;
            Node currentNode = this;
            int count = 1;
            Boolean end = false;
            currentNode = this.Child;
            while (!end)
            {

                //Console.WriteLine(this.Value.Jolt+" | "+currentNode.Value.Jolt+" Difference: "+this.GetDifference(currentNode));
                if (this.GetDifference(currentNode) <= 3)
                {
                    count++;
                    if (currentNode.Child != null)
                    {
                        currentNode = currentNode.Child;
                    }
                    else end = true;

                }
                else end = true;
            }
            nbrWays = Convert.ToUInt64(Math.Pow(2, count - 2));
            if (currentNode.Child != null)
            {
                if (count > 2)
                {
                    nbrWays = nbrWays * currentNode.Parent.Parent.GetNbrWays();
                }
                else
                {
                    nbrWays = nbrWays * currentNode.Parent.GetNbrWays();
                }
                
                
            }
            return nbrWays;

        }
    }

    public enum Difference
    {
        One,
        Two,
        Three
    }


}
