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

        // Refreshes the output box
        private void RefreshOutputField() => textDisplay.Text = _service.GetOutputString();

        // Displays entered number on the screen and saves entered value to a local string
        public void NumberButton_Click(object sender, EventArgs e)
        {
            _service.NumberButtonPressed(((Button)sender).Text);
        }

        // Allows user to apply operation
        public void OperationButton_Click(object sender, EventArgs e)
        {
            _service.OperationButtonPressed(((Button)sender).Text);

            textDisplay.Text = string.Empty;
        }

        // Calculates the result and displays it on the screen
        public void EqualsButton_Click(object sender, EventArgs e)
        {
            _service.EqualsButtonPressed();
        }

        // Clears the output window
        public void ClearButton_Click(object sender, EventArgs e)
        {
            _service.ClearOutputField();
        }

        // Allows user to interact with the calculator via keyboard
        public void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!SymbolIsOperation(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                return;
            }

            switch (e.KeyChar)
            {
                case '-':
                    ButtonSubstract.PerformClick();
                    break;
                case '+':
                    ButtonAdd.PerformClick();
                    break;
                case '/':
                    ButtonDivide.PerformClick();
                    break;
                case '*':
                    ButtonMultiply.PerformClick();
                    break;
                case '=':
                    ButtonResult.PerformClick();
                    break;
                case '.':
                    ButtonNegation.PerformClick();
                    break;
                default:
                    Button[] buttons = new[] { ButtonZero, ButtonOne, ButtonTwo, ButtonThree, ButtonFour, ButtonFive, ButtonSix, ButtonSeven, ButtonEight, ButtonNine };
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

        // Enables/disables equals button
        public void OutputBox_TextChanged(object sender, EventArgs e)
        {
            string output = textDisplay.Text;

            if (output.Length == 0)
            {
                ButtonResult.Enabled = false;
                return;
            }

            if (char.IsPunctuation(output[^1]) || char.IsSymbol(output[^1]))
            {
                ButtonResult.Enabled = false;
                return;
            }
            

            ButtonResult.Enabled = true;
        }

        // Sets window state to minimized
        private void ButtonMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        // Closes the application
        private void ButtonClose_Click(object sender, EventArgs e) => Close();

        // Neagates the entered number
        private void ButtonNegation_Click(object sender, EventArgs e) => _service.NegateNubmer();
    }
}