using Classes;
namespace Klasy.Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void AddScoreUserTest()
		{
			//Assert.Pass();

			//arrange
			var user = new Employee("£ukasz", "Wa³owski", 28);
			user.AddScore(3);
			user.AddScore(9);
			user.AddScore(5);
			user.SubScore(14);


			//act
			var result = user.Score;

			//assert
			Assert.AreEqual(3, result);
		}

	}
}