

using Classes;
using System.Reflection.Metadata;

namespace ChallengeApp_Test
{
	public class TypeTests
	{
		[Test]
		public void TEST()
		{
			//arrange
			var number1 = 3;
			var number2 = 5;
			//act

			//assert
			Assert.AreEqual(number1, number2);
		}
		private Employee GetUser(String name)
		{
			return new Employee(name);
		}

	}
}
