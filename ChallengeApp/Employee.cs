namespace ChallengeApp
{
	public class Employee
	{
		private List<float> grades = new List<float>();
		public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
		public string Surname { get; private set; }
		
		public void AddGrade(float grade) 
		{
			if (grade >= 0 && grade <= 100)
			{
				this.grades.Add(grade);
			}
			else 
			{ 
				Console.WriteLine("Invalid grade value"); 
			}
			
		}
		public void AddGrade(string grade)
		{
			if(float.TryParse(grade, out float result))
			{
				this.AddGrade(result);
			}
			else
			{
				Console.WriteLine("String cannot be float");
			}
		}
		public void AddGrade(double grade)
		{
			double numberAdd = (float)grade;
			this.AddGrade(numberAdd);
		}
		public void AddGrade(int grade)
		{
			this.AddGrade((float)grade);
		}

		public void AddGrade(long grade)
		{
			var number = (float)grade;

			if (number >= 0 && number <= 100)
				this.grades.Add(number);
			else if (number < 0)
				Console.WriteLine("Value of grade is less than 0");
			else
				Console.WriteLine("Value of grade is bigger than 100");
		}
		public Statistics GetStatistics()
		{
			var statistics = new Statistics();
			statistics.Average = 0;
			statistics.Max = float.MinValue;
			statistics.Min = float.MaxValue;

			foreach (var grade in this.grades)
			{
				statistics.Max = Math.Max(statistics.Max, grade);
				statistics.Min = Math.Min(statistics.Min, grade);
				statistics.Average += grade;
			}

			statistics.Sum = this.grades.Sum();
			statistics.Average /= this.grades.Count;
			
			return statistics;
		}
	}
}
