using System.Text.RegularExpressions;

namespace UserRegistrationSystem
{
    public class PatternValidation
    {
        List<string> list = new List<string>();
        const string FIRSTNAME_REGEX = "^[A-Z]{1}[A-Za-z]$";
        const string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        const string MOBILENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
        const string PASSWORD_REGEX = "^[a-zA-z0-9]{8,}";
        const string passwordWithOneUpperCase = "^[A-Z]{1,}[a-z]{8,}$";
        const string passwordWithOneNumber = "^[A-Z]{1,}[a-z]{8,}[0-9]{1,}$";
        const string passwordWithOneSpecialCharacter = "^[A-Z]{1,}[a-z]{8,}[0-9]{1,}[@$#!*&^%]{1}$";
        const string ALL_EMAIL_SAMPLES = "^[a-z]+[.+-]{0,1}[0-9]{1, }+[@][a-z0-1][.][a-z]+([.][a-z]{2, }){0,1}$";
        public bool ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, FIRSTNAME_REGEX))
            {
                Console.WriteLine("First Name Matches ! -> " + firstName);
            }
            else
            {
                Console.WriteLine("Doesn't Match - Verify The First Name !");
            }
            return true;
        }
        public bool ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, FIRSTNAME_REGEX))
            {
                Console.WriteLine("Last Name Matches ! -> " + lastName);
            }
            else
            {
                Console.WriteLine("Doesn't Match - Verify The Last Name !");
            }
            return true;
        }
        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL_REGEX))
            {
                Console.WriteLine("Email Id Matches ! -> " + email);
            }
            else
            {
                Console.WriteLine("Doesn't Match - Verify The Email Id !");
            }
            return true;
        }
        public bool ValidateMobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, MOBILENUMBER_REGEX))
            {
                Console.WriteLine("Mobile Number Matches ! -> " + mobileNumber);
            }
            else
            {
                Console.WriteLine("Doesn't Match - Verify The Mobile Number !");
            }
            return true;
        }
        public bool ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_REGEX))
            {
                Console.WriteLine("Password Matches ! -> " + password);
            }
            else
            {
                Console.WriteLine("Doesn't Match - Verify The Password !");
            }
            return true;
        }
        public bool PasswordValidation_WithOneUpperCase(string password)
        {
            if (Regex.IsMatch(password, passwordWithOneUpperCase))
            {
                Console.WriteLine("Password Matches ! -> " + password);
            }
            else
            {
                Console.WriteLine("Doesn't Match - Verify The Password !");
            }
            return true;
        }
        public bool PasswordValidation_WithOneNumericNumber(string password)
        {
            if (Regex.IsMatch(password, passwordWithOneNumber))
            {
                Console.WriteLine("Password Matches ! -> " + password);
            }
            else
            {
                Console.WriteLine("Doesn't Match - Verify The Password !");
            }
            return true;
        }
        public bool PasswordValidation_WithOneSpecialCharacter(string password)
        {
            if (Regex.IsMatch(password, passwordWithOneSpecialCharacter))
            {
                Console.WriteLine("Password Matches ! -> " + password);
            }
            else
            {
                Console.WriteLine("Doesn't Match - Verify The Password !");
            }
            return true;
        }
        public bool ValidateAllEmailSamples(string email)
        {
            if (Regex.IsMatch(email, ALL_EMAIL_SAMPLES))
            {
                Console.WriteLine("Email Id Matches ! -> " + email);
            }
            return true;
        }
        public bool ValidateMultipleEntryEmailSamplesWithParameterized(string email)
        {
            if (Regex.IsMatch(email, ALL_EMAIL_SAMPLES))
            {
                Console.WriteLine("Email Id Matches ! -> " + email);
                return true;
            }
            else
            {
                Console.WriteLine("Doesn't Match - Verify The Email !");
                return false;
            }
        }
    }
}