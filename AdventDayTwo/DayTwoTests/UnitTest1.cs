
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
            fullList[^1].Should().BeEquivalentTo(new List<int> { 69, 70, 71, 74, 75, 77 });

        }

        [Test]
        public void SafeLevelTest()
        {
            List<List<int>> testList = FileReader.UnpackLines("./TestData.txt");
            List<bool> safeChecking = SafetyTester.SafetyChecker(testList);
            safeChecking.Should().BeEquivalentTo(new List<bool> { true, false, false, false, false, true });
        }

        [Test]

        public void SafeCountChecker()
        {
            List<List<int>> testList = FileReader.UnpackLines("./TestData.txt");
            List<bool> safeChecking = SafetyTester.SafetyChecker(testList);

            safeChecking.Where(x => x.Equals(true)).ToList().Count().Should().Be(2);
        }
        [Test]
        public void SafeCountCheckerSafetyDampener()
        {
            List<List<int>> testList = FileReader.UnpackLines("./TestData.txt");
            List<bool> safeChecking = SafetyTester.SafetyChecker(testList);
            //var checkForEachRemoved = 
            safeChecking.Where(x => x.Equals(true)).ToList().Count().Should().Be(4);
        }


    }
}