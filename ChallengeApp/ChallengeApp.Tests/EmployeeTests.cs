namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmpCollectScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("John", "Grey", 40);
            employee.AddScore(7);
            employee.AddScore(8);
            //act
            var result = employee.Result;
            //assert
            Assert.AreEqual(15, result);
        }
        [Test]
        public void WhenEmpCollectAllScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("John", "Grey", 40);
            employee.AddScore(9);
            employee.AddScore(-4);
            //act
            var result = employee.Result;
            //assert
            Assert.AreEqual(5, result);
        }
        [Test]
        public void WhenEmpCollectPenalty_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("John", "Grey", 40);
            employee.AddScore(-3);
            employee.AddScore(-2);
            //act
            var result = employee.Result;
            //assert
            Assert.AreEqual(-5, result);
        }
        [Test]
        public void WhenEmpCollectZero_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("John", "Grey", 40);
            employee.AddScore(4);
            employee.AddScore(4);
            employee.AddScore(-8);
            //act
            var result = employee.Result;
            //assert
            Assert.AreEqual(0, result);
        }
    }
}