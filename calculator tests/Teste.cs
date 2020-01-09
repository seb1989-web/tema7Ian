using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp;

namespace Tests
{
    [TestFixture]
    public class Teste
    {
        
        [Test]
        [TestCase(2,2,4)]
        [TestCase(4,5,9)]
        [TestCase(23,2,25)]
        [TestCase(45,55,100)]
        public void Should_Add_2Numbers_and_display_ExpectedResult(int nr1, int nr2, int expected )
        {
            //Arrange
            Calculator<int> sut = new Calculator<int>();
            //Act
            int actual = sut.Add(nr1, nr2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        [Test]
        [TestCase(45, 55, 99)]
        public void Should_Add_2Numbers_and_display_WrongResult(int nr1, int nr2, int expected)
        {
            //Arrange
            Calculator<int> sut = new Calculator<int>();
            //Act
            int actual = sut.Add(nr1, nr2);
            //Assert
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        [TestCase(2,2,4)]
        public void Should_add_2Numbers_and_Display_boolResult1(int nr1, int nr2, int expected)
        {
            //Arrange
            Calculator<int> sut = new Calculator<int>();
            //Act
            int actual = sut.Add(nr1, nr2);
            //Assert
            Assert.IsTrue(expected == actual);
        }
        [Test]
        [TestCase(2,2,3)]
        public void Should_add_2Numbers_and_Display_Bool_result2(int nr1,int nr2, int expected)
        {
            //Arrange
            Calculator<int> sut = new Calculator<int>();
            //Act
            int actual = sut.Add(nr1, nr2);
            //Assert
            Assert.IsFalse(expected == actual);
        }

        [Test]
        [TestCase(2.5,0.5,2)]
        [TestCase(99.9,0.9,99)]
        [TestCase(3.4,1.4,2)]
        [TestCase(1.1,0.1,1)]
        public void Should_Subtract_2Numbers_and_display_ExpectedResult(double nr1,double nr2, double expected)
        {
            //Arrange
            Calculator<double> sut = new Calculator<double>();
            //Act
            double actual = sut.Sub(nr1, nr2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(3.0,1.5,2.0)]
        public void Should_Subtract_2Numbers_and_display_WrongResult(double nr1, double nr2, double expected)
        {
            //Arrange
            Calculator<double> sut = new Calculator<double>();
            //Act
            double actual = sut.Sub(nr1, nr2);
            //Assert
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        [TestCase(2, 2, 0)]
        public void Should_subtract_2Numbers_and_Display_boolResult1(int nr1, int nr2, int expected)
        {
            //Arrange
            Calculator<int> sut = new Calculator<int>();
            //Act
            int actual = sut.Sub(nr1, nr2);
            //Assert
            Assert.IsTrue(expected == actual);
        }
        [Test]
        [TestCase(2, 2, 1)]
        public void Should_subtract_2Numbers_and_Display_Bool_result2(int nr1, int nr2, int expected)
        {
            //Arrange
            Calculator<int> sut = new Calculator<int>();
            //Act
            int actual = sut.Sub(nr1, nr2);
            //Assert
            Assert.IsFalse(expected == actual);
        }
        [Test]
        [TestCase(2,3,6)]
        [TestCase(4,3,12)]
        [TestCase(4,4,16)]
        [TestCase(5,6,30)]
        public void Should_Multiply_2Numbers_and_display_ExpectedResult(int nr1,int nr2, int expected)
        {
            //Arrange
            Calculator<int> sut = new Calculator<int>();
            //Act
            int actual = sut.Mul(nr1, nr2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(2,3,7)]
        public void Should_multiply_2Numbers_and_display_WrongResult(int nr1, int nr2, int expected)
        {
            //Arrange
            Calculator<int> sut = new Calculator<int>();
            //Act
            int actual = sut.Mul(nr1, nr2);
            //Assert
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        [TestCase(8,4,2)]
        [TestCase(20,4,5)]
        [TestCase(100,10,10)]
        [TestCase(111,11,10)]
        public void Should_Divide_2Numbers_and_display_ExpectedResult(int nr1, int nr2,int expected)
        {
            //Arrange
            Calculator<int> sut = new Calculator<int>();
            //Act
            int actual = sut.Div(nr1, nr2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(8,4,1)]
        public void Should_divide_2Numbers_and_display_WrongResult(int nr1, int nr2, int expected)
        {
            //Arrange
            Calculator<int> sut = new Calculator<int>();
            //Act
            int actual = sut.Div(nr1, nr2);
            //Assert
            Assert.AreNotEqual(expected, actual);
        }
    }
}
