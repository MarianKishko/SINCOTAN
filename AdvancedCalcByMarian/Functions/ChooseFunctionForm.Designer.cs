namespace AdvancedCalcByMarian.Functions
{
    partial class ChooseFunctionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Custom");
            TreeNode treeNode2 = new TreeNode("Algebra");
            TreeNode treeNode3 = new TreeNode("All", new TreeNode[] { treeNode1, treeNode2 });
            treeView1 = new TreeView();
            CategoryLabel = new Label();
            listBox1 = new ListBox();
            FunctionsLabel = new Label();
            AddNewFunctionButton = new Button();
            EditFunctionButton = new Button();
            InsertFunctionButton = new Button();
            DeleteFunctionButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 41);
            treeView1.Name = "treeView1";
            treeNode1.Name = "CustomFunctions";
            treeNode1.Text = "Custom";
            treeNode2.Name = "Algebra";
            treeNode2.Text = "Algebra";
            treeNode3.Name = "AllCategories";
            treeNode3.Text = "All";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3 });
            treeView1.Size = new Size(271, 579);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(12, 9);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(84, 25);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(289, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(464, 579);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FunctionsLabel
            // 
            FunctionsLabel.AutoSize = true;
            FunctionsLabel.Location = new Point(289, 13);
            FunctionsLabel.Name = "FunctionsLabel";
            FunctionsLabel.Size = new Size(88, 25);
            FunctionsLabel.TabIndex = 1;
            FunctionsLabel.Text = "Functions";
            // 
            // AddNewFunctionButton
            // 
            AddNewFunctionButton.Location = new Point(759, 40);
            AddNewFunctionButton.Name = "AddNewFunctionButton";
            AddNewFunctionButton.Size = new Size(133, 34);
            AddNewFunctionButton.TabIndex = 3;
            AddNewFunctionButton.Text = "Add";
            AddNewFunctionButton.UseVisualStyleBackColor = true;
            // 
            // EditFunctionButton
            // 
            EditFunctionButton.Location = new Point(759, 80);
            EditFunctionButton.Name = "EditFunctionButton";
            EditFunctionButton.Size = new Size(133, 34);
            EditFunctionButton.TabIndex = 3;
            EditFunctionButton.Text = "Edit";
            EditFunctionButton.UseVisualStyleBackColor = true;
            // 
            // InsertFunctionButton
            // 
            InsertFunctionButton.Location = new Point(759, 120);
            InsertFunctionButton.Name = "InsertFunctionButton";
            InsertFunctionButton.Size = new Size(133, 34);
            InsertFunctionButton.TabIndex = 3;
            InsertFunctionButton.Text = "Insert";
            InsertFunctionButton.UseVisualStyleBackColor = true;
            // 
            // DeleteFunctionButton
            // 
            DeleteFunctionButton.BackColor = Color.FromArgb(204, 62, 69);
            DeleteFunctionButton.ForeColor = SystemColors.ButtonHighlight;
            DeleteFunctionButton.Location = new Point(759, 160);
            DeleteFunctionButton.Name = "DeleteFunctionButton";
            DeleteFunctionButton.Size = new Size(133, 34);
            DeleteFunctionButton.TabIndex = 3;
            DeleteFunctionButton.Text = "Delete";
            DeleteFunctionButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(12, 626);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(880, 151);
            textBox1.TabIndex = 4;
            // 
            // ChooseFunctionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 789);
            Controls.Add(textBox1);
            Controls.Add(DeleteFunctionButton);
            Controls.Add(InsertFunctionButton);
            Controls.Add(EditFunctionButton);
            Controls.Add(AddNewFunctionButton);
            Controls.Add(listBox1);
            Controls.Add(FunctionsLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(treeView1);
            Name = "ChooseFunctionForm";
            Text = "ChooseFunctionForm";
            Load += ChooseFunctionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label CategoryLabel;
        private ListBox listBox1;
        private Label FunctionsLabel;
        private Button AddNewFunctionButton;
        private Button EditFunctionButton;
        private Button InsertFunctionButton;
        private Button DeleteFunctionButton;
        private TextBox textBox1;
    }
}