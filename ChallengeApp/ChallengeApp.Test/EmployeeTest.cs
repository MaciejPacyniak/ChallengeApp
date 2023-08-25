// Ignore Spelling: App

using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void AddGrades_ShouldreturnCorrectAverageletter()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade(70);
            employee.AddGrade('b');
            employee.AddGrade(30);
            employee.AddGrade('d');
            employee.AddGrade(10);

            // act
            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void AddGrades_ShouldreturnCorrectResult()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade('C');
            employee.AddGrade('d');
            employee.AddGrade('E');

            // act
            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(60, statistics.Average);
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void AddGrades_ShouldreturnCorrectResult2()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('A');
            employee.AddGrade(65);
            employee.AddGrade('C');
            employee.AddGrade(35);
            employee.AddGrade(20);

            // act
            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(56, statistics.Average);
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
        }
    }
}