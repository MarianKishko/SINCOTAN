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
    public partial class ChooseFunctionForm : Form
    {
        private FunctionCategoriesStorage _categoriesStorage;

        public void AddFunctionIntoTheCategory()
        {
            for (int i = 0; i < _categoriesStorage.Categories.Length; i++)
            {
                treeView1.Nodes[0].Nodes[i].Tag = _categoriesStorage.Categories[i];
            }
        }

        public ChooseFunctionForm(FunctionCategoriesStorage categories)
        {
            _categoriesStorage = categories;

            InitializeComponent();
        }

        private void ChooseFunctionForm_Load(object sender, EventArgs e)
        {
            AddFunctionIntoTheCategory();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();

            if (treeView1.SelectedNode.Tag != null)
                foreach (Function function in (List<Function>)treeView1.SelectedNode.Tag)
                    listBox1.Items.Add(function.Name);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Function> functions = new List<Function>();

            // Getting items from the selected node and storing it to local list
            
            if (treeView1.SelectedNode.Tag is List<Function>)
                functions = treeView1.SelectedNode.Tag as List<Function>;

            AddTitleToTheTextBox(functions);
            //WriteArgumentsToSelectedFunction(ref functions);
        }

        private void AddTitleToTheTextBox(List<Function> functions)
        {
            textBox1.Clear();

            textBox1.Text = $"{functions[listBox1.SelectedIndex].Name}(";

            for (int i = 0; i < functions[listBox1.SelectedIndex].AmountOfVariables; i++)
            {
                string addingNewText = $"argument {functions[listBox1.SelectedIndex].Variables[i]}";

                if (i != functions[listBox1.SelectedIndex].AmountOfVariables - 1)
                    addingNewText += ", ";

                textBox1.Text += addingNewText;
            }

            textBox1.Text += ")\r\r";
        }


        // Not necessary?
        private void WriteArgumentsToSelectedFunction(ref List<Function> functions)
        {
            textBox1.Text += "Arguments";

            for (int i = 0; functions[listBox1.SelectedIndex].AmountOfVariables > 0; i++)
            {
                textBox1.Text += $"\r{functions[listBox1.SelectedIndex].Variables[i]}: Argument";
            }
        }
    }
}
