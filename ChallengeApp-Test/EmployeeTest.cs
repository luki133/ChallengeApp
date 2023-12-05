using ChallengeApp;

namespace ChallengeApp_Test
{
	public class TypeTests
	{
		[Test]
		public void TestMinValue() 
		{
			//arrange
			var employee = new Employee("Marcin", "Wawrzycki");
			employee.AddGrade(6);
			employee.AddGrade(8);
			employee.AddGrade(9);
			employee.AddGrade(5);

			//act
			var result = employee.GetStatistics();
			//Assert
			Assert.AreEqual(5, result.Min);
		}

		[Test]
		public void TestMaxValue()
		{
			var employee = new Employee("Łukasz", "Wałowski");
			employee.AddGrade(6);
			employee.AddGrade(8);
			employee.AddGrade(9);
			employee.AddGrade(5);

			var result = employee.GetStatistics();

			Assert.AreEqual(9, result.Max);
		}

		[Test]
		public void TestAverageValue()
		{
			var employee = new Employee("Mateusz", "Dzwonkowski");
			employee.AddGrade(6);
			employee.AddGrade(8);
			employee.AddGrade(9);
			employee.AddGrade(5);

			var result = employee.GetStatistics();

			Assert.AreEqual(7, result.Average);
		}

		[Test]
		public void TestSumValue()
		{
			var employee = new Employee("Jakub", "Strzygała");
			employee.AddGrade(6);
			employee.AddGrade(8);
			employee.AddGrade(9);
			employee.AddGrade(5);

			var result = employee.GetStatistics();

			Assert.AreEqual(28, result.Sum);
		}
	}
}
