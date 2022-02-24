using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // Using Reflection
        [TestMethod]
        public void ReflectionReturnMoodAnalyseObject()
        {

            object expected = new MoodAnalyser();
            object obj = new MoodAnalyseFactory().CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser");
            var objtype = obj.GetType();
            var expectedType = expected.GetType();
            Assert.AreEqual(expectedType, objtype);
        }

        [TestMethod]
        public void ImproperClassShouldThrowException()
        {
            object expected = new MoodAnalyser();
            try
            {
                var obj = new MoodAnalyseFactory().CreateMoodAnalyserObject("MoodAnalyzerProblem.Mood", "Mood");
               
            }
            catch (Exception e)
            {
                Assert.AreEqual("No such a class", e.Message);
            }
        }

        [TestMethod]
        public void ConstructorNotProperClassShouldThrowException()
        {
            object expected = new MoodAnalyser();
            try
            {
                var obj = new MoodAnalyseFactory().CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser");
               
            }
            catch(Exception e)
            {
                Assert.AreEqual("No such a Constructor", e.Message);
            }
        }
    }
}