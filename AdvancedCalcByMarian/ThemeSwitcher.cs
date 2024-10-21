using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalcByMarian
{
    public partial class ThemeSwitcher
    {
        private const int _maxCountOfColumn = 3;

        private const int _darkCharcoalColor = 49;
        private const int _charcoalColor = 69;
        private const int _lightGray = 179;
        private const int _mutedGray = 130;

        private const int _whitesmokeColor = 245;
        private const int _whiteColor = 255;
        private const int _blackColor = 0;
        private const int _gainsboroColor = 220;

        private int[,] _lightThemeColorCodes = new int[7,3];
        private int[,] _darkThemeColorCodes = new int[7,3];

        public int[,] LightThemeColorCodes => _lightThemeColorCodes;
        public int[,] DarkThemeColorCodes => _darkThemeColorCodes;

        public ThemeSwitcher() 
        {
            ApplyColorsForDarkTheme();
            ApplyColorsForLightTheme();
        }

        private void ApplyColorsForDarkTheme()
        {
            AddSameValueToEachColumn(_darkCharcoalColor, 0, ref _darkThemeColorCodes);
            AddSameValueToEachColumn(_charcoalColor, 1, ref _darkThemeColorCodes);
            AddSameValueToEachColumn(_lightGray, 2, ref _darkThemeColorCodes);

            _darkThemeColorCodes[3, 0] = 73;
            _darkThemeColorCodes[3, 1] = 81;
            _darkThemeColorCodes[3, 2] = 87;

            _darkThemeColorCodes[4, 0] = 54;
            _darkThemeColorCodes[4, 1] = 162;
            _darkThemeColorCodes[4, 2] = 248;
        
            AddSameValueToEachColumn(_mutedGray, 5, ref _darkThemeColorCodes);
            AddSameValueToEachColumn(255, 6, ref _darkThemeColorCodes);
        }

        private void ApplyColorsForLightTheme()
        {
            AddSameValueToEachColumn(_whitesmokeColor, 0, ref _lightThemeColorCodes);
            AddSameValueToEachColumn(_whiteColor, 1, ref _lightThemeColorCodes);
            AddSameValueToEachColumn(_blackColor, 2, ref _lightThemeColorCodes);

            _lightThemeColorCodes[3, 0] = 169;
            _lightThemeColorCodes[3, 1] = 178;
            _lightThemeColorCodes[3, 2] = 187;

            _lightThemeColorCodes[4, 0] = 54;
            _lightThemeColorCodes[4, 1] = 98;
            _lightThemeColorCodes[4, 2] = 140;

            AddSameValueToEachColumn(_gainsboroColor, 5, ref _lightThemeColorCodes);

        }

        private void AddSameValueToEachColumn(int numberToApply, int row, ref int[,] array)
        {
            for (int i = 0; i < _maxCountOfColumn; i++)
                array[row, i] = numberToApply;
        }

        private void AddSameValueToEachColumn(Color colorToApply, int row, ref int[,] array)
        {

        }
    }
}
