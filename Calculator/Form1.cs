using System.Data;
using System.Linq;
using System.Text;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private StringBuilder output = new();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            output.Append((sender as Button).Text);

            OutputBox.Text = output.ToString();
        }

        // There're no possible way to print 2 dots together same as any sort of operation
        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (output.Length == 0)
            {
                output.Append('0');
            }

            output.Append((sender as Button).Text);

            OutputBox.Text = output.ToString();
        }

        //  TODO Implement calculations
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            //char[] arifmeticEquasions = new[] { '-', '+', '/', '*' };
            //string[] numbers = output.ToString().Split(arifmeticEquasions);

            //double result = double.Parse(numbers[0]);

            //for (int i = 0, startIndex = 0; i < output.Length; i++)
            //{
            //    for (int j = 0; j < arifmeticEquasions.Length; j++)
            //    {
            //        if (output[i] == arifmeticEquasions[j])
            //        {
            //            //result = 
            //        }
            //    }
            //}

            double result = Convert.ToDouble(new DataTable().Compute(output.ToString(), ""));

            output.Append($"={result}");

            OutputBox.Text = output.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (output.Length == 0)
            {
                return;
            }

            output.Clear();

            OutputBox.Text = output.ToString();
        }

        private void RemoveLastButton_Click(object sender, EventArgs e)
        {
            if (output.Length == 0)
            {
                return;
            }

            output.Remove(output.Length - 1, 1);

            OutputBox.Text = output.ToString();
        }

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

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
            OutputBox.SelectionStart = OutputBox.Text.Length;
            OutputBox.ScrollToCaret();
        }
    }
}