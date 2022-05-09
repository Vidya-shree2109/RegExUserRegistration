using System.Text.RegularExpressions;

namespace UserRegistrationSystem
{
    public class PatternValidation
    {
        public const string FIRSTNAME_REGEX = "^[A-Za-z]{3, }$";
        public bool ValidateFirstName(string name)
        {
            if (Regex.IsMatch(name, FIRSTNAME_REGEX)) ;
            {
                Console.WriteLine("VALID FIRST NAME ! -> " + name);
                return true;
            }
        }
    }
}