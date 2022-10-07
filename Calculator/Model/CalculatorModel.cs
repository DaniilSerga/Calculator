using System.Text;

namespace CalculatorView.Model
{
    public class CalculatorModel
    {
        private StringBuilder? _output = new(10);

        public delegate void EventHandler();
        public static event EventHandler OutputChanged;

        public string Output
        {
            get => _output!.ToString();
            set
            {
                if (value != _output!.ToString() && value != string.Empty)
                {
                    _output = _output.Append(value);
                    OutputChanged();
                }
                else if (value != _output!.ToString() && value == string.Empty)
                {
                    _output.Clear();
                    OutputChanged();
                }
            }
        }
    }
}
