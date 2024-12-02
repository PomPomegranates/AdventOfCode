using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventDayTwo
{
    public static class FileReader
    {
        public static List<List<int>> UnpackLines(string filename)
        {
            string[] stringLines = File.ReadAllLines(filename);

            List<List<int>> outsideList = new();
            foreach (string line in stringLines)
            {
                List<int> insideList = line.Split(" ").Select(int.Parse).ToList();
                outsideList.Add(insideList);
            }
            return outsideList;
        }
    }
}
