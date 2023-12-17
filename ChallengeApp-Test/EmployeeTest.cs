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
			employee.AddGrade('a');
			employee.AddGrade(89);
			employee.AddGrade(92);
			employee.AddGrade('E');

			//act
			var result = employee.GetStatistics();
			//Assert
			Assert.AreEqual(20, result.Min);
		}

		[Test]
		public void TestMaxValue()
		{
			var employee = new Employee("Łukasz", "Wałowski");
			employee.AddGrade('A');
			employee.AddGrade(81);
			employee.AddGrade('E');
			employee.AddGrade(50);

			var result = employee.GetStatistics();

			Assert.AreEqual(100, result.Max);
		}

		[Test]
		public void TestAverageValue()
		{
			var employee = new Employee("Mateusz", "Dzwonkowski");
			employee.AddGrade('e');
			employee.AddGrade(23);
			employee.AddGrade(45);
			employee.AddGrade('d');

			var result = employee.GetStatistics();

			Assert.AreEqual(32, result.Average);
		}

		[Test]
		public void TestSumValue()
		{
			var employee = new Employee("Jakub", "Strzygała");
			employee.AddGrade(61);
			employee.AddGrade(87);
			employee.AddGrade('D');
			employee.AddGrade('B');

			var result = employee.GetStatistics();

			Assert.AreEqual(268, result.Sum);
		}
	}
}
