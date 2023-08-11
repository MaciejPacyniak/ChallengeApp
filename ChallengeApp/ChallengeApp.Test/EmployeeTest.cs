using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoPoints_ShouldCorrectResult()
        {
            // arrange
            var user = new Employee();
            user.AddPoint(5);
            user.NegativePoint(1);
            // act
            var result = user.Sum();
            // assert
            Assert.AreEqual(4, result);
        }
    }
}