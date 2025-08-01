using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_System
{
    class SurveyManager
    {
        public static Dictionary<string, string> GetSurveyResponse(string ageGroup)
        {
            Dictionary<string, List<string>> questions = new()
            {
                ["Student"] = new()
            { "Do you use online learning platforms?",
            "What subject do you enjoy most?" },
                ["Professional"] = new()
            { "Are you satisfied with your job?",
             "Do you work remotely?" },
                ["Retired"] = new()
            { "Do you volunteer regularly?",
              "What hobbies keep you engaged?" }
            };
            Dictionary<string, string> qxnAns = new Dictionary<string, string>();
            if (questions.ContainsKey(ageGroup))
            {
                string answer = string.Empty;
                foreach (var question in questions[ageGroup])
                {
                    do
                    {
                        Console.WriteLine(question);
                        answer = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(answer));
                    qxnAns.Add(question, answer);
                }
            }
            return qxnAns;
        }
    }
}
