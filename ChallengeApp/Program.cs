using Classes;
Employee Marek = new Employee("Marek", "Kowalski", 35);
Employee Paweł = new Employee("Paweł", "Nowak", 33);
Employee Andrzej = new Employee("Andrzej", "Olszański", 39);



Marek.AddScore(4);
Marek.AddScore(7);
Marek.AddScore(8);
Marek.AddScore(9);

Paweł.AddScore(4);
Paweł.AddScore(2);
Paweł.AddScore(8);
Paweł.AddScore(9);

Andrzej.AddScore(3);
Andrzej.AddScore(6);
Andrzej.AddScore(7);
Andrzej.AddScore(4);




int MaxScore = -1;
Employee UserWithMaxResult = null;

List<Employee> users = new List<Employee>()
{
	Marek, Paweł, Andrzej
};

foreach (var user in users)
{
	if (user.Score > MaxScore)
	{
		MaxScore = user.Score;
		UserWithMaxResult = user;

	}
}

Console.WriteLine("Imię:" + UserWithMaxResult.Name + " Nazwisko:" + UserWithMaxResult.Surname + " Wiek:"  +UserWithMaxResult.Age + " Wynik:" + UserWithMaxResult.Score);


