using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalcByMarian.Functions
{
    public class FunctionCategoriesStorage
    {
        private List<Function>[] _categories = new List<Function>[2];
        private List<Function> _algebraFunctions;
        private List<Function> _customFunctions;

        public List<Function>[] Categories => _categories;

        public FunctionCategoriesStorage() 
        {
            InitialazingCategories();

            InitializeAlgebraCategory();

            AddItemsToCategories();
        }

        private void InitialazingCategories()
        {
            _categories[0] = new List<Function>();
            _categories[1] = new List<Function>();
        }

        private void InitializeAlgebraCategory()
        {
            _algebraFunctions = [
                new Function("Test0", "(do *lja)-6 ^ 2"),
                new Function("Test1", "x+y"),
                new Function("Test2", "x/z*2"),
                new Function("Divide Fraction", "(x*z+y)/z")
            ];
        }

        private void AddItemsToCategories() 
        {
            AddItemsFromArrayToList(_customFunctions, 0);
            AddItemsFromArrayToList(_algebraFunctions, 1);
        }

        private void AddItemsFromArrayToList(List<Function> functions, int indexOfList)
        {
            if (functions != null)
            {
                for (int i = 0; i < functions.Count; i++)
                {
                    _categories[indexOfList].Add(functions[i]);
                }
            }
        }

        public void AddNewFunctionToDefaultPlace(Function newFunction)
        {
            _categories[0].Add(newFunction);
        }
    }
}
