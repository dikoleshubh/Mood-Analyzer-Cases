
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTestProject2
{

        [TestMethod]
        public void GivenMoodAnalyseClass_ShouldReturn_MoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
            object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }

      
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongClassName_ShouldReturn_NOClassException()
        {
            string expected = "Class not found";
            try
            {
                string message = null;              
                object moodAnalyser = new MoodAnalyzer(message);
                MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongConstructorName_ShouldReturn_NoConstructorException()
        {
            string expected = "Constructor not found";
            try
            {
                string message = null;                
                object moodAnalyser = new MoodAnalyzer(message);
                MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
