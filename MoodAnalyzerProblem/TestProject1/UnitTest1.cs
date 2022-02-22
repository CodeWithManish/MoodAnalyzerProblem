using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethodForSadMood()
        {
            string message = "I am in sad Mood";
            string expected = "sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForAnyMood()
        {
            string message = "I am in Any Mood";
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForNullMood()

        {
            string message = "";
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }

    }
}