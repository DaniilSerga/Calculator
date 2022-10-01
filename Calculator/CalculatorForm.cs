using System.Data;
using System.Text;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        // Local string containing everything entered from the user
        public StringBuilder output = new();

        public FormCalculator()
        {
            InitializeComponent();
        }

        // Displays entered number on the screen and saves entered value to a local string
        public void NumberButton_Click(object sender, EventArgs e)
        {
            if (!char.IsDigit(((Button)sender).Text[0]))
            {
                return;
            }

            output.Append(((Button)sender).Text);

            textDisplay.Text = output.ToString();
        }

        // Displays entered operation on the screen and saves it to a local string
        public void OperationButton_Click(object sender, EventArgs e)
        {
            if (output.Length == 0)
            {
                output.Append('0');
            }

            // Replace the last char to a came one
            if ((char.IsSymbol(output[^1]) || char.IsPunctuation(output[^1])) && ((Button)sender).ToString() != "-")
            {
                output.Remove(output.Length - 1, 1);
            }

            // The following code doesn's allow user to add more than one dot per a number
            // So user cannot do 0.0.0.0.1, but 0.1
            if (((Button)sender).Text == ".")
            {
                int startIndex = output.ToString().LastIndexOfAny(new char[] { '+', '-', '/', '*' });
                
                startIndex = startIndex == -1 ? 0 : startIndex;

                for (int i = startIndex; i < output.Length; i++)
                {
                    if (output[i] == '.')
                    {
                        return;
                    }
                }
            }

            output.Append(((Button)sender).Text);

            textDisplay.Text = output.ToString();
        }

        // Calculates the result and displays it on the screen
        public void EqualsButton_Click(object sender, EventArgs e)
        {
            string result = CalculateArithmeticExpression(output.ToString());

            output.Clear();

            output.Append(result);

            textDisplay.Text = output.ToString();
        }

        // Clears the output window
        public void ClearButton_Click(object sender, EventArgs e)
        {
            if (output.Length == 0)
            {
                return;
            }

            output.Clear();

            textDisplay.Text = output.ToString();
        }

        // Allow user to interact with the calculator via keyboard
        public void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!SymbolIsOperation(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                return;
            }

            switch (e.KeyChar)
            {
                case '-':
                    buttonSubstract.PerformClick();
                    break;
                case '+':
                    buttonAdd.PerformClick();
                    break;
                case '/':
                    buttonDivide.PerformClick();
                    break;
                case '*':
                    buttonMultiply.PerformClick();
                    break;
                case '=':
                    buttonResult.PerformClick();
                    break;
                case '.':
                    buttonDecimalPoint.PerformClick();
                    break;
                default:
                    Button[] buttons = new[] { buttonZero, buttonOne, buttonTwo, buttonThree, buttonFour, buttonFive, buttonSix, buttonSeven, buttonEight, buttonNine };
                    buttons[int.Parse(e.KeyChar.ToString())].PerformClick();
                    break;
            }

            // Checks if the entered value is an operation symbol
            static bool SymbolIsOperation(char key)
            {
                char[] operations = new[] { '.', '+', '-', '/', '*', '=' };

                return operations.Contains(key);
            }
        }

        // Slides the scroll bar so that user can see what he is entering on the output window
        public void OutputBox_TextChanged(object sender, EventArgs e)
        {
            textDisplay.SelectionStart = textDisplay.Text.Length;
            textDisplay.ScrollToCaret();

            if (output.Length == 0)
            {
                return;
            }

            if (char.IsPunctuation(output[^1]) || char.IsSymbol(output[^1]))
            {
                buttonResult.Enabled = false;
            }
            else
            {
                buttonResult.Enabled = true;
            }
        }

        // Claculates the expression
        public static string CalculateArithmeticExpression(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                return expression;
            }

            if (char.IsSymbol(expression[^1]) || char.IsPunctuation(expression[^1]))
            {
                return expression;
            }

            if (expression.StartsWith('-'))
            {
                expression = "0-" + expression[1..];
            }

            string result = string.Empty;

            try
            {
                result = new DataTable().Compute(expression, "").ToString()!.Replace(',', '.');
            }
            catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message, 
                                "Слишком большие числа(о)", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }

            return result;
        }
    }
}