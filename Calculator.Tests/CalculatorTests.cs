namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData("2+2*2", "6")]
        [InlineData("0*1", "0")]
        [InlineData("0.1+9.9", "10")]
        public void CalculateArithmeticExpression(string expression, string expectedResult)
        {
            Assert.Equal(expectedResult, CalculatorForm.CalculateArithmeticExpression(expression));
        }
    }
}