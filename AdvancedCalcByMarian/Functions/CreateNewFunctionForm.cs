using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCalcByMarian.Functions
{
    public partial class CreateNewFunctionForm : Form
    {
        private FunctionCategoriesStorage _categories = new FunctionCategoriesStorage();
        private Form1 _mainWindow;

        public CreateNewFunctionForm(Form1 mainWindow)
        {
            _categories = mainWindow.FunctionCategoriesStorage;
            _mainWindow = mainWindow;

            InitializeComponent();
        }

        private void CreateNewFunctionForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewFunctionButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string expression = textBox2.Text;

            Function newFunction = new Function(name, expression);
            _categories.AddNewFunctionToDefaultPlace(newFunction);
            _mainWindow.UpdateFunctionCategoriesStorage(_categories);
            this.Close();
        }
    }
}
