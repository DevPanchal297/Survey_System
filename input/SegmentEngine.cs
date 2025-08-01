using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_System
{
    enum ageGroup
    {
        Student,
        Professional,
        Retired
    }
    enum incomeGroup
    {
        LowIncome,
        MiddleIncome,
        HighIncome
    }
    class SegmentEngine
    {
        public static string GetAgeGroup(UserProfile user)
        {
            if (user.Age < 18)
            {
                return ageGroup.Student.ToString();
            }
            else if(user.Age > 60)
            {
                return ageGroup.Retired.ToString();
            }
            else
            {
               return ageGroup.Professional.ToString();
            }
        }

        public static string GetIncomeGroup(UserProfile user)
        {
            if (user.MonthlyIncome < 10000)
            {
                return incomeGroup.LowIncome.ToString();
            }
            else if(user.MonthlyIncome > 100000)
            {
                return incomeGroup.HighIncome.ToString();
            }
            else
            {
                return incomeGroup.MiddleIncome.ToString();
            }
        } 
    }
}
