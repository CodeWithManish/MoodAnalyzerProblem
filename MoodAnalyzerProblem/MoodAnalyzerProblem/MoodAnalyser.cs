using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        string Message;

        public MoodAnalyser(string Message)
        {
            this.Message = Message;
        }
        public string AnalyseMood()
        {
            if (Message.ToLower().Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "Happy";

            }

        }
    }
}
