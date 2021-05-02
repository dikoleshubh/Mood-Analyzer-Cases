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

      

        /* TC7.1:- Set Happy Message with Reflector Should Return HAPPY.
         *         - To pass this TC, Use Reflector to Set the Field Value and Invoke Method using Reflection 
         *         and Assert HAPPY Mood.
         */
        [TestMethod]
        public void GivenMessageDynamically_returnMessage()
        {
            string expected = "Iam so happy";

            string actual = MoodAnalyzerFactory.SetField("Iam so happy", "message");
            Assert.AreEqual(expected, actual);
        }


      
        [TestMethod]
        public void GivenImproperFieldName_ThrowNoSuchFieldException()
        {

            string expected = "No Such Field";
            try
            {
                MoodAnalyzerFactory.SetField("Iam so happy", "wrongMessage");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }
        /* TC 7.3:- Setting Null Message with Reflector Should Throw Exception.
                    - To pass this TC, Use Reflector to Set the Field Value to null and check Exception.
        */

        [TestMethod]
        public void GivenNullMessage_ThrowException()
        {
            string expected = "Mood should not be NULL";

            try
            {
                MoodAnalyzerFactory.SetField(null, "message");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }

    }
        
