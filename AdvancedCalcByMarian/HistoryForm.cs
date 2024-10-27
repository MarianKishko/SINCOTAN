using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCalcByMarian
{
    public partial class HistoryForm : Form
    {
        private List<History> _history = new List<History>();

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _history;
            dataGridView1.Refresh();
        }

        public void ShowItselfAndCalcHistory(List<History> history)
        {
            _history = history;
            this.Show();
        }
    }
}
