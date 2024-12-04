// See https://aka.ms/new-console-template for more information
using AdventDayTwo;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DayTwoTests")]
Console.WriteLine("Hello, World!");

//List<List<int>> fullList = FileReader.UnpackLines("./AdventDataDay2.txt");
//List<bool> safeChecking = SafetyTester.SafetyChecker(fullList);
//Console.WriteLine(safeChecking.Where(x => x.Equals(true)).ToList().Count());
//List<List<int>> testList = FileReader.UnpackLines("./TestData.txt");
//List<bool> safeCheckingTest = SafetyTester.SafetyChecker(testList, true);
//safeCheckingTest.ForEach(Console.WriteLine);
//Console.WriteLine(safeCheckingTest.Where(x => x.Equals(true)).ToList().Count());

List<List<int>> testList = FileReader.UnpackLines("./AdventDataDay2.txt");
List<bool> safeChecking = SafetyTester.SafetyChecker(testList);
safeChecking.ForEach(Console.WriteLine);

var dampenerTesting = testList.Select(x =>
{
    List<List<int>> messyList = new();
    for (int i = 0; i < x.Count; i++)
    {
        var tempList = x.ToArray().ToList();
        tempList.RemoveAt(i);
        messyList.Add(tempList);
    }
    return messyList;
}
).ToList();
var dampenerChecking = dampenerTesting.Select(SafetyTester.SafetyChecker).ToList();
var dampened = SafetyTester.DampenerConverter(dampenerChecking);
dampened.ForEach(Console.WriteLine);
Console.WriteLine(dampened.Where(x => x.Equals(true)).ToList().Count());
