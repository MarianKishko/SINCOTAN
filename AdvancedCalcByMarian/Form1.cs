using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using AdvancedCalcByMarian.Functions;

namespace AdvancedCalcByMarian
{
    public enum CalculatorMode
    {
        Scienstific,
        Calculus
    }

    public partial class Form1 : Form
    {
        private const int FUCKING_TWO = 2;
        private const int _three = 3;
        private const int _maxAmountOfLettersOfResultOutputToDecreaseFontSize = 21;
        private const int _numberToDecreaseTheResultOutputLableFontSize = 4;
        private const int _sqrtOperatorNumber = 6;
        private const int _logOperatorNumber = 7;

        private const string _closingBracket = ")";
        private const string _emptyString = "";

        private List<Symbol> _input = new List<Symbol>();
        private List<Symbol> _operatorStack = new List<Symbol>();
        private List<Symbol> _output = new List<Symbol>();

        private List<History> _history = new List<History>();
        CalculatorMode _mode = CalculatorMode.Scienstific;

        private FunctionCategoriesStorage _functionCategoriesStorage = new FunctionCategoriesStorage();
        public FunctionCategoriesStorage FunctionCategoriesStorage => _functionCategoriesStorage;

        private const string _messageWhenTheNumberHasTooManyDots = "One of numbers has more dots than needed. \nNumbers can have only one dot to be decimal";
        private const string _messageWhenTheInputIsNull = "You should enter a number here";

        private bool _isTrigiometryOperatorThere = false;

        private string _resultAfterCalculation = _emptyString;

        private ThemeSwitcher _themeSwitcher = new ThemeSwitcher();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(0xBF, 0xCD, 0xBF);
            SwitchModes(CalculatorMode.Scienstific);
        }

        private void DarkThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            ApplyColorsForElements(DarkThemeSwitch.Checked);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region ButtonInput

        private void OneNumberButton_Click(object sender, EventArgs e)
        {
            Write("1");
        }

        private void Write(string text)
        {
            label2.Text += text;
        }

        private void WriteOperator(string text)
        {
            if (_isTrigiometryOperatorThere)
            {
                label2.Text += _closingBracket;
                _isTrigiometryOperatorThere = false;
            }

            label2.Text += text;
        }

        private void TwoNumberButton_Click(object sender, EventArgs e)
        {
            Write("2");
        }

        private void ThreeNumberButton_Click(object sender, EventArgs e)
        {
            Write("3");
        }

        private void FourNumberButton_Click(object sender, EventArgs e)
        {
            Write("4");
        }

        private void FiveNumberButton_Click(object sender, EventArgs e)
        {
            Write("5");
        }

        private void SixNumberButton_Click(object sender, EventArgs e)
        {
            Write("6");
        }

        private void SevenNumberButton_Click(object sender, EventArgs e)
        {
            Write("7");
        }

        private void EightNumberButton_Click(object sender, EventArgs e)
        {
            Write("8");
        }

        private void NineNumberButton_Click(object sender, EventArgs e)
        {
            Write("9");
        }

        private void ZeroNumberButton_Click(object sender, EventArgs e)
        {
            Write("0");
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            Write(".");
        }

        private void OpeningBracketButton_Click(object sender, EventArgs e)
        {
            Write("(");
        }

        private void ClosingBracketButton_Click(object sender, EventArgs e)
        {
            _isTrigiometryOperatorThere = false;

            Write(")");
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            RemoveLastCharacterFromInput();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            WriteOperator("+");
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            WriteOperator("-");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            WriteOperator("*");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            WriteOperator("/");
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            WriteOperator("^2");
        }

        private void MultiplyByItselfForYTimesButton_Click(object sender, EventArgs e)
        {
            WriteOperator("^");
        }

        private void TenMultipliedByXTime_Click(object sender, EventArgs e)
        {
            WriteOperator("10^");
        }

        private void ExponentButton_Click(object sender, EventArgs e)
        {
            Write("*10^15");
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            Write("cos(");
            _isTrigiometryOperatorThere = true;
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            Write("sin(");
            _isTrigiometryOperatorThere = true;
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            Write("tan(");
            _isTrigiometryOperatorThere = true;
        }

        private void SinhButton_Click(object sender, EventArgs e)
        {
            Write("sinh(");
            _isTrigiometryOperatorThere = true;
        }

        private void CoshButton_Click(object sender, EventArgs e)
        {
            Write("cosh(");
            _isTrigiometryOperatorThere = true;
        }

        private void TanhButton_Click(object sender, EventArgs e)
        {
            Write("tanh(");
            _isTrigiometryOperatorThere = true;
        }

        private void AnsButton_Click(object sender, EventArgs e)
        {
            if (_resultAfterCalculation != _emptyString)
                Write(_resultAfterCalculation);
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            Write("sqrt(");
            _isTrigiometryOperatorThere = true;
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            Write("log(");
            _isTrigiometryOperatorThere = true;
        }

        #endregion

        #region Clear

        private void ClearEverythingButton_Click(object sender, EventArgs e)
        {
            ClearEverything();
        }

        private void ClearEverything()
        {
            label2.Text = string.Empty;
            label1.Text = string.Empty;

            _isTrigiometryOperatorThere = false;

            ClearAllStacks();
        }

        private void ClearAllStacks()
        {
            _input.Clear();
            _operatorStack.Clear();
            _output.Clear();
        }

        private void RemoveLastCharacterFromInput()
        {
            if (label2.Text != _emptyString)
                label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
        }

        #endregion

        private void SetResultText(string input)
        {
            // Here I tried to make the label1's font decrease when there is too many characters to show in the program

            if (label1.Text.Length >= _maxAmountOfLettersOfResultOutputToDecreaseFontSize)
            {
                int timesToDecreaseTheFontSize = label1.Text.Length - _maxAmountOfLettersOfResultOutputToDecreaseFontSize;
                label1.Font = new Font(input, timesToDecreaseTheFontSize * _numberToDecreaseTheResultOutputLableFontSize);
            }

            label1.Text = input;
        }

        #region ShuntingYard

        private void EqualButton_Click(object sender, EventArgs e)
        {
            SeeResultOfCalculation();
        }

        private void SeeResultOfCalculation()
        {
            ClearAllStacks();
            DivideTextIntoItems();
            ExportFromInputToOutput();

            _resultAfterCalculation = ReturnTheOutput();
            SetResultText(_resultAfterCalculation);
            //label2.Text = ShowStackItems(_output);

            WriteNewStory();
        }

        private void DivideTextIntoItems()
        {
            string futureNumber = _emptyString;
            bool hasTheCurrentNumberThePoint = false;
            string futureTrigiometryOperator = _emptyString;
            int futureTrigiometryNumber = 0;
            int stepsToSkip = 0;
            char previousCharacter = ' ';

            for (int i = 0; i < label2.Text.Length; i++)
            {
                if (stepsToSkip != 0)
                {
                    stepsToSkip--;
                    continue;
                }

                switch (label2.Text[i])
                {
                    case (char)Symboles.ONE:
                    case (char)Symboles.TWO:
                    case (char)Symboles.THREE:
                    case (char)Symboles.FOUR:
                    case (char)Symboles.FIVE:
                    case (char)Symboles.SIX:
                    case (char)Symboles.SEVEN:
                    case (char)Symboles.EIGHT:
                    case (char)Symboles.NINE:
                    case (char)Symboles.ZERO:
                        futureNumber += label2.Text[i];

                        if (i == label2.Text.Length - 1)
                        {
                            Symbol newNumber = new Symbol(futureNumber, SymbolType.Number);
                            _input.Add(newNumber);

                            futureNumber = _emptyString;
                        }
                        break;

                    case (char)Symboles.POINT:
                        if (hasTheCurrentNumberThePoint)
                        {
                            WrongNumberException error = new WrongNumberException(label2, _messageWhenTheNumberHasTooManyDots);
                        }
                        else
                        {
                            futureNumber += label2.Text[i];
                            hasTheCurrentNumberThePoint = true;
                        }
                        break;

                    case (char)Symboles.ADD:
                    case (char)Symboles.SUBTRACT:
                        AddNewOperatorAndOperand(label2.Text[i], FUCKING_TWO, ref futureNumber, ref hasTheCurrentNumberThePoint);
                        break;

                    case (char)Symboles.MULTIPLY:
                    case (char)Symboles.DIVIDE:
                        AddNewOperatorAndOperand(label2.Text[i], _three, ref futureNumber, ref hasTheCurrentNumberThePoint);
                        break;


                    case (char)Symboles.OPENING_BRACKET:
                        if (futureTrigiometryOperator != _emptyString)
                        {
                            Symbol newOperator = new Symbol(futureTrigiometryOperator, SymbolType.Function, futureTrigiometryNumber);
                            _input.Add(newOperator);

                            futureTrigiometryOperator = _emptyString;
                        }

                        AddNewOperatorAndOperand(label2.Text[i], _three, ref futureNumber, ref hasTheCurrentNumberThePoint);
                        break;

                    case (char)Symboles.CLOSING_BRACKET:
                        AddNewOperatorAndOperand(label2.Text[i], _three, ref futureNumber, ref hasTheCurrentNumberThePoint);
                        break;

                    case (char)Symboles.POWER:
                        AddNewOperatorAndOperand(label2.Text[i], FUCKING_TWO * FUCKING_TWO, ref futureNumber, ref hasTheCurrentNumberThePoint);
                        break;

                    case (char)Symboles.LETTER_C:
                        futureTrigiometryOperator = "cos";
                        futureTrigiometryNumber = 0;
                        stepsToSkip = FUCKING_TWO;
                        break;

                    case (char)Symboles.LETTER_T:
                        futureTrigiometryOperator = "tan";
                        futureTrigiometryNumber = 2;
                        stepsToSkip = FUCKING_TWO;
                        break;

                    case (char)Symboles.LETTER_H:
                        futureTrigiometryOperator += "h";
                        futureTrigiometryNumber += _three;
                        break;

                    case (char)Symboles.LETTER_I: // i
                        futureTrigiometryOperator = "sin";
                        futureTrigiometryNumber = 1;
                        stepsToSkip = 1;
                        break;

                    case (char)Symboles.LETTER_Q:
                        futureTrigiometryOperator = "sqrt";
                        futureTrigiometryNumber = _sqrtOperatorNumber;
                        stepsToSkip = FUCKING_TWO;
                        break;

                    case (char)Symboles.LETTER_L:
                        futureTrigiometryOperator = "log";
                        futureTrigiometryNumber = _logOperatorNumber;
                        stepsToSkip = FUCKING_TWO;
                        break;
                }
            }
        }

        // Debug tool to know what the stacks contains
        private string ShowStackItems(List<Symbol> stack)
        {
            string result = _emptyString;

            for (int i = 0; i < stack.Count; i++)
            {
                if (i != stack.Count - 1)
                    result += stack[i].Value.ToString() + ", ";
                else
                    result += stack[i].Value.ToString();
            }

            return result;
        }

        private void AddNewOperatorAndOperand(char oper, int precendence, ref string futureNumber, ref bool hasTheCurrentNumberThePoint)
        {
            string opera = Convert.ToString(oper);

            Symbol newOperator = new Symbol(opera, precendence);
            Symbol newNumber = new Symbol(futureNumber, SymbolType.Number);

            if (newNumber.Value != _emptyString)
                _input.Add(newNumber);

            futureNumber = _emptyString;
            hasTheCurrentNumberThePoint = false;

            _input.Add(newOperator);
        }

        private void ExportFromInputToOutput()
        {
            int amountOfNumbers = _input.Count(p => p.Type == SymbolType.Number);

            for (int i = 0; i < _input.Count; i++)
            {
                Symbol currentSymbol = _input[i];

                switch (currentSymbol.Type)
                {
                    case SymbolType.Number:
                        AddNewNumberToOutput(currentSymbol, ref amountOfNumbers);
                        break;
                    case SymbolType.Function:
                        AddOperatorToItsStack(currentSymbol);
                        break;
                    case SymbolType.Operator:

                        char currentOper = Convert.ToChar(currentSymbol.Value);

                        switch (currentOper)
                        {
                            case (char)Symboles.OPENING_BRACKET:
                                AddOperatorToItsStack(currentSymbol);
                                break;

                            case (char)Symboles.CLOSING_BRACKET:
                                PopAllTheOperatorsUntilTheLeftParenthisMeetItsPart();
                                break;

                            case (char)Symboles.POWER:
                                if (ConditionForRightAssociativity(currentSymbol))
                                    PopTheLastOperatorToOutputAndAddCurrentToItsStack(currentSymbol);
                                else
                                    AddOperatorToItsStack(currentSymbol);

                                break;

                            default:
                                AddOperatorsWithEqualOrHigherPrecendence(currentSymbol);
                                break;
                        }

                        break;
                }
            }

            for (int i = _operatorStack.Count; i-- > 0;)
            {
                _output.Add(_operatorStack[i]);
            }

            RemoveAllBrackets();
        }

        private void AddNewNumberToOutput(Symbol number, ref int amountOfNumbers)
        {
            _output.Add(number);
            amountOfNumbers--;
        }

        private void PopTheLastOperatorToOutputAndAddCurrentToItsStack(Symbol currentItem)
        {
            _output.Add(_operatorStack[_operatorStack.Count - 1]);
            _operatorStack.RemoveAt(_operatorStack.Count - 1);
            AddOperatorToItsStack(currentItem);
        }

        private void PopTheLastOperatorToOutput()
        {
            _output.Add(_operatorStack[_operatorStack.Count - 1]);
            _operatorStack.RemoveAt(_operatorStack.Count - 1);
        }

        private bool CompareLPrecendence(int firstNumber, int secondNumber) // L - left-associated
        {
            if (firstNumber >= secondNumber) return true;

            return false;
        }

        private bool CompareRPrecendence(int firstNumber, int secondNumber) // R - right-associated
        {
            if (firstNumber > secondNumber) return true;

            return false;
        }

        private bool ConditionForLeftAssociativity(Symbol currentSymbol)
        {
            return _operatorStack.Count != 0 && _operatorStack[_operatorStack.Count - 1].Value != "(" && CompareLPrecendence(_operatorStack[_operatorStack.Count - 1].Precendence, currentSymbol.Precendence);
        }

        private bool ConditionForRightAssociativity(Symbol currentSymbol)
        {
            return _operatorStack.Count != 0 && CompareRPrecendence(_operatorStack[_operatorStack.Count - 1].Precendence, currentSymbol.Precendence);
        }

        private void AddOperatorsWithEqualOrHigherPrecendence(Symbol currentSymbol)
        {
            if (_operatorStack.Count == 0)
                AddOperatorToItsStack(currentSymbol);
            else
            {
                for (int i = _operatorStack.Count; i-- > 0;)
                    if (ConditionForLeftAssociativity(currentSymbol))
                        PopTheLastOperatorToOutput();

                AddOperatorToItsStack(currentSymbol);
            }
        }

        private void AddOperatorToItsStack(Symbol oper)
        {
            _operatorStack.Add(oper);
        }

        private void PopAllTheOperatorsUntilTheLeftParenthisMeetItsPart()
        {
            for (int i = _operatorStack.Count; i-- > 0;)
            {
                if (_operatorStack[i].Value == "(")
                {

                    if (_operatorStack.Last<Symbol>().Type == SymbolType.Function)
                    {
                        _output.Add(_operatorStack[i - 1]);
                        _operatorStack.RemoveAt(i - 1);
                    }

                    _operatorStack.RemoveAt(i);



                    //if (_operatorStack[i - 1].Type == SymbolType.Function)


                    break;
                }
                else
                {
                    _output.Add(_operatorStack[i]);
                    _operatorStack.RemoveAt(i);
                }
            }
        }

        private void RemoveAllBrackets()
        {
            _output.RemoveAll(leftParanthesis => leftParanthesis.Value == "(");
        }

        private string ReturnTheOutput()
        {
            Stack<double> numberStack = new Stack<double>();

            for (int i = 0; i < _output.Count; i++)
            {
                switch (_output[i].Type)
                {
                    case SymbolType.Number:
                        double numberToPush = (double)ConvertToFloat(_output[i].Value);
                        numberStack.Push(numberToPush);
                        break;

                    case SymbolType.Operator:

                        char currentOper = Convert.ToChar(_output[i].Value);

                        double firstNumber = numberStack.Pop();
                        double secondNumber = numberStack.Pop();

                        switch (currentOper)
                        {
                            case (char)Symboles.POWER:
                                numberStack.Push(MathF.Pow((float)firstNumber, (float)secondNumber));
                                break;

                            default:
                                numberStack.Push(Calculate((float)firstNumber, (float)secondNumber, currentOper));
                                break;
                        }

                        break;

                    case SymbolType.Function:
                        double number = numberStack.Pop();
                        numberStack.Push(ReturnTheNumberAfterTrigiometryOperations((float)number, _output[i].TrigiometryNumber));
                        break;
                }

            }

            return numberStack.Pop().ToString();

            //double firstNumber = 0, secondNumber = 0;

            //for (int i = 0; i < _output.Count; i++)
            //{
            //    switch (_output[i].Type)
            //    {
            //        case SymbolType.Number:
            //            if (firstNumber == 0)
            //                firstNumber = ConvertToFloat(_output[i].Value);
            //            else
            //                secondNumber = ConvertToFloat(_output[i].Value);
            //            break;

            //        case SymbolType.Operator:
            //            char currentSymbol = Convert.ToChar(_output[i].Value);

            //            switch (currentSymbol)
            //            {
            //                case (char)Symboles.POWER:
            //                    firstNumber = MathF.Pow((float)firstNumber, (float)secondNumber);
            //                    break;

            //                default:
            //                    firstNumber = Calculate((float)firstNumber, (float)secondNumber, currentSymbol);
            //                    break;
            //            }

            //            break;

            //        case SymbolType.Function:
            //            firstNumber = ReturnTheNumberAfterTrigiometryOperations((float)firstNumber, _output[i].TrigiometryNumber);
            //            break;
            //    }

            //}

            //return firstNumber.ToString();
        }

        private float ConvertToFloat(string value)
        {
            // "CultureInfo.InvariantCulture" is for accepting the dot whatever it is '.' or ','
            return (float)Convert.ToDouble(value, CultureInfo.InvariantCulture);
        }

        private float Calculate(float x, float y, char oper)
        {
            switch (oper)
            {
                case (char)Symboles.ADD:
                    return x + y;
                case (char)Symboles.SUBTRACT:
                    return x - y;
                case (char)Symboles.MULTIPLY:
                    return x * y;
                case (char)Symboles.DIVIDE:
                    return x / y;
            }

            return 0;
        }

        #endregion

        #region Percente

        private void PercenteButton_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Convert.ToDouble(label2.Text);
                result /= 100;
                label2.Text = result.ToString();
            }

            catch (Exception ex)
            {
                if (label2.Text == _emptyString)
                {
                    WrongNumberException error = new WrongNumberException(label2, _messageWhenTheInputIsNull);
                }
                else
                {
                    WrongNumberException error = new WrongNumberException(label2);
                }
            }
        }

        #endregion

        #region Trigiometry 

        private float ReturnTheNumberAfterTrigiometryOperations(float degrees, int number)
        {
            float radians = degrees * ((float)Math.PI / 180f);

            switch (number)
            {

                case 0: // cos
                    return MathF.Cos(radians);
                case 1: // sin
                    return MathF.Sin(radians);
                case FUCKING_TWO: // tan
                    return MathF.Tan(radians);
                case _three: // cosh
                    return MathF.Cosh(radians);
                case 4: // sinh
                    return MathF.Sinh(radians);
                case 5: // tanh
                    return MathF.Tanh(radians);
                case _sqrtOperatorNumber: // sqrt
                    return MathF.Sqrt(degrees);
                case _logOperatorNumber: // log
                    return MathF.Log(degrees);
            }

            return 0;
        }

        #endregion

        #region Factorial

        private void FactorialButton_Click(object sender, EventArgs e)
        {
            try
            {
                float number = ConvertToFloat(label2.Text.ToString());
                SetResultText(FindFactorial(number).ToString());
            }
            catch (Exception ex)
            {
                if (label2.Text == _emptyString)
                {
                    WrongNumberException error = new WrongNumberException(label2, _messageWhenTheInputIsNull);
                }
                else
                {
                    WrongNumberException error = new WrongNumberException(label2);
                }
            }
        }

        public static float FindFactorial(float number)
        {
            float result = 1;

            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }

        #endregion

        #region ThemeSwitch

        private void ApplyColorsForElements(bool isTurnedOn)
        {
            int[,] colorPallet = isTurnedOn ? _themeSwitcher.DarkThemeColorCodes : _themeSwitcher.LightThemeColorCodes;

            this.BackColor = Color.FromArgb(colorPallet[0, 0], colorPallet[0, 1], colorPallet[0, FUCKING_TWO]);
            DarkThemeSwitch.ForeColor = Color.FromArgb(colorPallet[FUCKING_TWO, 0], colorPallet[FUCKING_TWO, 1], colorPallet[FUCKING_TWO, FUCKING_TWO]);

            int[] backColorOfButtonColorPallet = { colorPallet[1, 0], colorPallet[1, 1], colorPallet[1, FUCKING_TWO] };
            int[] foreColorOfButtonColorPallet = { colorPallet[FUCKING_TWO, 0], colorPallet[FUCKING_TWO, 1], colorPallet[FUCKING_TWO, FUCKING_TWO] };

            ApplyColorsForNumberButtons(backColorOfButtonColorPallet, foreColorOfButtonColorPallet);

            backColorOfButtonColorPallet = [colorPallet[_three, 0], colorPallet[_three, 1], colorPallet[_three, FUCKING_TWO]];
            foreColorOfButtonColorPallet = [colorPallet[FUCKING_TWO, 0], colorPallet[FUCKING_TWO, 1], colorPallet[FUCKING_TWO, FUCKING_TWO]];

            ApplyColorsForOperatorButtons(backColorOfButtonColorPallet, foreColorOfButtonColorPallet);

            EqualButton.BackColor = Color.FromArgb(colorPallet[FUCKING_TWO * 2, 0], colorPallet[FUCKING_TWO * 2, 1], colorPallet[FUCKING_TWO * 2, FUCKING_TWO]);

            backColorOfButtonColorPallet = [colorPallet[FUCKING_TWO + FUCKING_TWO + 1, 0], colorPallet[FUCKING_TWO + FUCKING_TWO + 1, 1], colorPallet[FUCKING_TWO + FUCKING_TWO + 1, FUCKING_TWO]];
            foreColorOfButtonColorPallet = [colorPallet[FUCKING_TWO + FUCKING_TWO + FUCKING_TWO, 0], colorPallet[FUCKING_TWO + FUCKING_TWO + FUCKING_TWO, 1], colorPallet[FUCKING_TWO + FUCKING_TWO + FUCKING_TWO, FUCKING_TWO]];

            ApplyColorsFOrGroupBoxesAndItsChildren(backColorOfButtonColorPallet, foreColorOfButtonColorPallet, isTurnedOn);
        }

        private void ApplyColorsForNumberButtons(int[] backColorPalete, int[] foreColorPalate)
        {
            Button[] buttons = { ZeroNumberButton,
                PointButton,
                OpeningBracketButton,
                ClosingBracketButton,
                OneNumberButton,
                TwoNumberButton,
                ThreeNumberButton,
                FourNumberButton,
                FiveNumberButton,
                SixNumberButton,
                SevenNumberButton,
                EightNumberButton,
                NineNumberButton,
                BackspaceButton,
                PercenteButton,
                AddButton,
                SubtractButton,
                MultiplyButton,
                DivideButton };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = Color.FromArgb(backColorPalete[0], backColorPalete[1], backColorPalete[FUCKING_TWO]);
                buttons[i].ForeColor = Color.FromArgb(foreColorPalate[0], foreColorPalate[1], foreColorPalate[FUCKING_TWO]);
            }
        }

        private void ApplyColorsForOperatorButtons(int[] backColorPalete, int[] foreColorPalate)
        {
            Button[] buttons = { SquareButton,
                SqrtButton,
                MultiplyByItselfForYTimesButton,
                SinButton,
                CosButton,
                TanButton,
                SinhButton,
                CoshButton,
                TanhButton,
                FactorialButton,
                ExponentButton,
                AnsButton,
                LogButton,
                ModButton,
                TenMultipliedByXTime };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = Color.FromArgb(backColorPalete[0], backColorPalete[1], backColorPalete[FUCKING_TWO]);
                buttons[i].ForeColor = Color.FromArgb(foreColorPalate[0], foreColorPalate[1], foreColorPalate[FUCKING_TWO]);
            }
        }

        private void ApplyColorsFOrGroupBoxesAndItsChildren(int[] backColorPalate, int[] foreColorPalate, bool isDarkTheme)
        {
            GroupBox[] groupBoxes = { groupBox1, ConverterGroupBox };
            Button[] buttons = {
                ScientificModeButton,
                ProgrammerModeButton,
                CalculusModeButton,
                DateModeButton,
                LengthConvertButton,
                AreaConvertButton,
                VolumeConvertButton,
                TimeConvertButton,
                AngleConvertButton,
                SpeedConvertButton,
                MassConvertButton,
                PressureConvertButton
            };

            foreach (GroupBox groupBox in groupBoxes)
            {
                groupBox.BackColor = Color.FromArgb(backColorPalate[0], backColorPalate[1], backColorPalate[FUCKING_TWO]);
                groupBox.ForeColor = Color.FromArgb(foreColorPalate[0], foreColorPalate[1], foreColorPalate[FUCKING_TWO]);
            }

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = Color.FromArgb(backColorPalate[0], backColorPalate[1], backColorPalate[FUCKING_TWO]);
                buttons[i].ForeColor = Color.FromArgb(foreColorPalate[0], foreColorPalate[1], foreColorPalate[FUCKING_TWO]);
            }
        }

        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe aboutMe = new AboutMe();
            aboutMe.Show();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        #region KeyboardInput

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    Write("0");
                    break;       // 0
                case Keys.NumPad1:
                case Keys.D1:
                    Write("1");
                    break;       // 1
                case Keys.NumPad2:
                case Keys.D2:
                    Write("2");
                    break;       // 2
                case Keys.NumPad3:
                case Keys.D3:
                    Write("3");
                    break;       // 3
                case Keys.NumPad4:
                case Keys.D4:
                    Write("4");
                    break;       // 4
                case Keys.NumPad5:
                case Keys.D5:
                    Write("5");
                    break;       // 5
                case Keys.NumPad6:
                case Keys.D6:
                    Write("6");
                    break;       // 6
                case Keys.NumPad7:
                case Keys.D7:
                    Write("7");
                    break;       // 7
                case Keys.NumPad8:
                case Keys.D8:
                    Write("8");
                    break;       // 8
                case Keys.NumPad9:
                case Keys.D9:
                    Write("9");
                    break;       // 9
                case Keys.Enter:
                    SeeResultOfCalculation();
                    break;    // Enter
                case Keys.Back:
                    RemoveLastCharacterFromInput();
                    break;     // Backspace
                case Keys.Add:
                    WriteOperator("+");
                    break;      // +
                case Keys.Subtract:
                    WriteOperator("-");
                    break; // -
                case Keys.Multiply:
                    WriteOperator("*");
                    break; // *
                case Keys.Divide:
                    WriteOperator("/");
                    break;   // /
                case Keys.Delete:
                    ClearEverything();
                    break;   // Delete
            }
        }

        #endregion

        #region History

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyBrowser = new HistoryForm();
            historyBrowser.ShowItselfAndCalcHistory(_history);
        }

        private void MemoryPlusButton_Click(object sender, EventArgs e)
        {
            if (label1.Text != _emptyString && label2.Text != _emptyString)
                WriteNewStory();
        }

        private void WriteNewStory()
        {
            double resultToDouble = Convert.ToDouble(label1.Text);
            _history.Add(new History(label2.Text, resultToDouble, _mode));
        }

        private void MemoryMinusButton_Click(object sender, EventArgs e)
        {
            if (_history.Count != 0)
                _history.Remove(_history.Last());
        }

        private void MRButton_Click(object sender, EventArgs e)
        {
            if (_history.Count != 0)
                Write(_history.Last().Result.ToString());
            else
                Write("0");
        }

        private void MCButton_Click(object sender, EventArgs e)
        {
            _history.Clear();
        }

        #endregion

        #region CalculatorModeSwitcher

        private void SwitchModes(CalculatorMode mode)
        {
            switch (mode)
            {
                case CalculatorMode.Scienstific:
                    EnableScienctific(true);
                    EnableCalculus(false);
                    break;
                case CalculatorMode.Calculus:
                    EnableScienctific(false);
                    EnableCalculus(true);
                    break;
            }
        }

        private void EnableScienctific(bool enable)
        {
            PercenteButton.Visible = enable;
            FactorialButton.Visible = enable;
            ExponentButton.Visible = enable;
        }

        private void EnableCalculus(bool enable)
        {
            FunctionButton.Visible = enable;
            IntegralButton.Visible = enable;
            XButton.Visible = enable;
        }

        private void ScientificModeButton_Click(object sender, EventArgs e)
        {
            _mode = CalculatorMode.Scienstific;
            SwitchModes(_mode);
        }

        private void CalculusModeButton_Click(object sender, EventArgs e)
        {
            _mode = CalculatorMode.Calculus;
            SwitchModes(_mode);
        }

        #endregion

        private void FunctionButton_Click(object sender, EventArgs e)
        {
            //FunctionTest newFunction = new FunctionTest("Test0", "x+6-y*sin(60)/4*z-cos(45)+(zu/va)");
            //FunctionTest pikmin = new FunctionTest("Test1", "6925-35675+25-x*56+sin(67)^2");
            //FunctionTest mara = new FunctionTest("Test2", "x-7/da*4-22-4");

            FunctionActionChoose functionActionChoose = new FunctionActionChoose();
            functionActionChoose.ShowItself(_functionCategoriesStorage, this);
        }

        public void UpdateFunctionCategoriesStorage(FunctionCategoriesStorage functionCategoriesStorage)
        {
            _functionCategoriesStorage = functionCategoriesStorage;
        }

        // Debug tool to make sure that variable sorting works well
        public class FunctionTest
        {
            private Function _newFunction;
            private string _message;

            public FunctionTest(string functionName, string functionExpression)
            {
                _newFunction = new Function(functionName, functionExpression);
                _message = $"Name: {_newFunction.Name} \nExpression: {_newFunction.Expression}\nVariables: ";
                
                for (int i = 0; i < _newFunction.Variables.Length; i++)
                {
                    if (i != 0)
                        _message += $", {_newFunction.Variables[i]} ";
                    else
                        _message += $"  {_newFunction.Variables[i]} ";
                }
                
                _message += $"\nAmount of Variables: {_newFunction.AmountOfVariables} ";
                MessageBox.Show(_message);
            }
        }
    }

    public class WrongNumberException
    {
        private string _message, _title;
        private MessageBoxButtons _buttons;
        private DialogResult _result;

        private const string _defaultTitle = "Error";

        public WrongNumberException(System.Windows.Forms.Label label) 
        {
            _message = "You can only enter numbers to do it";
            _title = _defaultTitle;
            _buttons = MessageBoxButtons.OK;
            _result = MessageBox.Show(_message, _title, _buttons, MessageBoxIcon.Error);
            label.Text = string.Empty;
        }

        public WrongNumberException(System.Windows.Forms.Label label, string message)
        {
            _message = message;
            _title = _defaultTitle;
            _buttons = MessageBoxButtons.OK;
            _result = MessageBox.Show(_message, _title, _buttons, MessageBoxIcon.Error);
            label.Text = string.Empty;
        }
    }

    public enum Symboles
    {
        ONE = '1',
        TWO = '2',
        THREE = '3',
        FOUR = '4',
        FIVE = '5',
        SIX = '6',
        SEVEN = '7',
        EIGHT = '8',
        NINE = '9',
        ZERO = '0',
        ADD = '+',
        SUBTRACT = '-',
        MULTIPLY = '*',
        DIVIDE = '/',
        OPENING_BRACKET = '(',
        CLOSING_BRACKET = ')',
        POINT = '.',
        POWER = '^',
        LETTER_S = 's',
        LETTER_I = 'i',
        LETTER_C = 'c',
        LETTER_T = 't',
        LETTER_H = 'h',
        LETTER_Q = 'q',
        LETTER_L = 'l'
    }
}
