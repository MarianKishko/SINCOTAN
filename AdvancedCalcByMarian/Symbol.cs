using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalcByMarian
{
    public class Symbol
    {
        private string _value;
        private SymbolType _type;
        private int _precendence;
        private int _trigiometryNumber;

        public string Value => _value;
        public SymbolType Type => _type;
        public int Precendence => _precendence;
        public int TrigiometryNumber => _trigiometryNumber;

        public Symbol (string value, SymbolType type)
        {
            _value = value;
            _type = type;
        }

        public Symbol (string value, SymbolType type, int trigiometryNumber)
        {
            _value = value;
            _type = type;
            _trigiometryNumber = trigiometryNumber;
        }

        public Symbol (string value, int precendence)
        {
            _value = value;
            _type = SymbolType.Operator;
            _precendence = precendence;
        }
        
    }

    public enum SymbolType
    {
        Number,
        Operator,
        Function
    }
}
