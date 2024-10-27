using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalcByMarian.Functions
{
    public class Function
    {
        private string _name;
        private string _expression;
        private int _amountOfVariables;
        private string[] _variables;

        public string Name => _name;
        public string Expression => _expression;
        public int AmountOfVariables => _amountOfVariables;
        public string[] Variables => _variables;

        public Function(string name, string expression)
        {
            _name = name;
            _expression = expression;
            _amountOfVariables = 0;

            CountAndSortVariables(expression);
        }

        private void CountAndSortVariables(string expression)
        {
            List<string> variables = new List<string>();
            string futureVariable = "";

            HashSet<string> restrictedTerms = new HashSet<string> { "+", "-", "*", "/", "%", "=", "^", "(", ")" };

            expression += " ";

            for (int i = 0; i < expression.Length; i++)
            {
                if (i == expression.Length - 1)
                    AddNewVariable(ref variables, ref futureVariable, ref restrictedTerms);
                else
                {
                    string currentItem = Convert.ToString(expression[i]);

                    if (IsCurrentSymbolRestricted(currentItem, ref restrictedTerms))
                        AddNewVariable(ref variables, ref futureVariable, ref restrictedTerms);
                    else
                        futureVariable += currentItem;
                }
            }

            variables.RemoveAll(emptyString => emptyString == "");
            _variables = TurnAllPotentialVariablesIntoValid(variables);
        }

        private void AddNewVariable(ref List<string> variables, ref string futureVariable, ref HashSet<string> restrictedTerms)
        {
            variables.Add(futureVariable);
            restrictedTerms.Add(futureVariable);
            futureVariable = "";
        }

        private bool IsCurrentSymbolRestricted(string currentSymbol, ref HashSet<string> restrictedTerms)
        {
            if (restrictedTerms.Contains(currentSymbol))
            {
                restrictedTerms.Add(currentSymbol);
                return true;
            }

            return false;
        }

        private string[] TurnAllPotentialVariablesIntoValid(List<string> potentialVariables)
        {
            List<string> export = new List<string>();

            foreach (string variable in potentialVariables)
            {
                if (IsVariableValid(variable))
                {
                    export.Add(variable);
                    _amountOfVariables++;
                }
            }

            return export.ToArray();
        }

        private bool IsVariableValid(string variable)
        {
            string[] restrictedTerms = { "sin", "cos", "tan", "sinh", "cosh", "tanh" };

            if (restrictedTerms.Contains(variable))
                return false;

            if (variable.Any(char.IsDigit))
                return false;

            return true;
        }
    }
}
