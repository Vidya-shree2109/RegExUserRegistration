using NUnit.Framework;
using UserRegistrationSystem;

namespace TestRegEx
{
    public class Tests
    {
        [Test]
        public void GivenInputString_ToCheckFor_FirstNameOfTheUser()
        {
            PatternValidation input = new PatternValidation();
            bool result = input.ValidateFirstName("Vidya");
            Assert.IsTrue(result);
        }
    }
}