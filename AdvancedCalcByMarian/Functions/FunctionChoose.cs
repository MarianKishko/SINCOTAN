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
    public partial class FunctionActionChoose : Form
    {
        private FunctionCategoriesStorage _categories;
        private Form1 _mainWindow;

        public FunctionActionChoose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewFunctionForm functionCreation = new CreateNewFunctionForm(_mainWindow);
            functionCreation.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseFunctionForm chooseFunctionForm = new ChooseFunctionForm(_categories);
            chooseFunctionForm.Show();
            this.Close();
        }

        public void ShowItself(FunctionCategoriesStorage categories, Form1 mainWindow)
        {
            this.Show();
            _categories = categories;
            _mainWindow = mainWindow;
        }

        private void FunctionActionChoose_Load(object sender, EventArgs e)
        {

        }
    }
}
