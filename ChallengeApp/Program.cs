using ChallengeApp;

var employee = new Employee("Łukasz", "Wałowski");

employee.AddGrade(8);
employee.AddGrade(9);
employee.AddGrade(10);
employee.AddGrade(-11);

var statistics = employee.GetStatistics();

Console.WriteLine($"Max Value: {statistics.Max}");
Console.WriteLine($"Min Value: {statistics.Min}");
Console.WriteLine($"Average Value: {statistics.Average:N2}");
Console.WriteLine($"Sum of value: {statistics.Sum}");







