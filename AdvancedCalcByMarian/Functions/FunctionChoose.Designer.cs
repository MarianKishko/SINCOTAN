namespace AdvancedCalcByMarian.Functions
{
    partial class FunctionActionChoose
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
            button2 = new Button();
            button1 = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(66, 132);
            button2.Name = "button2";
            button2.Size = new Size(265, 34);
            button2.TabIndex = 1;
            button2.Text = "Choose";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(66, 92);
            button1.Name = "button1";
            button1.Size = new Size(265, 34);
            button1.TabIndex = 0;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(66, 9);
            title.Name = "title";
            title.Size = new Size(265, 25);
            title.TabIndex = 2;
            title.Text = "Whcih action you would choose";
            // 
            // FunctionActionChoose
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 191);
            Controls.Add(title);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FunctionActionChoose";
            Text = "FunctionActionChoose";
            Load += FunctionActionChoose_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label title;
        private Button button3;
        private Button button4;
    }
}