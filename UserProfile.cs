using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_System
{

    enum Gender
    {
        Male,
        Female,
        Other
    }
    class UserProfile
    {
        public string Name;
        public int Age;
        public Gender Gender;
        public string? Location;
        public double MonthlyIncome;

        public static UserProfile GetUserProfile()
        {
            UserProfile newUser = new UserProfile();
            do
            {
                Console.Write("Name [Required] (Only letters and spaces): ");
                newUser.Name = Console.ReadLine();
            } while (!IsValidName(newUser.Name));
            do
            {
                Console.Write("Age [Required] (Number < 120): ");
            }
            while (!TryReadValidAge(out newUser.Age));
            do
            {
                Console.Write("Gender [Required] (Male/Female/Other): ");
            } while (!TryParseGender(out newUser.Gender));

            Console.Write("Location (Optional): ");
            newUser.Location = Console.ReadLine();

            do
            {
                Console.Write("Monthly Income [Required] (Non-negative number): ");
            }
            while (!TryReadValidIncome(out newUser.MonthlyIncome));

            return newUser;
        }

        static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;

            foreach (char c in name)
            {
                if (!(char.IsLetter(c) || c == ' '))
                    return false;
            }
            return true;
        }

        static bool TryReadValidAge(out int age)
        {
            string? input = Console.ReadLine();
            return int.TryParse(input, out age) && age > 0 && age < 120;
        }

        static bool TryReadValidIncome(out double income)
        {
            string? input = Console.ReadLine();
            return double.TryParse(input, out income) && income >= 0;
        }
        static bool TryParseGender(out Gender gender)
        {
            string? input = Console.ReadLine();
               return Enum.TryParse<Gender>(input, true, out gender) &&
                Enum.IsDefined(typeof(Gender), gender);
        }
    }
}
