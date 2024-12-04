using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventDayTwo
{
    internal class SafetyTester
    {
        public static List<bool> SafetyChecker(List<List<int>> reindeerSafetyData)
        {
            return reindeerSafetyData.Select(list =>
            {
                List<bool> isAscending = new();
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] < list[i + 1])
                    {
                        isAscending.Add(true);
                        if (list[i + 1] - list[i] > 4)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        isAscending.Add(false);
                        if (list[i] - list[i + 1] > 4)
                        {
                            return false;
                        }
                    }
                    

                }
                if (list.Where(x => x.Equals(true)).ToList().Count == list.Count-1 || list.Where(x => x.Equals(false)).ToList().Count == list.Count-1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }).ToList();

        }

        //Predicate<List<int>> isSafe = list =>
        //{
        //    List<bool> isAscending = new();
        //    for (int i = 0; i< list.Count-1; i++)
        //    {
        //        if (list[i] < list[i + 1])
        //        {
        //            isAscending.Add(true);
        //        }
        //        else
        //        {
        //            isAscending.Add(false);
        //        }
        //        if (Math.Abs(list[i]) - Math.Abs(list[i + 1]) > 2)
        //        {
        //            return false;
        //        }

        //    }
        //    if (isAscending.Contains(false))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
            
        //};
    }
}
