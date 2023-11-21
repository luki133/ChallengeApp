/*
* Napisz funkcję która odejmie od listy daną wartość
*/


using System.Threading.Tasks.Sources;

namespace Classes
{
	public class Employee
	{
		String name;
		String surname;
		String nickname;
		String password;
		int age;
		private List<int> score = new List<int>();
		private List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };



		public Employee(String name, String surname, int age)
		{
			this.name = name;
			this.surname = surname;
			this.age = age;
		}

		public Employee(String nickname, string password)
		{
			this.nickname = nickname;
			this.password = password;
		}

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

		public string Name { get { return this.name; } }
		public string Surname { get { return this.surname; } }
		public int Age { get { return this.age; } }
	}
}