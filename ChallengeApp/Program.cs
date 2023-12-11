using ChallengeApp;

var employee = new Employee("Łukasz", "Wałowski");

employee.AddGrade(3);
employee.AddGrade(10);
employee.AddGrade(90);
employee.AddGrade(9);

var statistics = employee.GetStatistics();
var statisticsDoWhile = employee.GetStatisticsWithDoWhile();
var statisticsWhile = employee.GetStatisticsWithWhile();
var statisticsFor = employee.GetStatisticsWithFor();
var statisticsForEach = employee.GetStatisticsWithForEach();


Console.WriteLine($"Max value: {statistics.Max}"); 
Console.WriteLine($"Min value: {statistics.Min}");
Console.WriteLine($"Average value: {statistics.Average:N2}");
Console.WriteLine($"Sum of value: {statistics.Sum}");

Console.WriteLine("-----------------------");

Console.WriteLine($"Max value: {statisticsDoWhile.Max}");
Console.WriteLine($"Min value: {statisticsDoWhile.Min}");
Console.WriteLine($"Average value: {statisticsDoWhile.Average:N2}");
Console.WriteLine($"Sum of value: {statisticsDoWhile.Sum}");

Console.WriteLine("-----------------------");

Console.WriteLine($"Max value: {statisticsWhile.Max}");
Console.WriteLine($"Min value: {statisticsWhile.Min}");
Console.WriteLine($"Average value: {statisticsWhile.Average:N2}");
Console.WriteLine($"Sum of value: {statisticsWhile.Sum}");

Console.WriteLine("-----------------------");

Console.WriteLine($"Max value: {statisticsFor.Max}");
Console.WriteLine($"Min value: {statisticsFor.Min}");
Console.WriteLine($"Average value: {statisticsFor.Average:N2}");
Console.WriteLine($"Sum of value: {statisticsFor.Sum}");

Console.WriteLine("-----------------------");

Console.WriteLine($"Max value: {statisticsForEach.Max}");
Console.WriteLine($"Min value: {statisticsForEach.Min}");
Console.WriteLine($"Average value: {statisticsForEach.Average:N2}");
Console.WriteLine($"Sum of value: {statisticsForEach.Sum}");







