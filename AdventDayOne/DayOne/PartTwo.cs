using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DayOne
{
    internal class PartTwo
    {
        public static int CompletePartTwo()
        {
            var (leftSide, rightSide) = PartOne.MakeTwoLists();

            //for each number in left list. If number in right list. multiply the number by the number of times it appears in the right list.
            //
            var testList = leftSide.ToList();
            //Console.WriteLine(leftSide[2]);
            //Console.WriteLine(rightSide.Contains(leftSide[2]));
            Console.WriteLine(leftSide[2]);

            var addList = new List<int>();

            for (int i = 0; i < testList.Count(); i++)
            {
                var query = rightSide.Where(number => number == leftSide[i]);
                int count = query.Count();
                addList.Add(leftSide[i]*count);
            }
            return addList.Sum();
            //var query = rightSide.Where(number => number == leftSide[2]);
            //Console.WriteLine(query.Count());

            //Console.WriteLine(rightSide.Select(c => c == leftSide[2]).ToList().Count());//.Contains(leftSide[2])).ToList().Count());//.ToList().ForEach(Console.WriteLine);//.Count());

            //testList.ForEach(l => {rightSide.Where(r => rightSide.Contains(l))});
        }
    }
}
