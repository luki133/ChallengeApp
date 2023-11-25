using Classes;


namespace ChallengeApp_Test
{
	public class TypeTests
	{
		[Test]
		public void TestIntNumbers()
		{
			//arrange
			int numberTest1 = 5;
			int numberTest2 = 5;
			//act

			//assert
			Assert.AreEqual(numberTest1, numberTest2);
		}
		private Employee GetUser(String name)
		{
			return new Employee(name);
		}

		[Test]
		public void TestCreateEmp()
		{
			//arrange
			var UserTest = GetUser("Mateusz");
			var UserTest1 = GetUser("Mateusz");
			//act

			//assert
			Assert.AreEqual(UserTest.Name, UserTest1.Name);
		}

		

		[Test]
		public void TestEmployee()
		{
			var emp1 = new Employee("Marek", "Kowalski", 65);
			var emp2 = new Employee("Karol", "Wiśniewski", 65);

			Assert.AreEqual(emp1.Age, emp2.Age);
			Assert.AreNotEqual(emp1.Surname, emp2.Surname);

		}
		
		[Test]
		public void TestFloatNumbers()
		{
			float numberTest1 = 68459;
			float numberTest2 = 87694;
			
			Assert.AreNotEqual(numberTest1, numberTest2);
		}
		[Test]
		public void TestNameString()
		{
			String imie1 = "Lukasz";
			String imie2 = "Lukasz";
			
			Assert.AreEqual(imie1, imie2);
		}

		
		

	}
}
