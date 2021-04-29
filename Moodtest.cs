using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Test
{
    public class MoodAnalyzer
    {
        public string message;  


        public MoodAnalyzer(string message) //parameterized constructor for intilizing instance member
        {
            this.message = message;
        }
        public string Analyzer()  //Analyzer method analyze mood using if else
        {
            
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            
            
        }
    }
}
