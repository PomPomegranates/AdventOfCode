// See https://aka.ms/new-console-template for more information
using AdventDayTwo;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DayTwoTests")]
Console.WriteLine("Hello, World!");

List<List<int>> fullList = FileReader.UnpackLines("./AdventDataDay2.txt");
List<bool> safeChecking = SafetyTester.SafetyChecker(fullList);
Console.WriteLine(safeChecking.Where(x => x.Equals(true)).ToList().Count());
