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
            try
            {
                if (message.Contains("Sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch(Exception e)
            {
                return "HAPPY";
            }
            
        }
    }
}