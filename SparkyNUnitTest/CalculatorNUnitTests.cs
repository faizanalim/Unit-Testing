using NUnit.Framework;
using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();
            //Act
            int result = calc.AddNumbers(10,5 );
            bool checkOdd = calc.IsOddNumber(6);
            //Assert
            Assert.That(result, Is.EqualTo(15));


        }
        [Test]
        public void CheckOdd()
        {
            //Arrange
            Calculator calc = new();
            //Act
            bool checkOdd = calc.IsOddNumber(15);
            //Assert

            Assert.That(checkOdd, Is.True);
           // Assert.That(checkOdd, Is.EqualTo(true));
        }

    }
}
