using System.Text.RegularExpressions;

namespace AdventDayThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string input = File.ReadAllText(@".\AdventOfCodeDay3.txt");//"mul(2,10)";
            //string pattern = @"mul\(\d{1,3},\d{1,3}\)";
            int answer = PatternMatcher.PatternMatchDoDont(input);
            Console.WriteLine(answer);
            //Match m = Regex.Match(input, pattern);
            //Console.WriteLine();
            //string pattern = @"(mul\(\d{ 1,3},\d{ 1,3}\))";
            //int startNumber = 0;
            //Match m = Regex.Match(, pattern);
            //string mulString = m.Value;
            //var brackets = mulString.Split('(');
            //var numbers = brackets[1].Split(",");
            //int afterNumber = int.Parse(numbers[0]) * int.Parse(numbers[1]);
            //startNumber += afterNumber;
        }
    }
}
