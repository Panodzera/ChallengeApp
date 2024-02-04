namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void IntTypeTest()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;
            //act
            //assert
            Assert.AreEqual(number1 + number2, 3);
        }
        [Test]
        public void FloatTypeTest()
        {
            //arrange
            float temp1 = 2.2f;
            float temp2 = 4.4f;
            float average = temp1 + temp2 / 2;
            //act
            //assert
            Assert.AreEqual(temp1 + temp2 / 2, average);
        }
        [Test]
        public void StringTypeTest()
        {
            //arrange
            string name1 = "Monika";
            string name2 = "Monika";
            //act
            //assert
            Assert.AreEqual(name1, name2);
        }
        [Test]
        public void ReferenceTypeTest()
        {
            //arrange
            var employee1 = GetEmployee("Ewa", "Kot", 33);
            var employee2 = GetEmployee("Ewa", "Kinga", 27);
            //act
            //assert
            Assert.AreNotEqual(employee1, employee2);
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
