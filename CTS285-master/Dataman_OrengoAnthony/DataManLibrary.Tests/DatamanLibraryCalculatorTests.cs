using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
using DataManLibrary;
using Xunit;
namespace DataManLibrary.Tests
{
    public class DatamanLibraryCalculatorTests
    {
        #region Answer Checker Tests
        [Fact]
        public void Addition_ValuesShouldCalculate()
        {
            //Arrange 
            int expected = 10;

            //Act 
            int actual = Calculator.CheckAddition(5, 5, 0);

            //Assert

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Subtraction_ValuesShouldCalculate()
        {
            //Arrange 
            int expected = 10;

            //Act 
            int actual = Calculator.CheckSubtraction(20, 10, 0);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Multiplication_ValuesShouldCalculate()
        {
            //Arrange 
            int expected = 25;

            //Act 
            int actual = Calculator.CheckMultiplication(5, 5, 0);

            //Assert

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Division_ValuesShouldCalculate()
        {
            //Arrange 
            int expected = 1;

            //Act 
            int actual = Calculator.CheckDivision(5, 5, 0);

            //Assert

            Assert.Equal(expected, actual);
        }
        #endregion
        //--------------------------------------------------------
        //TODO Electro Flash Tests
    }
}
