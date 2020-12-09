using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._9
{
    public class Xmas
    {
        public List<ulong> Content { get; private set; } //Numbers sequence
        public int PreambleSize { get; private set; }


        /// <summary>
        /// Xmas's constructor
        /// </summary>
        /// <param name="sequence">Sequence of numbers</param>
        /// <param name="preambleSize">Size of the Preamble</param>
        public Xmas(List<ulong> sequence, int preambleSize)
        {
            this.PreambleSize = preambleSize;
            this.Content = sequence;
        }


        /// <summary>
        /// Get the Preamble of the sequence/content
        /// </summary>
        /// <returns>List of ulong, corresponding to the sequence / content</returns>
        public List<ulong> GetPreamble()
        {
            
            List<ulong> preamble = new List<ulong>();
            for (int i=0; i<this.PreambleSize; i++)
            {
                preamble.Add(this.Content[i]);
            }

            return preamble;
            
        }

        /// <summary>
        /// Recursive function to check if the sequence is right
        /// </summary>
        /// <param name="index">index where it starts</param>
        /// <returns>Returns the number which isn't correct, returns 0 otherwise</returns>
        public ulong IsConform(int index)
        {
            int i = index-PreambleSize;
            ulong error = 0;
            Boolean found = false;
            while (!found&&i < index)
            {
                int j = index-PreambleSize;
                while (!found&&j < index)
                {
                    if (this.Content[i] + this.Content[j] == this.Content[index] && this.Content[i]!= this.Content[j])
                    {
                        found = true;
                    }
                    j++;
                }
                i++;
            }
            if (!found)
            {
                error = this.Content[index];
            }
            else if(index+1<this.Content.Count)
            {
                error = this.IsConform(index + 1);
            }

            return error;
        }

        /// <summary>
        /// Find the range of numbers to add to obtain the number given in parameter
        /// </summary>
        /// <param name="number">Number to obtain</param>
        /// <returns>Return a List of 2 numbers, corresponding to the start and the end of range</returns>
        public List<int> GetRangeOf(ulong number)
        {
            ulong sum = 0;
            List<int> range = new List<int>();
            Boolean found = false;
            int i = 0;
            while(!found&&i<this.Content.Count)
            {
                int j = i+1;
                while (!found && sum < number)
                { 
                    sum = RangeSum(i, j);
                    if (sum == number)
                    {
                        range.Add(i);
                        range.Add(j);
                        found = true;
                    }
                    j++;
                }
                sum = 0;
                i++;
            }
            return range;
            
        }
        /// <summary>
        /// Calculate the sum of the figures in a range between two index
        /// </summary>
        /// <param name="index1">index of the start of the range</param>
        /// <param name="index2">index of the end of the range</param>
        /// <returns></returns>
        public ulong RangeSum(int index1, int index2)
        {
            ulong sum = 0;
            for (int i=index1; i <= index2; i++) 
            {
                sum += this.Content[i];
            }

            return sum;
        }
        /// <summary>
        /// Find the maximum value in a range between two index
        /// </summary>
        /// <param name="index1">index of the start of the range</param>
        /// <param name="index2">index of the end of the range</param>
        /// <returns>Maximum value avec the range</returns>
        public ulong GetMinRange(int index1, int index2)
        {
            ulong min = this.Content[index1];
            for (int i=index1+1; i<index2; i++)
            {
                if (min > this.Content[i])
                {
                    min = this.Content[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Find the minimum value in a range between two index
        /// </summary>
        /// <param name="index1">index of the start of the range</param>
        /// <param name="index2">index of the end of the range</param>
        /// <returns>Minimum value avec the range</returns>
        public ulong GetMaxRange(int index1, int index2)
        {
            ulong max = this.Content[index1];
            for (int i = index1 + 1; i < index2; i++)
            {
                if (max < this.Content[i])
                {
                    max = this.Content[i];
                }
            }

            return max;
        }



    }
}
