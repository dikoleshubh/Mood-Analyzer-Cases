using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1  //Class
    {
        // SAD CASE
                    
        [TestMethod]
        public void AnalyseMood_ShouldReturn_Sad()
        {
            //Arraneg
            string expected = "sad";
            MoodAnalyzer obj = new MoodAnalyzer("I am in sad Mood");
            //Act
            string actual = obj.Analyzer();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //HAPPY. CASE
                    
       
        [TestMethod]
        public void Given_Happymood_Expecting_Happy_Result()  //Method
        {
            MoodAnalyzer mood = new MoodAnalyzer("I am in happy mood"); //Create object and arrange 
            string expected = "happy";

            string actual = mood.Analyzer();    //act
            Assert.AreEqual(expected, actual);  //Assert
        }

        /* UC2:- Handle Exception Invalid Mood
         */
        [TestMethod]
        public void Given_Nullmood_Expecting_Exception_Result()  //Method
        {
            MoodAnalyzer mood = new MoodAnalyzer(null); //Create object and arrange 
            string expected = "Object reference not set to an instance of an object.";

            string actual = mood.Analyzer();    //act

            Assert.AreEqual(expected, actual);  //Assert
        }

        [TestMethod]
        public void Given_Nullmood_Expecting_happy_Result()  //Method
        {
            MoodAnalyzer mood = new MoodAnalyzer(null); //Create object and arrange 
            string expected = "happy";

            string actual = mood.Analyzer();    //act

            Assert.AreEqual(expected, actual);  //Assert
        }

      
        [TestMethod]
        public void Given_Nullmood_Using_CustomExpection_Return_Null()  //Method
        {
            MoodAnalyzer mood = new MoodAnalyzer(null); //Create object and arrange 
            //string actual = "";
            string actual = "";

            try
            {
                actual = mood.Analyzer();    //act

            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual("Mood should not be null", exception.Message);  //Assert
            }
        }

       
        [TestMethod]
        public void Given_Emptymood_Using_CustomExpection_Return_Empty()  //Method
        {

            string actual = "";

            try
            {
                string message = string.Empty;
                MoodAnalyzer mood = new MoodAnalyzer(message); //Create object and arrange 
                actual = mood.Analyzer();    //act

            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual("Mood should not be empty", exception.Message);  //Assert
            }

        }
    }
}
