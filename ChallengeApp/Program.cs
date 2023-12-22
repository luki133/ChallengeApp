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

	try
	{
		employee.AddGrade(input);
	}
	catch (Exception e)
	{
		Console.WriteLine(e.Message);
		Console.WriteLine();
	}
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Średnia: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Sum: {statistics.Sum}");














