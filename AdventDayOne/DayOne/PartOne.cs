using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DayOne
{
    public static class PartOne
    {

        public static (List<int> leftSide, List<int> rightSide) MakeTwoLists()
        {
            string[] wholeFile = File.ReadAllLines("./input.txt");
            var leftSide = new List<int>();
            var rightSide = new List<int>();
            foreach (string part in wholeFile)
            {
                leftSide.Add(int.Parse(part.Split("   ")[0]));
                rightSide.Add(int.Parse(part.Split("   ")[1]));
            }
            var orderedLeft = leftSide.Order().ToList();
            var orderedRight = rightSide.Order().ToList();
            return  (orderedLeft, orderedRight);
        }
       public static int CompletePartOne()
        {
            var (leftSide, rightSide) = MakeTwoLists(); 
            var differences = new List<int>();
            for (int i = 0; i < leftSide.Count; i++)
            {
                if (leftSide[i]> rightSide[i])
                {
                    differences.Add(leftSide[i] - rightSide[i]);
                }
                else
                {
                    differences.Add(rightSide[i] - leftSide[i]);
                }
            }
            return differences.Sum();
        }
    }
}
