using System.Text;
using System.Windows.Forms;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        /// <summary>
        /// Tests the result of calculating arithmetic expressions.
        /// </summary>
        /// <param name="expression"> Input arithmetic expression. </param>
        /// <param name="expectedResult"> Exprected result of calculating an arithmetic expression </param>
        [Theory]
        [InlineData("2+2*2", "6")]
        [InlineData("0*1", "0")]
        [InlineData("0.1+9.9", "10.0")]
        [InlineData("12", "12")]
        [InlineData("0.1", "0.1")]
        [InlineData("-1", "-1")]
        [InlineData("-0.2", "-0.2")]
        public void CalculateArithmeticExpression_ResultCalculation(string expression, string expectedResult)
        {
            Assert.Equal(expectedResult, FormCalculator.CalculateArithmeticExpression(expression));
        }

        /// <summary>
        /// Does the same as the previous test, but checks if the button access is working fine.
        /// </summary>
        /// <param name="expression"> Input arithmetic expression. </param>
        /// <param name="expectedResult"> Exprected result of calculating an arithmetic expression </param>
        [Theory]
        [InlineData("215+5", "220")]
        [InlineData("15-", "15-")]
        [InlineData("0.1-9", "-8.9")]
        [InlineData("-5", "-5")]
        public void EqualsButton_Click_Tests(string expression, string expectedResult)
        {
            FormCalculator calculator = new()
            {
                output = new StringBuilder(expression)
            };

            calculator.EqualsButton_Click(null!, EventArgs.Empty);

            Assert.Equal(expectedResult, calculator.output.ToString());
        }

        /// <summary>
        /// Tests if the clear button is working normally
        /// </summary>
        [Fact]
        public void ClearButton_Click_EqualsToEmptyString()
        {
            FormCalculator calculator = new()
            {
                output = new StringBuilder("asd")
            };

            calculator.ClearButton_Click(null!, EventArgs.Empty);

            Assert.Equal("", calculator.output.ToString());
        }

        /// <summary>
        /// Tests if the output value's end char is equal to the entered operation value. 
        /// </summary>
        /// <param name="operation"> Operation value </param>
        [Theory]
        [InlineData("/")]
        [InlineData("*")]
        [InlineData("-")]
        [InlineData("+")]
        [InlineData(".")]
        public void OperationButton_Click_EndsWithEnteredOperation(string operation)
        {
            FormCalculator calculator = new();

            object sender = new Button() { Text = operation };

            calculator.OperationButton_Click(sender, EventArgs.Empty);

            Assert.EndsWith(operation, calculator.output.ToString());
        }

        /// <summary>
        /// Tests if the output value's end char is equal to the entered number value. 
        /// </summary>
        /// <param name="number"> Number value </param>
        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        [InlineData("4")]
        [InlineData("5")]
        [InlineData("6")]
        [InlineData("7")]
        [InlineData("8")]
        [InlineData("9")]
        public void NumberButton_Click_EndsWithEnteredNumber(string number)
        {
            FormCalculator calculator = new();

            object sender = new Button() { Text = number };

            calculator.NumberButton_Click(sender, EventArgs.Empty);

            Assert.EndsWith(number, calculator.output.ToString());
        }

        /// <summary>
        /// Tests whether the entered expression is not displayed on the user's screen.
        /// </summary>
        /// <param name="output"> Entered expression </param>
        [Theory]
        [InlineData("125+")]
        [InlineData("125.")]
        [InlineData("125-")]
        [InlineData("125*")]
        [InlineData("125/")]
        [InlineData("125=")]
        public void CalculatorForm_KeyPress_ReturnsFalse(string output)
        {
            FormCalculator calculator = new()
            {
                output = new StringBuilder(output)
            };

            calculator.OutputBox_TextChanged(null!, EventArgs.Empty);

            Assert.False(calculator.buttonResult.Enabled);
        }

        /// <summary>
        /// Tests whether the entered expression is displayed on the user's screen.
        /// </summary>
        /// <param name="output"> Entered expression </param>
        [Theory]
        [InlineData("125+1")]
        [InlineData("125.1")]
        [InlineData("125-1")]
        [InlineData("125*1")]
        [InlineData("125/1")]
        [InlineData("125=1")]
        public void CalculatorForm_KeyPress_ReturnsTrue(string output)
        {
            FormCalculator calculator = new()
            {
                output = new StringBuilder(output)
            };

            calculator.OutputBox_TextChanged(null!, EventArgs.Empty);

            Assert.True(calculator.buttonResult.Enabled);
        }
    }
}