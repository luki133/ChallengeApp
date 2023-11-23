/*
* Napisz funkcję która odejmie od listy daną wartość
*/

using System.Threading.Tasks.Sources;

namespace Classes
{
	public class Employee
	{
		private List<int> score = new List<int>();

		public Employee(String name, String surname, int age)
		{
			this.Name = name;
			this.Surname = surname;
			this.Age = age;
		}

		public Employee(String name)
		{
			this.Name = name;
		}

		public string Name { get; private set; }
		public string Surname { get;  private set; }
		public int Age { get; private set; }

		public void AddScore(int points)
		{
			this.score.Add(points);
		}

		public void SubScore(int value)
		{
			int Sum = this.score.Sum();
			int Sub = Sum - value;
			this.score.Clear();
			this.score.Add(Sub);
		}
		public int Score
		{
			get
			{
				return this.score.Sum();
			}
		}
	}
}