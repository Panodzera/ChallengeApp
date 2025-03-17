namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void MinStatistics()
        {
            //arrange
            var employee = new Employee("Adam", "Kamizelich");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(statistics.Min, 2);
        }

        [Test]
        public void MaxStatistics()
        {
            //arrange
            var employee = new Employee("Adam", "Kamizelich");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(statistics.Max, 6);
        }

        [Test]
        public void AverageStatistics()
        {
            //arrange
            var employee = new Employee("Adam", "Kamizelich");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(statistics.Average, 3,33f);
        }
    }
}