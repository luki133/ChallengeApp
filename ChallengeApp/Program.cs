using ChallengeApp;

Console.WriteLine("Witam w programie XYZ do oceny Pracowników");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();


var supervisor = new Supervisor("Mateusz", "Nowak", "M");

while (true)
{
	Console.WriteLine("Podaj ocenę kierownika: ");
	var input = Console.ReadLine();
	if (input == "q") break;

	try
	{
		supervisor.AddGrade(input);
	}
	catch (Exception e)
	{
		Console.WriteLine(e.Message);
		Console.WriteLine();
	}
}

var statistics = supervisor.GetStatistics();
Console.WriteLine($"Średnia: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Sum: {statistics.Sum}");
















