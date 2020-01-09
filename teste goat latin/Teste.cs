using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoatLatinExercise;
using NUnit.Framework;


namespace TesteGoatLatin
{
    [TestFixture]
    public class Teste
    {
        [Test]
        
        public void Should_return_GoatLatin_text()
        {
            //Arrange
            Exercitiu sut = new Exercitiu();

            //Act
            var actual = sut.Goat2("I speak Goat Latin");
            //Assert

            Assert.AreEqual("Imaa peaksmaaa oatGmaaaa atinLmaaaaa ", actual);
        }

    }
}
