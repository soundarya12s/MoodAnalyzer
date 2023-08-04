namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string message)
        {
            if (message.Contains("Sad"))
                return "SAD";
            return "HAPPY";
        }
    }
}