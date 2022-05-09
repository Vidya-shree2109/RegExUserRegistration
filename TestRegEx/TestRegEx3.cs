using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationSystem;

namespace TestRegEx
{
    public class TestRegEx3
    {
        [Test]
        public void GivenInputString_ToCheckFor_EmailIdOfTheUser()
        {
            PatternValidation input = new PatternValidation();
            bool result = input.ValidateEmailId("vidyashree2109@gmail.com");
            Assert.IsTrue(result);
        }
    }
}