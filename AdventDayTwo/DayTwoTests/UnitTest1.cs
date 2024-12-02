
using AdventDayTwo;
using FluentAssertions;

namespace DayTwoTests
{
    public class Tests
    { 
        [Test]
        public void FileReadTest()
        {

            List<List<int>> fullList = FileReader.UnpackLines("./AdventDataDay2.txt");

            fullList[0].Should().BeEquivalentTo(new List<int> { 5, 6, 7, 10, 13, 16, 13, });
            fullList[3].Should().BeEquivalentTo(new List<int> { 44, 46, 48, 49, 52, 55, 56, 62 });

        }

        [Test]
        public void SafeLevelTest()
        {

            Assert.Pass();
        }
    }
}