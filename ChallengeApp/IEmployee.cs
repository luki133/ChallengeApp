

namespace ChallengeApp
{
	public interface IEmployee
	{
		void AddGrade(string grade);
		void AddGrade(float grade);
		void AddGrade(char grade);
		void AddGrade(double grade);
		void AddGrade(int grade);
		void AddGrade(long grade);
		Statistics GetStatistics();


	}
}
