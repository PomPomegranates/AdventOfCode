using AdventDayThree;
using FluentAssertions;
namespace AdventOfCodeDay3Tests
{
    public class Tests
    {

        [Test]
        public void CorrectlyPatternMatches()
        {
            int answer = PatternMatcher.PatternMatch("mul(2,10)");
            answer.Should().Be(20);
        }
        [Test]
        public void CorrectlyPatternMatchesMultiple()
        {
            int answer = PatternMatcher.PatternMatch("mul(2,10)mul(2,10)asb,mul(10,10)");
            answer.Should().Be(140);
        }

        [Test]
        public void MatchDoDont()
        {
            string practice = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))";
            int answer = PatternMatcher.PatternMatchDoDont(practice);
            answer.Should().Be(48);
        }
    }
}