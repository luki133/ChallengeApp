using ChallengeApp;

var employee = new Employee("Łukasz", "Wałowski");

employee.AddGrade("5000");
employee.AddGrade(3);
employee.AddGrade(10);
employee.AddGrade("luki");
employee.AddGrade(9000L);
employee.AddGrade(-5L);
employee.AddGrade(9L);


var statistics = employee.GetStatistics();

Console.WriteLine($"Max Value: {statistics.Max}");
Console.WriteLine($"Min Value: {statistics.Min}");
Console.WriteLine($"Average Value: {statistics.Average:N2}");
Console.WriteLine($"Sum of value: {statistics.Sum}");







