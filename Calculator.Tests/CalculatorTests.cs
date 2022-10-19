using CalculatorView.Model;
using CalculatorView.Service;
using System.Windows.Forms;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private static readonly CalculatorModel _model = new();
        private readonly CalculatorService _service = new (_model);

        public CalculatorTests()
        {
            CalculatorModel.OutputChanged += SomeEventAction;
        }

        private void SomeEventAction() { }

        /// <summary>
        /// Tests the result of calculating arithmetic expressions.
        /// </summary>
        /// <param name="expression"> Input arithmetic expression. </param>
        /// <param name="expectedResult"> Exprected result of calculating an arithmetic expression </param>
        [Theory]
        [InlineData("2+2*2", "6")]
        [InlineData("14/2+9", "16")]
        [InlineData("0*1", "0")]
        [InlineData("5+-2", "3")]
        [InlineData("12x5", "60")]
        [InlineData("2+2÷2", "3")]
        [InlineData("1/0", "NOT ÷ 0")]
        [InlineData("1x3", "3")]
        public void CalculateArithmeticExpression_ResultCalculation(string expression, string expectedResult)
        {
            // Arrange
            _model.Output = expression;

            // Act
            _service.EqualsButtonPressed();

            // Assert
            Assert.Equal(_model.Output, expectedResult);
        }

        /// <summary>
        /// Tests if the clear button is working normally
        /// </summary>
        [Theory]
        [InlineData("12+3")]
        public void ClearButton_Click_EqualsToEmptyString(string expression)
        {
            // Arrange
            _model.Output = expression;

            // Act
            _service.ClearOutputField();

            // Assert
            Assert.Empty(_model.Output);
        }

        /// <summary>
        /// Tests if the output is equal to the entered operation value. 
        /// </summary>
        /// <param name="operation"> Operation value </param>
        [Theory]
        [InlineData("12", "/", "12/")]
        [InlineData("0", "*", "0*")]
        [InlineData("0.45", "-","0.45-")]
        [InlineData("13+2", "+", "13+2+")]
        public void OperationButton_Click_EndsWithEnteredOperation(string expression, string operation, string expected)
        {
            // Arrange
            _model.Output = expression;

            // Act
            _service.OperationButtonPressed(operation);

            // Assert
            Assert.EndsWith(expected, _model.Expression);
        }

        /// <summary>
        /// Tests if the output value's end char is equal to the entered number value. 
        /// </summary>
        /// <param name="input"> Input value </param>
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
        public void NumberButton_Click_EndsWithEnteredNumber(string input)
        {
            // Arrange
            Button button = new() { Text = input };

            // Act
            _service.NumberButtonPressed(button.Text);

            // Assert
            Assert.EndsWith(input, _model.Output);
        }
    }
}