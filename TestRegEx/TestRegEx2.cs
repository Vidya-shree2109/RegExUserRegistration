using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationSystem;

namespace TestRegEx
{
    public class TestRegEx2
    {
        [Test]
        public void GivenInputString_ToCheckFor_LastNameOfTheUser()
        {
            PatternValidation input = new PatternValidation();
            bool result = input.ValidateLastName("Shree");
            Assert.IsTrue(result);
        }
    }
}