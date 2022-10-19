using System.Data;
using System.Text;
using CalculatorView.Model;

namespace CalculatorView.Service
{
    public class CalculatorService
    {
        private readonly CalculatorModel _model;

        public CalculatorService(CalculatorModel model)
        {
            _model = model;
        }

        /// <summary>
        /// Allows user to see the output string.
        /// </summary>
        /// <returns>Output string.</returns>
        public string GetOutputString() => _model.Output;

        /// <summary>
        /// Allows user to see the result.
        /// </summary>
        /// <returns>Result of an arithmetic expression.</returns>
        public void EqualsButtonPressed()
        {
            _model.Expression = _model.Output;

            ReWriteExpression(_model.Expression.Replace('÷', '/').Replace('x', '*'));

            CalculateArithmeticExpression(_model.Expression);
        }

        /// <summary>
        /// Calculates provided expression.
        /// </summary>
        /// <param name="expression"> Provided expression. </param>
        public void CalculateArithmeticExpression(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                return;
            }

            if (char.IsSymbol(expression[^1]) || char.IsPunctuation(expression[^1]))
            {
                return;
            }

            if (expression.StartsWith('-'))
            {
                expression = "0-" + expression[1..];
            }

            if (expression.Contains("/0"))
            {
                ReWriteOutput("NOT ÷ 0");
                return;
            }

            string result;

            try
            {
                result = new DataTable()
                            .Compute(expression, "")
                            .ToString()!
                            .Replace(',', '.');
            }
            catch
            {
                result = "EXCEEDED";
            }

            if ((result.Length >= 8 && result.Contains('.')) || result == "∞" || result == "не число")
            {
                result = "EXCEEDED";
            }

            ReWriteOutput(result);

            _model.Expression = string.Empty;
        }

        /// <summary>
        /// Clears output field.
        /// </summary>
        public void ClearOutputField()
        {
            if (_model.Output.Length == 0)
            {
                return;
            }

            _model.Output = string.Empty;
        }

        /// <summary>
        /// Adds a new number to an expresssion.
        /// </summary>
        /// <param name="input"> Number adding to an expression</param>
        public void NumberButtonPressed(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            if (!char.IsDigit(input[0]) || _model.Output.Length > 8)
            {
                return;
            }

            if (_model.Output == "EXCEEDED" || _model.Output == "NOT ÷ 0")
            {
                ReWriteOutput(input);
                return;
            }

            _model.Output = input;
        }

        /// <summary>
        /// Add an operation to an expression.
        /// </summary>
        /// <param name="input"> Operation adding to an expression. </param>
        public void OperationButtonPressed(string input)
        {
            if (_model.Output == "EXCEEDED" || _model.Output == "NOT ÷ 0")
            {
                return;
            }

            if (_model.Output.Length == 0)
            {
                _model.Output.Append('0');
                return;
            }

            // Replace the last char to a came one
            if ((char.IsSymbol(_model.Output[^1]) || char.IsPunctuation(_model.Output[^1])) && input != "-")
            {
                _model.Output.Remove(_model.Output.Length - 1, 1);
            }

            _model.Output = input;

            SaveAndClearOutputString();
        }

        /// <summary>
        /// Negates an entered number.
        /// </summary>
        public void NegateNubmer()
        {
            if (_model.Output.Length == 0)
            {
                return;
            }

            double number = double.Parse(_model.Output);

            ReWriteOutput((number * (-1)).ToString());
        }

        #region Output methods
        /// <summary>
        /// Puts everything entered in a different string in order to save it.
        /// </summary>
        private void SaveAndClearOutputString()
        {
            if (string.IsNullOrEmpty(_model.Output))
            {
                return;
            }

            _model.Expression = _model.Output;
            _model.Output = string.Empty;
        }

        /// <summary>
        /// Rewrites output string with provided text.
        /// </summary>
        /// <param name="value"></param>
        private void ReWriteOutput(string value)
        {
            _model.Output = string.Empty;
            _model.Output = value;
        }

        /// <summary>
        /// Rewrites expression field in model.
        /// </summary>
        /// <param name="expression"> An expression which replaces expression field in model. </param>
        private void ReWriteExpression(string expression)
        {
            _model.Expression = string.Empty;
            _model.Expression = expression;
        }
        #endregion
    }
}
