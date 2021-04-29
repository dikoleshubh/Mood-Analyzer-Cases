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


        public MoodAnalyzer(string message) 
        {
            this.message = message;
        }
        public string Analyzer()  //Analyzer method find mood
        {
            try  // Handling Exception
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
            catch
            //UC2 use --> //catch(NullReferenceException ex)
            {
                //UC2 use -->// return ex.Message;
                return "happy";
            }
        }
    }
}
