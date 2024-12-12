using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventDayThree
{
    public class PatternMatcher
    {
        public static int PatternMatch(string input)
        {

            //string pattern = @"mul\(\d{1,3},\d{1,3}\)";
            int startNumber = 0;
            Match m = Regex.Match(input, @"mul\(\d{1,3},\d{1,3}\)");
            while (m.Success)
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                string mulString = m.Value;
                var brackets = mulString.Split('(');
                var numbers = brackets[1].Split(",");
                int afterNumber = int.Parse(numbers[0]) * int.Parse(numbers[1].Replace(')',' ').Trim());
                startNumber += afterNumber;
                m = m.NextMatch();
            }
            return startNumber;
            
        }
        public static int PatternMatchDoDont(string input)
        {
            bool shouldDo = true;
            string pattern = @"mul\(\d{1,3},\d{1,3}\)";
            int startNumber = 0;
            Match m = Regex.Match(input, pattern);
            Match matchDo = Regex.Match(input, @"do\(\)");
            Match matchDont = Regex.Match(input, @"don't\(\)");
            while (m.Success)
            {
                
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                string mulString = m.Value;
                var brackets = mulString.Split('(');
                var numbers = brackets[1].Split(",");
                int afterNumber = int.Parse(numbers[0]) * int.Parse(numbers[1].Replace(')', ' ').Trim());

                
                

                if (matchDo.Index < m.Index)
                {
                    Console.WriteLine("'{0}' found at index {1}.", matchDo.Value, matchDo.Index);
                    matchDo = matchDo.NextMatch();
                }
                if (matchDont.Index < m.Index)
                {
                    Console.WriteLine("'{0}' found at index {1}.", matchDont.Value, matchDont.Index);
                    matchDont = matchDont.NextMatch();
                }

                if (matchDo.Index < matchDont.Index)
                {
                    Console.WriteLine("'{0}' < {1}.", matchDo.Index, matchDont.Index);
                    shouldDo = true;
                }

                if (matchDont.Index < matchDo.Index)
                {
                    Console.WriteLine("'{0}' > {1}.", matchDo.Index, matchDont.Index);
                    shouldDo = false;
                }
                if (shouldDo)
                {
                    startNumber += afterNumber;
                }
                
                m = m.NextMatch();
            }
            return startNumber;

        }
    }
}
