using MoodAnlyserDay21Demo;

namespace MoodAnalyserMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "SAD";
            string message = "I am in Sad Mood";

            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string mood = moodAnalyser.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        [DataRow(null)]
        public void GivenSadMoodShouldReturnSad(string message)
        {
            string expected = "Happy";
            //string message = "I am in Sad Mood";

            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}