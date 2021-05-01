using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Test
{
    public class MoodAnalyzerFactory
    {

        /* UC5:- create Parameter Constructor Use Reflection to Create MoodAnalyser with Parameter Constructor.
                 - Use MoodAnalyserFactory to create MoodAnalyser Object with Message Parameneter.
         */
        public Object CreateMoodAnalyzerParameterObject(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyzer);

            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {

                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorObject = type.GetConstructor(new[] { typeof(string) });
                    Object instance = constructorObject.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.CLASS_NOT_FOUND, "Class not found");

            }
        }

    }
}
