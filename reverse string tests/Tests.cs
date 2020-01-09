using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ReverseString;

namespace ReverseStringTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("a@@c-b","b@@c-a")]
        [TestCase("ab@--cd", "dc@--ba")]
        public void Reverse_string_without_moving_specialCharacters(string value,string expected)
        {
            //Arrange
           
            HomeWork sut = new HomeWork();
            //Act

            string actual = sut.ReverseString(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
