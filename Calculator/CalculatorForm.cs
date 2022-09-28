using System.Data;
using System.Text;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        // Local string containing everything entered from the user
        public readonly StringBuilder output = new();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        // Displays entered number on the screen and saves entered value to a local string
        private void NumberButton_Click(object sender, EventArgs e)
        {
            output.Append(((Button)sender).Text);

            OutputBox.Text = output.ToString();
        }

        // Displays entered operation on the screen and saves it to a local string
        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (output.Length == 0)
            {
                output.Append('0');
            }

            if (char.IsPunctuation(output[^1]))
            {
                return;
            }

            output.Append(((Button)sender).Text);

            OutputBox.Text = output.ToString();
        }

        // Calculates the result and displays it on the screen
        private void EqualsButton_Click(object sender, EventArgs e) => OutputBox.Text = CalculateArithmeticExpression(output.ToString());

        // Clears the output window
        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (output.Length == 0)
            {
                return;
            }

            output.Clear();

            OutputBox.Text = output.ToString();
        }

        // Removes the last entered symbol from the local string and output window
        private void RemoveLastButton_Click(object sender, EventArgs e)
        {
            if (output.Length == 0)
            {
                return;
            }

            output.Remove(output.Length - 1, 1);

            OutputBox.Text = output.ToString();
        }

        // Allow user to interact with the calculator using keyboard
        private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || (!SymbolIsOperation(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8))
            {
                return;
            }

            switch (e.KeyChar)
            {
                case '-':
                    SubstractButton.PerformClick();
                    break;
                case '+':
                    SumButton.PerformClick();
                    break;
                case '/':
                    DivideButton.PerformClick();
                    break;
                case '*':
                    MultiplyButton.PerformClick();
                    break;
                case '=':
                    EqualsButton.PerformClick();
                    break;
                case '.':
                    DotButton.PerformClick();
                    break;
                case (char)8:
                    // Backspace symbol
                    RemoveLastButton.PerformClick();
                    break;
                default:
                    Button[] buttons = new[] { Button0, Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9 };
                    buttons[int.Parse(e.KeyChar.ToString())].PerformClick();
                    break;
            }

            static bool SymbolIsOperation(char key)
            {
                char[] operations = new[] { '.', '+', '-', '/', '*', '=' };

                return operations.Contains(key);
            }
        }

        // Slides the scroll bar so that user can see what he is entering on the output window
        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
            OutputBox.SelectionStart = OutputBox.Text.Length;
            OutputBox.ScrollToCaret();
        }

        // Claculates the expression
        public static string CalculateArithmeticExpression(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                throw new ArgumentNullException(nameof(expression), "Expressions string was null or empty.");
            }

            double result = Convert.ToDouble(new DataTable().Compute(expression, ""));

            return result.ToString();
        }
    }
}