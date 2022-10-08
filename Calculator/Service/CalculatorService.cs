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
        //public string GetResult() => _model.Result;

        public void EqualsButtonPressed()
        {
            _model.Expression = _model.Output;

            CalculateArithmeticExpression(_model.Expression);
        }
        /// <summary>
        /// Calculates arithmetic expression.
        /// </summary>
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

            if (result.Length >= 8 && result.Contains('.'))
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

            _model.Output = input;
        }

        public void OperationButtonPressed(string input)
        {
            if (_model.Output.Length == 0)
            {
                _model.Output.Append('0');
            }

            // Replace the last char to a came one
            if ((char.IsSymbol(_model.Output[^1]) || char.IsPunctuation(_model.Output[^1])) && input != "-")
            {
                _model.Output.Remove(_model.Output.Length - 1, 1);
            }

            _model.Output = input;

            SaveAndClearOutputString();
        }

        #region Output methods
        private void SaveAndClearOutputString()
        {
            if (string.IsNullOrEmpty(_model.Output))
            {
                return;
            }

            _model.Expression = _model.Output;
            _model.Output = string.Empty;
        }

        private void ReWriteOutput(string value)
        {
            _model.Output = string.Empty;
            _model.Output = value;
        }
        #endregion
    }
}
