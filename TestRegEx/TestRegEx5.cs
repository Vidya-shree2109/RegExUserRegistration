using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationSystem;

namespace TestRegEx
{
    public class TestRegEx5
    {
        [Test]
        public void GivenInputString_ToCheckFor_PasswordOfTheUser()
        {
            PatternValidation input = new PatternValidation();
            bool result = input.ValidatePassword("vidya.21Shree#&*");
            Assert.IsTrue(result);
        }
    }
}
