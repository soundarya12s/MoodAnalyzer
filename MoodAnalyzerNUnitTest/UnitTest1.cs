using MoodAnalyzerProblem;

namespace MoodAnalyzerNUnitTest
{
    public class Tests
    {
        MoodAnalyzer mood = new MoodAnalyzer();
         [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = "Iam in Sad Mood";
            string actual = mood.AnalyseMood(message);
            Assert.AreEqual(actual,"SAD");
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = "Iam in Any Mood";
            string actual = mood.AnalyseMood(message);
            Assert.Pass(actual,"HAPPY");
        }

    }
}