using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTests
{
    public class UnitTests
    {
        [Test]    // visada reikia sita prirasyti
        public void Sum1And1()
        {
            int expectedResult = 2;

            int actualResult = Calculator.Calculator.SumInt(1, 1); // geriau taip aprasineti

            Assert.AreEqual(expectedResult, actualResult);
        
        }

        [Test]
        public void Sum2And2()
        {
            Assert.AreEqual(4, Calculator.Calculator.SumInt(2, 2));

        }

        [Test]
        public void Sum01And01And01()
        {
            double expectedResult = 0.3;

            double actualResult = Calculator.Calculator.SumDouble3(0.1, 0.1, 0.1);

            Assert.AreEqual(expectedResult, actualResult);
        
        }






    }
}
