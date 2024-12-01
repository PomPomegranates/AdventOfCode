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
       public static void PartOneComplete()
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
            var differences = new List<int>();
            for (int i = 0; i < orderedLeft.Count; i++)
            {
                if (orderedLeft[i]> orderedRight[i])
                {
                    differences.Add(orderedLeft[i] - orderedRight[i]);
                }
                else
                {
                    differences.Add(orderedRight[i] - orderedLeft[i]);
                }
            }
            Console.WriteLine(differences.Sum());
        }
    }
}
