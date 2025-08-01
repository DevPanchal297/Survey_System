using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Survey_System
{
    class UserRepository
    {
        public static void PritQuestionsAnswers(List<Dictionary<string, Dictionary<string, string>>> surveyResponses)
        {
            Console.WriteLine("Survey responses have been stored successfully.\n");
            foreach (var response in surveyResponses)
            {
                foreach (var userResponse in response)
                {
                    Console.WriteLine($"User: {userResponse.Key}");
                    foreach (var answer in userResponse.Value)
                    {
                        Console.WriteLine($"Question: {answer.Key}, Answer: {answer.Value}");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void StoreQuestionsAnswers(List<Dictionary<string, Dictionary<string, string>>> surveyResponses)
        {
            string filePath = "../../../users.json";
            string content = JsonSerializer.Serialize(surveyResponses, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, content);
            Console.WriteLine("Responses saved to File successfully.");
        }
    }
}
