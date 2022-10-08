using CalculatorView.Model;
using CalculatorView.Service;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Linq.Expressions;
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
        [InlineData("14/2+9", "16")]
        [InlineData("0*1", "0")]
        [InlineData("0.1+9.9", "10.0")]
        [InlineData("12", "12")]
        [InlineData("0.1", "0.1")]
        [InlineData("-1", "-1")]
        [InlineData("-0.2", "-0.2")]
        public void CalculateArithmeticExpression_ResultCalculation(string expression, string expectedResult)
        {
            // Arrange
            CalculatorModel model = new();
            CalculatorService service = new(model);

            // Act
            CalculatorModel.OutputChanged += null;

            model.Expression = expression;
            service.CalculateArithmeticExpression(model.Expression);

            // Assert
            Assert.Equal(expectedResult, model.Output);
        }

        /// <summary>
        /// Does the same as the previous test, but checks if the button access is working fine.
        /// </summary>
        /// <param name="expression"> Input arithmetic expression. </param>
        /// <param name="expectedResult"> Exprected result of calculating an arithmetic expression </param>
        [Theory]
        [InlineData("215+5", "220")]
        [InlineData("14/2+9", "16")]
        [InlineData("15-", "15-")]
        [InlineData("0.1-9", "-8.9")]
        [InlineData("-5", "-5")]
        public void EqualsButton_Click_Tests(string expression, string expectedResult)
        {
            
        }

        /// <summary>
        /// Tests if the clear button is working normally
        /// </summary>
        [Fact]
        public void ClearButton_Click_EqualsToEmptyString()
        {
            
        }

        /// <summary>
        /// Tests if the output is equal to the entered operation value. 
        /// </summary>
        /// <param name="operation"> Operation value </param>
        [Theory]
        [InlineData("/", "0/")]
        [InlineData("*", "0*")]
        [InlineData("-","0-")]
        [InlineData("+", "0+")]
        public void OperationButton_Click_EndsWithEnteredOperation(string operation, string expected)
        {
            
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
            
        }
    }
}