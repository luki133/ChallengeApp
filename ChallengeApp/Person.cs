

namespace ChallengeApp
{
	public abstract class Person
	{
		public Person(string name, string surname, char gender)
		{
			this.Name = name;
			this.Surname = surname;
			this.Gender = gender;
		}
		public string Name { get; set; }
		public string Surname { get; set; }
		public char Gender { get; set; }
	}
}
