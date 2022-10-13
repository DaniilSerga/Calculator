using System.Text;

namespace CalculatorView.Model
{
    public class CalculatorModel
    {
        private StringBuilder? _expression = new();
        private StringBuilder? _output = new(10);

        public delegate void EventHandler();
        public static event EventHandler? OutputChanged;

        public string Expression
        {
            get => _expression!.ToString();
            set
            {
                if (value != string.Empty)
                {
                    _expression!.Append(value);
                }
                else if (value == string.Empty)
                {
                    _expression = new StringBuilder(value);
                }
            }
        }

        public string Output
        {
            get => _output!.ToString();
            set
            {
                if (_output!.Length != 0 && value[1..] == _output!.ToString() && value[0] == '-')
                {
                    _output.Clear();
                    _output.Append(value);

                    OutputChanged!();
                }
                else if (value != _output!.ToString() && value != string.Empty)
                {
                    _output = _output.Append(value);

                    OutputChanged!();
                }
                else if (value != _output!.ToString() && value == string.Empty)
                {
                    _output.Clear();

                    OutputChanged!();
                }
                
            }
        }
    }
}
