using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyMSTest
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new Calculator();
            int a = 10;
            int b = 20;

            //Act
            int result = calc.AddNumbers(a, b);

            //Assert
            Assert.AreEqual(30, result);
        }
    }
}
