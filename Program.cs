// See https://aka.ms/new-console-template for more information
using Survey_System;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Smart Survey System");
        Console.WriteLine("Anytime, press Ctrl + C to exit:\n");

        bool flag = true;int totalusers = 0;
        Dictionary<string, int> userProfession = new Dictionary<string, int>
        {
                { "Student", 0 },
                { "Professional", 0 },
                { "Retired", 0 }
        };
        List<Dictionary<string, Dictionary<string, string>>> surveyResponses = new List<Dictionary<string, Dictionary<string, string>>>();
        do
        {
            UserProfile curUser = UserProfile.GetUserProfile();
            string ageGroup = SegmentEngine.GetAgeGroup(curUser);
            string monthlyIncome = SegmentEngine.GetIncomeGroup(curUser);
            Dictionary<string, string> qxnAns = SurveyManager.GetSurveyResponse(ageGroup);
            Dictionary<string, Dictionary<string, string>> curSurveyResponse = new Dictionary<string, Dictionary<string, string>> { { curUser.Name, qxnAns } };
            surveyResponses.Add(curSurveyResponse);

            userProfession[ageGroup]++;
            Console.WriteLine();totalusers++;
            Console.Write("Do You want to add another survey? (Y/N):");
            string input = Console.ReadLine();
            Console.WriteLine();
            if (input.Trim() == "N") { flag = false; }
        }
        while (flag);
            Console.WriteLine("Total Number of Users: {0}",totalusers);
            Console.WriteLine($"Students: {userProfession["Student"]}, Professional: {userProfession["Professional"]}, Retired: {userProfession["Retired"]}\n");
            UserRepository.PritQuestionsAnswers(surveyResponses);
            UserRepository.StoreQuestionsAnswers(surveyResponses);
    }
}