using System.Text.RegularExpressions;

namespace UserRegistrationSystem
{
    public class PatternValidation
    {
        public const string FIRSTNAME_REGEX = "^[A-Za-z]{3,}$";
        public const string LASTNAME_REGEX = "^[A-Za-z]{3,}$";
        public bool ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, FIRSTNAME_REGEX)) ;
            {
                Console.WriteLine("VALID FIRST NAME ! -> " + firstName);
                return true;
            }
        }
        public bool ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, LASTNAME_REGEX)) ;
            {
                Console.WriteLine("VALID LAST NAME ! -> " + lastName);
                return true;
            }
        }
    }
}