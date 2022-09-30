namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData("2+2*2", "6")]
        [InlineData("0*1", "0")]
        [InlineData("0.1+9.9", "10.0")]
        [InlineData("12", "12")]
        [InlineData("0.1", "0.1")]
        [InlineData("-1", "-1")]
        [InlineData("-0.2", "-0.2")]
        public void CalculateArithmeticExpression(string expression, string expectedResult)
        {
            Assert.Equal(expectedResult, FormCalculator.CalculateArithmeticExpression(expression));
        }
    }
}