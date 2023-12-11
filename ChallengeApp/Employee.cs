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

		public Statistics GetStatisticsWithForEach()
		{
			var statisticsForEach = new Statistics();

			statisticsForEach.Average = 0;
			statisticsForEach.Max = float.MinValue;
			statisticsForEach.Min = float.MaxValue;
			
			foreach (var grade in this.grades)
			{
				statisticsForEach.Max = Math.Max(statisticsForEach.Max, grade);
				statisticsForEach.Min = Math.Min(statisticsForEach.Min, grade);
				statisticsForEach.Average += grade;
			}

			statisticsForEach.Sum = this.grades.Sum();
			statisticsForEach.Average /= this.grades.Count();

			return statisticsForEach;
		}

		public Statistics GetStatisticsWithFor()
		{
			var statisticsWithFor = new Statistics();

			statisticsWithFor.Average = 0;
			statisticsWithFor.Max = float.MinValue;
			statisticsWithFor.Min = float.MaxValue;
			

			for (var index = 0; index < this.grades.Count; index++)
			{
				statisticsWithFor.Max = Math.Max(statisticsWithFor.Max, this.grades[index]);
				statisticsWithFor.Min = Math.Min(statisticsWithFor.Min, this.grades[index]);
				statisticsWithFor.Average += this.grades[index];
			}
			statisticsWithFor.Sum = this.grades.Sum();
			statisticsWithFor.Average /= this.grades.Count();

			return statisticsWithFor;

		}

		public Statistics GetStatisticsWithDoWhile()
		{
			var statisticsDoWhile = new Statistics();

			statisticsDoWhile.Average = 0;
			statisticsDoWhile.Max = float.MinValue;
			statisticsDoWhile.Min = float.MaxValue;
			var index = 0;

			do
			{
				statisticsDoWhile.Max = Math.Max(statisticsDoWhile.Max, this.grades[index]);
				statisticsDoWhile.Min = Math.Min(statisticsDoWhile.Min, this.grades[index]);
				statisticsDoWhile.Average += grades[index];
				index++;
			} while(index < this.grades.Count);

			statisticsDoWhile.Sum = this.grades.Sum();
			statisticsDoWhile.Average /= this.grades.Count;
			index++;

			return statisticsDoWhile;
		}

		public Statistics GetStatisticsWithWhile()
		{
			var statisticsWithWhile = new Statistics();

			statisticsWithWhile.Average = 0;
			statisticsWithWhile.Max = float.MinValue;
			statisticsWithWhile.Min = float.MaxValue;
			var index = 0;

			while(index < this.grades.Count)
			{
				statisticsWithWhile.Max = Math.Max(statisticsWithWhile.Max, this.grades[index]);
				statisticsWithWhile.Min = Math.Min(statisticsWithWhile.Min, this.grades[index]);
				statisticsWithWhile.Average += grades[index];
				index++;

			}

			statisticsWithWhile.Sum = this.grades.Sum();
			statisticsWithWhile.Average /= this.grades.Count;
			

			return statisticsWithWhile;
			
		}

	
	}
}
