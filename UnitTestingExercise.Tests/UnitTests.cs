using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(1,5,6,12)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var num = new UnitTestMethods();
            //Act
            var actual = num.AddNum(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,1,1)]
        [InlineData(5,4,1)]
        [InlineData(1000,999,1)]
        public void Sub(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var num = new UnitTestMethods();
            //Act
            var act = num.Sub(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(25,5,100)]
        [InlineData(5,20,100)]
        public void Mult(int num1, int num2, int expected)
        {
            //Arrange
            var num = new UnitTestMethods();
            //Act
            var act = num.Mult(num1, num2);
            //Assert
            Assert.Equal(expected, act);

        }

        [Theory]
        [InlineData(4,2,2)]
        [InlineData(6,3,2)]
        [InlineData(100,50,2)]
        public void Div(int num1, int num2, int expected)
        {
            //Arrange
            var num = new UnitTestMethods();
            //Act
            var act = num.Div(num1, num2);
            //Assert
            Assert.Equal(expected, act);
        }

        [Fact]
        public void Add3And3()
        {
            //Arrange
            var num = new UnitTestMethods();
            //Act

            var actual = num.Add3And3();
            var expected = 6;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetHey()
        {
            //Arrange
            var word = new UnitTestMethods();
            //Act
            var act = word.GetHey();
            var expt = "Hey!";
            //Assert
            Assert.Equal(expt, act);
        }
    }
}
