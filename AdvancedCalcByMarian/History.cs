using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalcByMarian
{
    public class History
    {
        private string _inputExpression;
        private CalculatorMode _mode;
        private double _result;

        public string InputExpression => _inputExpression;
        public CalculatorMode Mode => _mode;
        public double Result => _result;

        public History(string inputExpression, double result, CalculatorMode mode)
        {
            _inputExpression = inputExpression;
            _result = result;
            _mode = mode;
        }
    }
}
