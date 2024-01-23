﻿

namespace ChallengeApp
{
	public interface IEmployee
	{
		string Name { get; }
		string Surname { get; }
		string Gender { get; }
		void AddGrade(string grade);
		void AddGrade(float grade);
		void AddGrade(char grade);
		void AddGrade(double grade);
		void AddGrade(int grade);
		void AddGrade(long grade);
		Statistics GetStatistics();


	}
}
