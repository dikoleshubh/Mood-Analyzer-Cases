using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Test
{
    public class MoodAnalyzerException : Exception
    {
        ExceptionType type;  //Create instance of custom exception type
        public string message;

        public enum ExceptionType  //enum for define constants
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION
        }
        public MoodAnalyzerException(ExceptionType type, string message) : base(message)  //parameterized constructor 
        {
            this.type = type;
        }
    }
}
