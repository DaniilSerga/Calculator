using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorView
{
    public class CalculatorService
    {
        private readonly CalculatorModel _model;

        public CalculatorService(CalculatorModel model)
        {
            _model = model;
        }

        /// <summary>
        /// Allows calculator view access the output string.
        /// </summary>
        /// <returns>Output string.</returns>
        public string GetOutputString() => _model.Output;

        /// <summary>
        /// Calculates arithmetic expression.
        /// </summary>
        /// <param name="expression">A string representation of an arithmetic expression.</param>
        /// <returns> Calculation result.</returns>
        public void CalculateArithmeticExpression()
        {
            string expression = _model.Output;

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

            try
            {
                _model.Output = new DataTable()
                            .Compute(expression, "")
                            .ToString()!
                            .Replace(',', '.');
            }
            catch
            {
                _model.Output = "EXCEEDED";
            }

            if (_model.Output.Length >= 8 && _model.Output.Contains('.'))
            {
                _model.Output = "EXCEEDED";
            }
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
                throw new ArgumentNullException(nameof(input), "Input string was null or empty (NumberButtonPressed)");
            }

            if (!char.IsDigit(input[0]) || _model.Output.Length > 8)
            {
                return;
            }

            _model.Output = input;
        }
    }
}
