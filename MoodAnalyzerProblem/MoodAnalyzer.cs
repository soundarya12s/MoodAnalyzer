namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string AnalyseMood(string message)
        {
            if (message.Contains("Sad"))
                return "SAD";
            return "HAPPY";
        }
    }
}