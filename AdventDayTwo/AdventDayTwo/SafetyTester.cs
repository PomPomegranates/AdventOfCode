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
                        if (list[i + 1] - list[i] > 3)
                        {
                            
                            return false;
                        }
                        
                    }
                    else if (list[i] > list[i + 1])
                    {
                        
                        isAscending.Add(false);
                        if (list[i] - list[i + 1] > 3)
                        {
                            
                            return false;
                        }
                        

                    }
                    else
                    {
                        return false;
                    }
                }

                if (isAscending.All(x => x == true))
                {
                    return true;
                }
                else if (isAscending.All(x => x == false))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }).ToList();

        }

        public static List<bool> SafetyChecker(List<List<int>> reindeerSafetyData, bool verbose =true)
        {
            return reindeerSafetyData.Select(list =>
            {
            Console.WriteLine("\n\nStart new Selection Process");
            List<bool> isAscending = new();
                for (int i = 0; i < list.Count - 1; i++)
                {
                    Console.WriteLine($"Iteration number {i}");
                    if (list[i] < list[i + 1])
                    {
                        Console.WriteLine($"Declared that {list[i]} is smaller than {list[i + 1]} and thus IsAscending ");
                        isAscending.Add(true);
                        if (list[i + 1] - list[i] > 3)
                        {
                            Console.WriteLine($"Difference between {list[i]} and {list[i + 1]} is {list[i + 1] - list[i]} - returning false");
                            return false;
                        }
                        Console.WriteLine($"Difference between {list[i]} and {list[i + 1]} is {list[i + 1] - list[i]}");
                    }
                    else if (list[i] > list[i + 1])
                    {
                        Console.WriteLine($"Declared that {list[i]} is bigger than {list[i + 1]} and thus IsNOTAscending");
                        isAscending.Add(false);
                        if (list[i] - list[i + 1] > 3)
                        {
                            Console.WriteLine($"Difference between {list[i]} and {list[i + 1]} is {list[i] - list[i + 1]} - returning false");
                            return false;
                        }
                        Console.WriteLine($"Difference between {list[i]} and {list[i + 1]} is {list[i] - list[i + 1]}");

                    }
                    else 
                    {
                        Console.WriteLine("No increase or decrease, returning false");
                        return false;
                    }
                }

            if (isAscending.All(x => x == true))
                {
                    Console.WriteLine("All are ascending, returning true");
                    return true;
                }
                else if (isAscending.All(x => x == false))
                {
                    Console.WriteLine("All are descending, returning true");
                    return true;
                }
                else
                {
                    return false;
                }

            }).ToList();

        }

        public static List<bool> DampenerConverter(List<List<bool>> bools)
        {
            return bools.Select(y => {
                if (y.Any(x => x == true))
            {
                return true;
            }
            else
            {
                return false;
            }

        }).ToList();
        }


    }
}
