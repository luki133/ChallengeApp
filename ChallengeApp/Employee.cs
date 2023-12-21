﻿namespace ChallengeApp
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
			else if (grade < 0)
			{
				throw new Exception("Value of grade is less than 0");
			}
			else
			{
				throw new Exception("Value of grade is bigger than 0");
			}

			switch (grade)
			{
				case 'A':
				case 'a':
				this.grades.Add(100);
				break;
				case 'B':
				case 'b':
				this.grades.Add(80);
				break;
				case 'C':
				case 'c':
				this.grades.Add(60);
				break;
				case 'D':
				case 'd':
				this.grades.Add(40);
				break;
				case 'E':
				case 'e':
				this.grades.Add(20);
				break;
				default:
					throw new Exception("Wrong letter");
			}
		}
		public void AddGrade(String grade)
		{
			if (float.TryParse(grade, out float result))
			{
				this.AddGrade(result);
			}

			else if (char.TryParse(grade, out char Result))
			{
				this.AddGrade(Result);
			}
			else
				throw new Exception("That variable cannot be change on float");



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
			{
				throw new Exception("Value of grade is less than 0");
			}
			else
			{
				throw new Exception("Value of grade is bigger than 100");
			}

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

			switch (statistics.Average)
			{
				case var average when average >= 80:
					statistics.AverageLetter = 'A';
					break;
				case var average when average >= 60:
					statistics.AverageLetter = 'B';
					break;
				case var average when average >= 40:
					statistics.AverageLetter = 'C';
					break;
				case var average when average >= 20:
					statistics.AverageLetter = 'D';
					break;
				default:
					statistics.AverageLetter = 'E';
					break;
			}

			return statistics;
		}
	}
}
