namespace AdvancedCalcByMarian.Functions
{
    partial class CreateNewFunctionForm
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
            NewFunctionNameLable = new Label();
            textBox1 = new TextBox();
            NewFunctionExpressionLable = new Label();
            textBox2 = new TextBox();
            CreateNewFunctionButton = new Button();
            AdvancedNewFunctionCreationButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // NewFunctionNameLable
            // 
            NewFunctionNameLable.AutoSize = true;
            NewFunctionNameLable.Location = new Point(12, 9);
            NewFunctionNameLable.Name = "NewFunctionNameLable";
            NewFunctionNameLable.Size = new Size(63, 25);
            NewFunctionNameLable.TabIndex = 0;
            NewFunctionNameLable.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(485, 31);
            textBox1.TabIndex = 1;
            // 
            // NewFunctionExpressionLable
            // 
            NewFunctionExpressionLable.AutoSize = true;
            NewFunctionExpressionLable.Location = new Point(12, 71);
            NewFunctionExpressionLable.Name = "NewFunctionExpressionLable";
            NewFunctionExpressionLable.Size = new Size(100, 25);
            NewFunctionExpressionLable.TabIndex = 0;
            NewFunctionExpressionLable.Text = "Expression:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 102);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(485, 395);
            textBox2.TabIndex = 1;
            // 
            // CreateNewFunctionButton
            // 
            CreateNewFunctionButton.Location = new Point(385, 503);
            CreateNewFunctionButton.Name = "CreateNewFunctionButton";
            CreateNewFunctionButton.Size = new Size(112, 34);
            CreateNewFunctionButton.TabIndex = 2;
            CreateNewFunctionButton.Text = "Create";
            CreateNewFunctionButton.UseVisualStyleBackColor = true;
            CreateNewFunctionButton.Click += CreateNewFunctionButton_Click;
            // 
            // AdvancedNewFunctionCreationButton
            // 
            AdvancedNewFunctionCreationButton.Location = new Point(12, 502);
            AdvancedNewFunctionCreationButton.Name = "AdvancedNewFunctionCreationButton";
            AdvancedNewFunctionCreationButton.Size = new Size(112, 34);
            AdvancedNewFunctionCreationButton.TabIndex = 2;
            AdvancedNewFunctionCreationButton.Text = "Advanced";
            AdvancedNewFunctionCreationButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(267, 503);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateNewFunctionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 548);
            Controls.Add(CancelButton);
            Controls.Add(AdvancedNewFunctionCreationButton);
            Controls.Add(CreateNewFunctionButton);
            Controls.Add(textBox2);
            Controls.Add(NewFunctionExpressionLable);
            Controls.Add(textBox1);
            Controls.Add(NewFunctionNameLable);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateNewFunctionForm";
            Text = "CreateNewFunctionForm";
            Load += CreateNewFunctionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NewFunctionNameLable;
        private TextBox textBox1;
        private Label NewFunctionExpressionLable;
        private TextBox textBox2;
        private Button CreateNewFunctionButton;
        private Button AdvancedNewFunctionCreationButton;
        private Button CancelButton;
    }
}