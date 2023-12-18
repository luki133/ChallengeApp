using ChallengeApp;

Console.WriteLine("Witam w programie XYZ do oceny Pracowników");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

var employee = new Employee("Łukasz", "Wałowski");


while (true)
{
	Console.WriteLine("Podaj kolejną ocenę pracownika: ");
	var input = Console.ReadLine();
	if (input == "q") break;
	employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Średnia: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");














