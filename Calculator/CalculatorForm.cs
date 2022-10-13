using CalculatorView.Model;
using CalculatorView.Service;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private readonly CalculatorService _service = new(_model);
        private static readonly CalculatorModel _model = new();
        
        public FormCalculator()
        {
            InitializeComponent();

            CalculatorModel.OutputChanged += RefreshOutputField;
        }

        private void RefreshOutputField() => textDisplay.Text = _service.GetOutputString();

        // Displays entered number on the screen and saves entered value to a local string
        public void NumberButton_Click(object sender, EventArgs e)
        {
            _service.NumberButtonPressed(((Button)sender).Text);
        }

        // TODO Displays entered operation on the screen and saves it to a local string
        public void OperationButton_Click(object sender, EventArgs e)
        {
            _service.OperationButtonPressed(((Button)sender).Text);

            textDisplay.Text = string.Empty;
        }

        // TODO TEST Calculates the result and displays it on the screen
        public void EqualsButton_Click(object sender, EventArgs e)
        {
            //string calculationParam = string.Join(string.Empty, expression.ToArray()) + output.ToString();

            _service.EqualsButtonPressed();
        }

        // Clears the output window
        public void ClearButton_Click(object sender, EventArgs e)
        {
            _service.ClearOutputField();
        }

        // TODO Allow user to interact with the calculator via keyboard
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
                    ButtonNegation.PerformClick();
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

        // Sets enable property of EqualsButton to false, so that user is not able to call calculation method
        // with incorrect input string
        public void OutputBox_TextChanged(object sender, EventArgs e)
        {
            string output = textDisplay.Text;

            if (output.Length == 0)
            {
                buttonResult.Enabled = false;
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

        private void buttonMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void buttonClose_Click(object sender, EventArgs e) => this.Close();

        // TODO Negation button
        private void ButtonNegation_Click(object sender, EventArgs e)
        {
            _service.NegateNubmer();
        }
    }
}