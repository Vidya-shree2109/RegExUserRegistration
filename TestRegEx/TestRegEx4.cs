using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationSystem;

namespace TestRegEx
{
    public class TestRegEx4
    {
        [Test]
        public void GivenInputString_ToCheckFor_MobileNumberOfTheUser()
        {
            PatternValidation input = new PatternValidation();
            bool result = input.ValidateMobileNumber("91 9108330581");
            Assert.IsTrue(result);
        }
    }
}
