using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTestProject2
{

/* TC 6.1:- Given Happy Message Using Reflection When Proper Should Return HAPPY Mood
         * TC 6.2:- Given Happy Message When Improper Method Should Throw MoodAnalysisException
        */
        [TestMethod]
        public void GivenHappyMoodShouldReturnHappy()
        {
            string message = "I am in happy mood";
            MoodAnalyzer expected = new MoodAnalyzer("I am in happy mood");
            object obj = null;
            try
            {
                MoodAnalyzerFactory Factory = new MoodAnalyzerFactory();
                obj = Factory.InvokeAnalyzerMethod(message, "Analyzer");
            }
            catch (MoodAnalyzerException exception)
            {

                throw new Exception(exception.Message);
            }
            obj.Equals(expected);       
        }
 }
