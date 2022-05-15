using NUnit.Framework;
using UserRegistrationSystem;

namespace TestRegEx
{
    public class Tests
    {
        [Test]
        public void GivenInputString_WhenTestFirstName_ShouldReturnFirstName()
        {
            PatternValidation input = new PatternValidation();
            bool actualFirstName = input.ValidateFirstName("Vidya");
            Assert.IsTrue(actualFirstName);
        }
        [Test]
        public void GivenInputIsString_WhenTestLastName_ShouldReturnLastName()
        {
            PatternValidation input = new PatternValidation();
            bool actualLastName = input.ValidateFirstName("Shree");
            Assert.IsTrue(actualLastName);
        }
        [Test]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail()
        {
            PatternValidation input = new PatternValidation();
            bool actualEmail = input.ValidateEmail("vidyashree2109@gmail.com");
            Assert.IsTrue(actualEmail);
        }
        [Test]
        public void GivenInputIsString_WhenTestMobileNumber_ShouldReturnMobileNumber()
        {
            PatternValidation input = new PatternValidation();
            bool actualMobileNumber = input.ValidateMobileNumber("+91 9620796715");
            Assert.IsTrue(actualMobileNumber);
        }
        [Test]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword()
        {
            PatternValidation input = new PatternValidation();
            bool actualPassword = input.ValidatePassword("vidya2109");
            Assert.IsTrue(actualPassword);
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPasswordWithOneUpperCase()
        {
            PatternValidation input = new PatternValidation();
            bool actualPassword = input.ValidatePassword("Vidyashree");
            Assert.IsTrue(actualPassword);
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPasswordWithOneNumericValue()
        {
            PatternValidation input = new PatternValidation();
            bool actualPassword = input.ValidatePassword("Vidya21");
            Assert.IsTrue(actualPassword);
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPasswordWithOneSpecialCharacter()
        {
            PatternValidation input = new PatternValidation();
            bool actualPassword = input.ValidatePassword("Vidya21@");
            Assert.IsTrue(actualPassword);
        }
    }
}