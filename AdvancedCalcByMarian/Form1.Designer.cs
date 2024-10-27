namespace AdvancedCalcByMarian
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            DarkThemeSwitch = new CheckBox();
            ClearEverythingButton = new Button();
            BackspaceButton = new Button();
            PercenteButton = new Button();
            DivideButton = new Button();
            NineNumberButton = new Button();
            EightNumberButton = new Button();
            SevenNumberButton = new Button();
            MultiplyButton = new Button();
            SubtractButton = new Button();
            SixNumberButton = new Button();
            FiveNumberButton = new Button();
            FourNumberButton = new Button();
            AddButton = new Button();
            ThreeNumberButton = new Button();
            TwoNumberButton = new Button();
            OneNumberButton = new Button();
            ClosingBracketButton = new Button();
            OpeningBracketButton = new Button();
            PointButton = new Button();
            ZeroNumberButton = new Button();
            AnsButton = new Button();
            ExponentButton = new Button();
            FactorialButton = new Button();
            SqrtButton = new Button();
            TanhButton = new Button();
            TanButton = new Button();
            ModButton = new Button();
            CoshButton = new Button();
            CosButton = new Button();
            LogButton = new Button();
            SinhButton = new Button();
            SinButton = new Button();
            TenMultipliedByXTime = new Button();
            MultiplyByItselfForYTimesButton = new Button();
            SquareButton = new Button();
            EqualButton = new Button();
            MCButton = new Button();
            MRButton = new Button();
            MemoryMinusButton = new Button();
            MemoryPlusButton = new Button();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            ScientificModeButton = new Button();
            CalculusModeButton = new Button();
            ProgrammerModeButton = new Button();
            DateModeButton = new Button();
            ConverterGroupBox = new GroupBox();
            PressureConvertButton = new Button();
            MassConvertButton = new Button();
            SpeedConvertButton = new Button();
            AngleConvertButton = new Button();
            TimeConvertButton = new Button();
            VolumeConvertButton = new Button();
            AreaConvertButton = new Button();
            LengthConvertButton = new Button();
            groupBox1 = new GroupBox();
            FunctionButton = new Button();
            IntegralButton = new Button();
            XButton = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ConverterGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(318, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 227);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(19, 183);
            label2.Name = "label2";
            label2.Size = new Size(1118, 38);
            label2.TabIndex = 44;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(19, 55);
            label1.Name = "label1";
            label1.Size = new Size(1118, 128);
            label1.TabIndex = 43;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DarkThemeSwitch
            // 
            DarkThemeSwitch.AutoSize = true;
            DarkThemeSwitch.Location = new Point(3, 36);
            DarkThemeSwitch.Name = "DarkThemeSwitch";
            DarkThemeSwitch.Size = new Size(128, 29);
            DarkThemeSwitch.TabIndex = 0;
            DarkThemeSwitch.Text = "DarkTheme";
            DarkThemeSwitch.UseVisualStyleBackColor = true;
            DarkThemeSwitch.CheckedChanged += DarkThemeSwitch_CheckedChanged;
            // 
            // ClearEverythingButton
            // 
            ClearEverythingButton.BackColor = Color.FromArgb(204, 62, 69);
            ClearEverythingButton.FlatStyle = FlatStyle.Flat;
            ClearEverythingButton.ForeColor = Color.White;
            ClearEverythingButton.Location = new Point(321, 325);
            ClearEverythingButton.Name = "ClearEverythingButton";
            ClearEverythingButton.Size = new Size(123, 83);
            ClearEverythingButton.TabIndex = 2;
            ClearEverythingButton.Text = "AC";
            ClearEverythingButton.UseVisualStyleBackColor = false;
            ClearEverythingButton.Click += ClearEverythingButton_Click;
            // 
            // BackspaceButton
            // 
            BackspaceButton.BackColor = Color.White;
            BackspaceButton.FlatStyle = FlatStyle.Flat;
            BackspaceButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackspaceButton.ForeColor = Color.Black;
            BackspaceButton.Location = new Point(450, 325);
            BackspaceButton.Name = "BackspaceButton";
            BackspaceButton.Size = new Size(123, 83);
            BackspaceButton.TabIndex = 3;
            BackspaceButton.Text = "⌫";
            BackspaceButton.UseVisualStyleBackColor = false;
            BackspaceButton.Click += BackspaceButton_Click;
            // 
            // PercenteButton
            // 
            PercenteButton.BackColor = Color.White;
            PercenteButton.FlatStyle = FlatStyle.Flat;
            PercenteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PercenteButton.ForeColor = Color.Black;
            PercenteButton.Location = new Point(579, 325);
            PercenteButton.Name = "PercenteButton";
            PercenteButton.Size = new Size(123, 83);
            PercenteButton.TabIndex = 4;
            PercenteButton.Text = "%";
            PercenteButton.UseVisualStyleBackColor = false;
            PercenteButton.Click += PercenteButton_Click;
            // 
            // DivideButton
            // 
            DivideButton.BackColor = Color.White;
            DivideButton.FlatStyle = FlatStyle.Flat;
            DivideButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DivideButton.ForeColor = Color.Black;
            DivideButton.Location = new Point(708, 325);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(123, 83);
            DivideButton.TabIndex = 5;
            DivideButton.Text = "/";
            DivideButton.UseVisualStyleBackColor = false;
            DivideButton.Click += DivideButton_Click;
            // 
            // NineNumberButton
            // 
            NineNumberButton.BackColor = Color.White;
            NineNumberButton.FlatStyle = FlatStyle.Flat;
            NineNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NineNumberButton.ForeColor = Color.Black;
            NineNumberButton.Location = new Point(579, 414);
            NineNumberButton.Name = "NineNumberButton";
            NineNumberButton.Size = new Size(123, 83);
            NineNumberButton.TabIndex = 8;
            NineNumberButton.Text = "9";
            NineNumberButton.UseVisualStyleBackColor = false;
            NineNumberButton.Click += NineNumberButton_Click;
            // 
            // EightNumberButton
            // 
            EightNumberButton.BackColor = Color.White;
            EightNumberButton.FlatStyle = FlatStyle.Flat;
            EightNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EightNumberButton.ForeColor = Color.Black;
            EightNumberButton.Location = new Point(450, 414);
            EightNumberButton.Name = "EightNumberButton";
            EightNumberButton.Size = new Size(123, 83);
            EightNumberButton.TabIndex = 7;
            EightNumberButton.Text = "8";
            EightNumberButton.UseVisualStyleBackColor = false;
            EightNumberButton.Click += EightNumberButton_Click;
            // 
            // SevenNumberButton
            // 
            SevenNumberButton.BackColor = Color.White;
            SevenNumberButton.FlatStyle = FlatStyle.Flat;
            SevenNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SevenNumberButton.ForeColor = Color.Black;
            SevenNumberButton.Location = new Point(321, 414);
            SevenNumberButton.Name = "SevenNumberButton";
            SevenNumberButton.Size = new Size(123, 83);
            SevenNumberButton.TabIndex = 6;
            SevenNumberButton.Text = "7";
            SevenNumberButton.UseVisualStyleBackColor = false;
            SevenNumberButton.Click += SevenNumberButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.BackColor = Color.White;
            MultiplyButton.FlatStyle = FlatStyle.Flat;
            MultiplyButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MultiplyButton.ForeColor = Color.Black;
            MultiplyButton.Location = new Point(708, 414);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(123, 83);
            MultiplyButton.TabIndex = 9;
            MultiplyButton.Text = "*";
            MultiplyButton.UseVisualStyleBackColor = false;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // SubtractButton
            // 
            SubtractButton.BackColor = Color.White;
            SubtractButton.FlatStyle = FlatStyle.Flat;
            SubtractButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubtractButton.ForeColor = Color.Black;
            SubtractButton.Location = new Point(708, 503);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(123, 83);
            SubtractButton.TabIndex = 13;
            SubtractButton.Text = "-";
            SubtractButton.UseVisualStyleBackColor = false;
            SubtractButton.Click += SubtractButton_Click;
            // 
            // SixNumberButton
            // 
            SixNumberButton.BackColor = Color.White;
            SixNumberButton.FlatStyle = FlatStyle.Flat;
            SixNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SixNumberButton.ForeColor = Color.Black;
            SixNumberButton.Location = new Point(579, 503);
            SixNumberButton.Name = "SixNumberButton";
            SixNumberButton.Size = new Size(123, 83);
            SixNumberButton.TabIndex = 12;
            SixNumberButton.Text = "6";
            SixNumberButton.UseVisualStyleBackColor = false;
            SixNumberButton.Click += SixNumberButton_Click;
            // 
            // FiveNumberButton
            // 
            FiveNumberButton.BackColor = Color.White;
            FiveNumberButton.FlatStyle = FlatStyle.Flat;
            FiveNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FiveNumberButton.ForeColor = Color.Black;
            FiveNumberButton.Location = new Point(450, 503);
            FiveNumberButton.Name = "FiveNumberButton";
            FiveNumberButton.Size = new Size(123, 83);
            FiveNumberButton.TabIndex = 11;
            FiveNumberButton.Text = "5";
            FiveNumberButton.UseVisualStyleBackColor = false;
            FiveNumberButton.Click += FiveNumberButton_Click;
            // 
            // FourNumberButton
            // 
            FourNumberButton.BackColor = Color.White;
            FourNumberButton.FlatStyle = FlatStyle.Flat;
            FourNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FourNumberButton.ForeColor = Color.Black;
            FourNumberButton.Location = new Point(321, 503);
            FourNumberButton.Name = "FourNumberButton";
            FourNumberButton.Size = new Size(123, 83);
            FourNumberButton.TabIndex = 10;
            FourNumberButton.Text = "4";
            FourNumberButton.UseVisualStyleBackColor = false;
            FourNumberButton.Click += FourNumberButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.White;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.Black;
            AddButton.Location = new Point(708, 592);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(123, 83);
            AddButton.TabIndex = 17;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // ThreeNumberButton
            // 
            ThreeNumberButton.BackColor = Color.White;
            ThreeNumberButton.FlatStyle = FlatStyle.Flat;
            ThreeNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThreeNumberButton.ForeColor = Color.Black;
            ThreeNumberButton.Location = new Point(579, 592);
            ThreeNumberButton.Name = "ThreeNumberButton";
            ThreeNumberButton.Size = new Size(123, 83);
            ThreeNumberButton.TabIndex = 16;
            ThreeNumberButton.Text = "3";
            ThreeNumberButton.UseVisualStyleBackColor = false;
            ThreeNumberButton.Click += ThreeNumberButton_Click;
            // 
            // TwoNumberButton
            // 
            TwoNumberButton.BackColor = Color.White;
            TwoNumberButton.FlatStyle = FlatStyle.Flat;
            TwoNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TwoNumberButton.ForeColor = Color.Black;
            TwoNumberButton.Location = new Point(450, 592);
            TwoNumberButton.Name = "TwoNumberButton";
            TwoNumberButton.Size = new Size(123, 83);
            TwoNumberButton.TabIndex = 15;
            TwoNumberButton.Text = "2";
            TwoNumberButton.UseVisualStyleBackColor = false;
            TwoNumberButton.Click += TwoNumberButton_Click;
            // 
            // OneNumberButton
            // 
            OneNumberButton.BackColor = Color.White;
            OneNumberButton.FlatStyle = FlatStyle.Flat;
            OneNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OneNumberButton.ForeColor = Color.Black;
            OneNumberButton.Location = new Point(321, 592);
            OneNumberButton.Name = "OneNumberButton";
            OneNumberButton.Size = new Size(123, 83);
            OneNumberButton.TabIndex = 14;
            OneNumberButton.Text = "1";
            OneNumberButton.UseVisualStyleBackColor = false;
            OneNumberButton.Click += OneNumberButton_Click;
            // 
            // ClosingBracketButton
            // 
            ClosingBracketButton.BackColor = Color.White;
            ClosingBracketButton.FlatStyle = FlatStyle.Flat;
            ClosingBracketButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClosingBracketButton.ForeColor = Color.Black;
            ClosingBracketButton.Location = new Point(708, 681);
            ClosingBracketButton.Name = "ClosingBracketButton";
            ClosingBracketButton.Size = new Size(123, 83);
            ClosingBracketButton.TabIndex = 21;
            ClosingBracketButton.Text = ")";
            ClosingBracketButton.UseVisualStyleBackColor = false;
            ClosingBracketButton.Click += ClosingBracketButton_Click;
            // 
            // OpeningBracketButton
            // 
            OpeningBracketButton.BackColor = Color.White;
            OpeningBracketButton.FlatStyle = FlatStyle.Flat;
            OpeningBracketButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpeningBracketButton.ForeColor = Color.Black;
            OpeningBracketButton.Location = new Point(579, 681);
            OpeningBracketButton.Name = "OpeningBracketButton";
            OpeningBracketButton.Size = new Size(123, 83);
            OpeningBracketButton.TabIndex = 20;
            OpeningBracketButton.Text = "(";
            OpeningBracketButton.UseVisualStyleBackColor = false;
            OpeningBracketButton.Click += OpeningBracketButton_Click;
            // 
            // PointButton
            // 
            PointButton.BackColor = Color.White;
            PointButton.FlatStyle = FlatStyle.Flat;
            PointButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PointButton.ForeColor = Color.Black;
            PointButton.Location = new Point(450, 681);
            PointButton.Name = "PointButton";
            PointButton.Size = new Size(123, 83);
            PointButton.TabIndex = 19;
            PointButton.Text = ".";
            PointButton.UseVisualStyleBackColor = false;
            PointButton.Click += PointButton_Click;
            // 
            // ZeroNumberButton
            // 
            ZeroNumberButton.BackColor = Color.White;
            ZeroNumberButton.FlatStyle = FlatStyle.Flat;
            ZeroNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZeroNumberButton.ForeColor = Color.Black;
            ZeroNumberButton.Location = new Point(321, 681);
            ZeroNumberButton.Name = "ZeroNumberButton";
            ZeroNumberButton.Size = new Size(123, 83);
            ZeroNumberButton.TabIndex = 18;
            ZeroNumberButton.Text = "0";
            ZeroNumberButton.UseVisualStyleBackColor = false;
            ZeroNumberButton.Click += ZeroNumberButton_Click;
            // 
            // AnsButton
            // 
            AnsButton.BackColor = Color.FromArgb(169, 178, 187);
            AnsButton.FlatStyle = FlatStyle.Flat;
            AnsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnsButton.ForeColor = Color.Black;
            AnsButton.Location = new Point(1180, 679);
            AnsButton.Name = "AnsButton";
            AnsButton.Size = new Size(123, 83);
            AnsButton.TabIndex = 36;
            AnsButton.Text = "Ans";
            AnsButton.UseVisualStyleBackColor = false;
            AnsButton.Click += AnsButton_Click;
            // 
            // ExponentButton
            // 
            ExponentButton.BackColor = Color.FromArgb(169, 178, 187);
            ExponentButton.FlatStyle = FlatStyle.Flat;
            ExponentButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExponentButton.ForeColor = Color.Black;
            ExponentButton.Location = new Point(1051, 679);
            ExponentButton.Name = "ExponentButton";
            ExponentButton.Size = new Size(123, 83);
            ExponentButton.TabIndex = 35;
            ExponentButton.Text = "e";
            ExponentButton.UseVisualStyleBackColor = false;
            ExponentButton.Click += ExponentButton_Click;
            // 
            // FactorialButton
            // 
            FactorialButton.BackColor = Color.FromArgb(169, 178, 187);
            FactorialButton.FlatStyle = FlatStyle.Flat;
            FactorialButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FactorialButton.ForeColor = Color.Black;
            FactorialButton.Location = new Point(922, 679);
            FactorialButton.Name = "FactorialButton";
            FactorialButton.Size = new Size(123, 83);
            FactorialButton.TabIndex = 34;
            FactorialButton.Text = "!";
            FactorialButton.UseVisualStyleBackColor = false;
            FactorialButton.Click += FactorialButton_Click;
            // 
            // SqrtButton
            // 
            SqrtButton.BackColor = Color.FromArgb(169, 178, 187);
            SqrtButton.FlatStyle = FlatStyle.Flat;
            SqrtButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SqrtButton.ForeColor = Color.Black;
            SqrtButton.Location = new Point(1180, 590);
            SqrtButton.Name = "SqrtButton";
            SqrtButton.Size = new Size(123, 83);
            SqrtButton.TabIndex = 33;
            SqrtButton.Text = "sqrt(x)";
            SqrtButton.UseVisualStyleBackColor = false;
            SqrtButton.Click += SqrtButton_Click;
            // 
            // TanhButton
            // 
            TanhButton.BackColor = Color.FromArgb(169, 178, 187);
            TanhButton.FlatStyle = FlatStyle.Flat;
            TanhButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TanhButton.ForeColor = Color.Black;
            TanhButton.Location = new Point(1051, 590);
            TanhButton.Name = "TanhButton";
            TanhButton.Size = new Size(123, 83);
            TanhButton.TabIndex = 32;
            TanhButton.Text = "tanh";
            TanhButton.UseVisualStyleBackColor = false;
            TanhButton.Click += TanhButton_Click;
            // 
            // TanButton
            // 
            TanButton.BackColor = Color.FromArgb(169, 178, 187);
            TanButton.FlatStyle = FlatStyle.Flat;
            TanButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TanButton.ForeColor = Color.Black;
            TanButton.Location = new Point(922, 590);
            TanButton.Name = "TanButton";
            TanButton.Size = new Size(123, 83);
            TanButton.TabIndex = 31;
            TanButton.Text = "tan";
            TanButton.UseVisualStyleBackColor = false;
            TanButton.Click += TanButton_Click;
            // 
            // ModButton
            // 
            ModButton.BackColor = Color.FromArgb(169, 178, 187);
            ModButton.FlatStyle = FlatStyle.Flat;
            ModButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModButton.ForeColor = Color.Black;
            ModButton.Location = new Point(1180, 501);
            ModButton.Name = "ModButton";
            ModButton.Size = new Size(123, 83);
            ModButton.TabIndex = 30;
            ModButton.Text = "Mod";
            ModButton.UseVisualStyleBackColor = false;
            // 
            // CoshButton
            // 
            CoshButton.BackColor = Color.FromArgb(169, 178, 187);
            CoshButton.FlatStyle = FlatStyle.Flat;
            CoshButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CoshButton.ForeColor = Color.Black;
            CoshButton.Location = new Point(1051, 501);
            CoshButton.Name = "CoshButton";
            CoshButton.Size = new Size(123, 83);
            CoshButton.TabIndex = 29;
            CoshButton.Text = "cosh";
            CoshButton.UseVisualStyleBackColor = false;
            CoshButton.Click += CoshButton_Click;
            // 
            // CosButton
            // 
            CosButton.BackColor = Color.FromArgb(169, 178, 187);
            CosButton.FlatStyle = FlatStyle.Flat;
            CosButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CosButton.ForeColor = Color.Black;
            CosButton.Location = new Point(922, 501);
            CosButton.Name = "CosButton";
            CosButton.Size = new Size(123, 83);
            CosButton.TabIndex = 28;
            CosButton.Text = "cos";
            CosButton.UseVisualStyleBackColor = false;
            CosButton.Click += CosButton_Click;
            // 
            // LogButton
            // 
            LogButton.BackColor = Color.FromArgb(169, 178, 187);
            LogButton.FlatStyle = FlatStyle.Flat;
            LogButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogButton.ForeColor = Color.Black;
            LogButton.Location = new Point(1180, 412);
            LogButton.Name = "LogButton";
            LogButton.Size = new Size(123, 83);
            LogButton.TabIndex = 27;
            LogButton.Text = "log x";
            LogButton.UseVisualStyleBackColor = false;
            LogButton.Click += LogButton_Click;
            // 
            // SinhButton
            // 
            SinhButton.BackColor = Color.FromArgb(169, 178, 187);
            SinhButton.FlatStyle = FlatStyle.Flat;
            SinhButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SinhButton.ForeColor = Color.Black;
            SinhButton.Location = new Point(1051, 412);
            SinhButton.Name = "SinhButton";
            SinhButton.Size = new Size(123, 83);
            SinhButton.TabIndex = 26;
            SinhButton.Text = "sinh";
            SinhButton.UseVisualStyleBackColor = false;
            SinhButton.Click += SinhButton_Click;
            // 
            // SinButton
            // 
            SinButton.BackColor = Color.FromArgb(169, 178, 187);
            SinButton.FlatStyle = FlatStyle.Flat;
            SinButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SinButton.ForeColor = Color.Black;
            SinButton.Location = new Point(922, 412);
            SinButton.Name = "SinButton";
            SinButton.Size = new Size(123, 83);
            SinButton.TabIndex = 25;
            SinButton.Text = "sin";
            SinButton.UseVisualStyleBackColor = false;
            SinButton.Click += SinButton_Click;
            // 
            // TenMultipliedByXTime
            // 
            TenMultipliedByXTime.BackColor = Color.FromArgb(169, 178, 187);
            TenMultipliedByXTime.FlatStyle = FlatStyle.Flat;
            TenMultipliedByXTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenMultipliedByXTime.ForeColor = Color.Black;
            TenMultipliedByXTime.Location = new Point(1180, 323);
            TenMultipliedByXTime.Name = "TenMultipliedByXTime";
            TenMultipliedByXTime.Size = new Size(123, 83);
            TenMultipliedByXTime.TabIndex = 24;
            TenMultipliedByXTime.Text = "10^x";
            TenMultipliedByXTime.UseVisualStyleBackColor = false;
            TenMultipliedByXTime.Click += TenMultipliedByXTime_Click;
            // 
            // MultiplyByItselfForYTimesButton
            // 
            MultiplyByItselfForYTimesButton.BackColor = Color.FromArgb(169, 178, 187);
            MultiplyByItselfForYTimesButton.FlatStyle = FlatStyle.Flat;
            MultiplyByItselfForYTimesButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MultiplyByItselfForYTimesButton.ForeColor = Color.Black;
            MultiplyByItselfForYTimesButton.Location = new Point(1051, 323);
            MultiplyByItselfForYTimesButton.Name = "MultiplyByItselfForYTimesButton";
            MultiplyByItselfForYTimesButton.Size = new Size(123, 83);
            MultiplyByItselfForYTimesButton.TabIndex = 23;
            MultiplyByItselfForYTimesButton.Text = "x^y";
            MultiplyByItselfForYTimesButton.UseVisualStyleBackColor = false;
            MultiplyByItselfForYTimesButton.Click += MultiplyByItselfForYTimesButton_Click;
            // 
            // SquareButton
            // 
            SquareButton.BackColor = Color.FromArgb(169, 178, 187);
            SquareButton.FlatStyle = FlatStyle.Flat;
            SquareButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SquareButton.ForeColor = Color.Black;
            SquareButton.Location = new Point(922, 323);
            SquareButton.Name = "SquareButton";
            SquareButton.Size = new Size(123, 83);
            SquareButton.TabIndex = 22;
            SquareButton.Text = "x^2";
            SquareButton.UseVisualStyleBackColor = false;
            SquareButton.Click += SquareButton_Click;
            // 
            // EqualButton
            // 
            EqualButton.BackColor = Color.FromArgb(54, 98, 140);
            EqualButton.FlatStyle = FlatStyle.Flat;
            EqualButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EqualButton.ForeColor = Color.White;
            EqualButton.Location = new Point(1309, 679);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(167, 83);
            EqualButton.TabIndex = 41;
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = false;
            EqualButton.Click += EqualButton_Click;
            // 
            // MCButton
            // 
            MCButton.BackColor = Color.FromArgb(252, 211, 86);
            MCButton.FlatStyle = FlatStyle.Flat;
            MCButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MCButton.ForeColor = Color.Black;
            MCButton.Location = new Point(1309, 590);
            MCButton.Name = "MCButton";
            MCButton.Size = new Size(167, 83);
            MCButton.TabIndex = 40;
            MCButton.Text = "MC";
            MCButton.UseVisualStyleBackColor = false;
            MCButton.Click += MCButton_Click;
            // 
            // MRButton
            // 
            MRButton.BackColor = Color.FromArgb(252, 211, 86);
            MRButton.FlatStyle = FlatStyle.Flat;
            MRButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MRButton.ForeColor = Color.Black;
            MRButton.Location = new Point(1309, 501);
            MRButton.Name = "MRButton";
            MRButton.Size = new Size(167, 83);
            MRButton.TabIndex = 39;
            MRButton.Text = "MR";
            MRButton.UseVisualStyleBackColor = false;
            MRButton.Click += MRButton_Click;
            // 
            // MemoryMinusButton
            // 
            MemoryMinusButton.BackColor = Color.FromArgb(252, 211, 86);
            MemoryMinusButton.FlatStyle = FlatStyle.Flat;
            MemoryMinusButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MemoryMinusButton.ForeColor = Color.Black;
            MemoryMinusButton.Location = new Point(1309, 412);
            MemoryMinusButton.Name = "MemoryMinusButton";
            MemoryMinusButton.Size = new Size(167, 83);
            MemoryMinusButton.TabIndex = 38;
            MemoryMinusButton.Text = "M-";
            MemoryMinusButton.UseVisualStyleBackColor = false;
            MemoryMinusButton.Click += MemoryMinusButton_Click;
            // 
            // MemoryPlusButton
            // 
            MemoryPlusButton.BackColor = Color.FromArgb(252, 211, 86);
            MemoryPlusButton.FlatStyle = FlatStyle.Flat;
            MemoryPlusButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MemoryPlusButton.ForeColor = Color.Black;
            MemoryPlusButton.Location = new Point(1309, 323);
            MemoryPlusButton.Name = "MemoryPlusButton";
            MemoryPlusButton.Size = new Size(167, 83);
            MemoryPlusButton.TabIndex = 37;
            MemoryPlusButton.Text = "M+";
            MemoryPlusButton.UseVisualStyleBackColor = false;
            MemoryPlusButton.Click += MemoryPlusButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, aboutToolStripMenuItem, historyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1491, 33);
            menuStrip1.TabIndex = 42;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(92, 29);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(85, 29);
            historyToolStripMenuItem.Text = "History";
            historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
            // 
            // ScientificModeButton
            // 
            ScientificModeButton.BackColor = Color.Gainsboro;
            ScientificModeButton.FlatAppearance.BorderColor = Color.Gainsboro;
            ScientificModeButton.FlatStyle = FlatStyle.Flat;
            ScientificModeButton.Font = new Font("Segoe UI", 9F);
            ScientificModeButton.ForeColor = SystemColors.ActiveCaptionText;
            ScientificModeButton.Location = new Point(0, 28);
            ScientificModeButton.Name = "ScientificModeButton";
            ScientificModeButton.Size = new Size(300, 34);
            ScientificModeButton.TabIndex = 0;
            ScientificModeButton.Text = "Scientific";
            ScientificModeButton.UseVisualStyleBackColor = false;
            ScientificModeButton.Click += ScientificModeButton_Click;
            // 
            // CalculusModeButton
            // 
            CalculusModeButton.BackColor = Color.Gainsboro;
            CalculusModeButton.FlatAppearance.BorderColor = Color.Gainsboro;
            CalculusModeButton.FlatStyle = FlatStyle.Flat;
            CalculusModeButton.Font = new Font("Segoe UI", 9F);
            CalculusModeButton.ForeColor = SystemColors.ActiveCaptionText;
            CalculusModeButton.Location = new Point(0, 68);
            CalculusModeButton.Name = "CalculusModeButton";
            CalculusModeButton.Size = new Size(300, 34);
            CalculusModeButton.TabIndex = 1;
            CalculusModeButton.Text = "Calculus";
            CalculusModeButton.UseVisualStyleBackColor = false;
            CalculusModeButton.Click += CalculusModeButton_Click;
            // 
            // ProgrammerModeButton
            // 
            ProgrammerModeButton.BackColor = Color.Gainsboro;
            ProgrammerModeButton.FlatAppearance.BorderColor = Color.Gainsboro;
            ProgrammerModeButton.FlatStyle = FlatStyle.Flat;
            ProgrammerModeButton.Font = new Font("Segoe UI", 9F);
            ProgrammerModeButton.ForeColor = SystemColors.ActiveCaptionText;
            ProgrammerModeButton.Location = new Point(0, 108);
            ProgrammerModeButton.Name = "ProgrammerModeButton";
            ProgrammerModeButton.Size = new Size(300, 34);
            ProgrammerModeButton.TabIndex = 2;
            ProgrammerModeButton.Text = "Programming";
            ProgrammerModeButton.UseVisualStyleBackColor = false;
            // 
            // DateModeButton
            // 
            DateModeButton.BackColor = Color.Gainsboro;
            DateModeButton.FlatAppearance.BorderColor = Color.Gainsboro;
            DateModeButton.FlatStyle = FlatStyle.Flat;
            DateModeButton.Font = new Font("Segoe UI", 9F);
            DateModeButton.ForeColor = SystemColors.ActiveCaptionText;
            DateModeButton.Location = new Point(0, 148);
            DateModeButton.Name = "DateModeButton";
            DateModeButton.Size = new Size(300, 34);
            DateModeButton.TabIndex = 3;
            DateModeButton.Text = "Date";
            DateModeButton.UseVisualStyleBackColor = false;
            // 
            // ConverterGroupBox
            // 
            ConverterGroupBox.BackColor = Color.Gainsboro;
            ConverterGroupBox.Controls.Add(PressureConvertButton);
            ConverterGroupBox.Controls.Add(MassConvertButton);
            ConverterGroupBox.Controls.Add(SpeedConvertButton);
            ConverterGroupBox.Controls.Add(AngleConvertButton);
            ConverterGroupBox.Controls.Add(TimeConvertButton);
            ConverterGroupBox.Controls.Add(VolumeConvertButton);
            ConverterGroupBox.Controls.Add(AreaConvertButton);
            ConverterGroupBox.Controls.Add(LengthConvertButton);
            ConverterGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConverterGroupBox.Location = new Point(0, 188);
            ConverterGroupBox.Name = "ConverterGroupBox";
            ConverterGroupBox.Size = new Size(300, 528);
            ConverterGroupBox.TabIndex = 4;
            ConverterGroupBox.TabStop = false;
            ConverterGroupBox.Text = "Converter";
            // 
            // PressureConvertButton
            // 
            PressureConvertButton.BackColor = Color.Gainsboro;
            PressureConvertButton.FlatAppearance.BorderColor = Color.Gainsboro;
            PressureConvertButton.FlatStyle = FlatStyle.Flat;
            PressureConvertButton.Font = new Font("Segoe UI", 9F);
            PressureConvertButton.ForeColor = SystemColors.ActiveCaptionText;
            PressureConvertButton.Location = new Point(0, 310);
            PressureConvertButton.Name = "PressureConvertButton";
            PressureConvertButton.Size = new Size(300, 34);
            PressureConvertButton.TabIndex = 12;
            PressureConvertButton.Text = "Pressure";
            PressureConvertButton.UseVisualStyleBackColor = false;
            // 
            // MassConvertButton
            // 
            MassConvertButton.BackColor = Color.Gainsboro;
            MassConvertButton.FlatAppearance.BorderColor = Color.Gainsboro;
            MassConvertButton.FlatStyle = FlatStyle.Flat;
            MassConvertButton.Font = new Font("Segoe UI", 9F);
            MassConvertButton.ForeColor = SystemColors.ActiveCaptionText;
            MassConvertButton.Location = new Point(0, 270);
            MassConvertButton.Name = "MassConvertButton";
            MassConvertButton.Size = new Size(300, 34);
            MassConvertButton.TabIndex = 11;
            MassConvertButton.Text = "Mass";
            MassConvertButton.UseVisualStyleBackColor = false;
            // 
            // SpeedConvertButton
            // 
            SpeedConvertButton.BackColor = Color.Gainsboro;
            SpeedConvertButton.FlatAppearance.BorderColor = Color.Gainsboro;
            SpeedConvertButton.FlatStyle = FlatStyle.Flat;
            SpeedConvertButton.Font = new Font("Segoe UI", 9F);
            SpeedConvertButton.ForeColor = SystemColors.ActiveCaptionText;
            SpeedConvertButton.Location = new Point(0, 230);
            SpeedConvertButton.Name = "SpeedConvertButton";
            SpeedConvertButton.Size = new Size(300, 34);
            SpeedConvertButton.TabIndex = 10;
            SpeedConvertButton.Text = "Speed";
            SpeedConvertButton.UseVisualStyleBackColor = false;
            // 
            // AngleConvertButton
            // 
            AngleConvertButton.BackColor = Color.Gainsboro;
            AngleConvertButton.FlatAppearance.BorderColor = Color.Gainsboro;
            AngleConvertButton.FlatStyle = FlatStyle.Flat;
            AngleConvertButton.Font = new Font("Segoe UI", 9F);
            AngleConvertButton.ForeColor = SystemColors.ActiveCaptionText;
            AngleConvertButton.Location = new Point(0, 190);
            AngleConvertButton.Name = "AngleConvertButton";
            AngleConvertButton.Size = new Size(300, 34);
            AngleConvertButton.TabIndex = 9;
            AngleConvertButton.Text = "Angle";
            AngleConvertButton.UseVisualStyleBackColor = false;
            // 
            // TimeConvertButton
            // 
            TimeConvertButton.BackColor = Color.Gainsboro;
            TimeConvertButton.FlatAppearance.BorderColor = Color.Gainsboro;
            TimeConvertButton.FlatStyle = FlatStyle.Flat;
            TimeConvertButton.Font = new Font("Segoe UI", 9F);
            TimeConvertButton.ForeColor = SystemColors.ActiveCaptionText;
            TimeConvertButton.Location = new Point(0, 150);
            TimeConvertButton.Name = "TimeConvertButton";
            TimeConvertButton.Size = new Size(300, 34);
            TimeConvertButton.TabIndex = 8;
            TimeConvertButton.Text = "Time";
            TimeConvertButton.UseVisualStyleBackColor = false;
            // 
            // VolumeConvertButton
            // 
            VolumeConvertButton.BackColor = Color.Gainsboro;
            VolumeConvertButton.FlatAppearance.BorderColor = Color.Gainsboro;
            VolumeConvertButton.FlatStyle = FlatStyle.Flat;
            VolumeConvertButton.Font = new Font("Segoe UI", 9F);
            VolumeConvertButton.ForeColor = SystemColors.ActiveCaptionText;
            VolumeConvertButton.Location = new Point(0, 110);
            VolumeConvertButton.Name = "VolumeConvertButton";
            VolumeConvertButton.Size = new Size(300, 34);
            VolumeConvertButton.TabIndex = 7;
            VolumeConvertButton.Text = "Volume";
            VolumeConvertButton.UseVisualStyleBackColor = false;
            // 
            // AreaConvertButton
            // 
            AreaConvertButton.BackColor = Color.Gainsboro;
            AreaConvertButton.FlatAppearance.BorderColor = Color.Gainsboro;
            AreaConvertButton.FlatStyle = FlatStyle.Flat;
            AreaConvertButton.Font = new Font("Segoe UI", 9F);
            AreaConvertButton.ForeColor = SystemColors.ActiveCaptionText;
            AreaConvertButton.Location = new Point(0, 70);
            AreaConvertButton.Name = "AreaConvertButton";
            AreaConvertButton.Size = new Size(300, 34);
            AreaConvertButton.TabIndex = 6;
            AreaConvertButton.Text = "Area";
            AreaConvertButton.UseVisualStyleBackColor = false;
            // 
            // LengthConvertButton
            // 
            LengthConvertButton.BackColor = Color.Gainsboro;
            LengthConvertButton.FlatAppearance.BorderColor = Color.Gainsboro;
            LengthConvertButton.FlatStyle = FlatStyle.Flat;
            LengthConvertButton.Font = new Font("Segoe UI", 9F);
            LengthConvertButton.ForeColor = SystemColors.ActiveCaptionText;
            LengthConvertButton.Location = new Point(0, 30);
            LengthConvertButton.Name = "LengthConvertButton";
            LengthConvertButton.Size = new Size(300, 34);
            LengthConvertButton.TabIndex = 5;
            LengthConvertButton.Text = "Length";
            LengthConvertButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(ConverterGroupBox);
            groupBox1.Controls.Add(ScientificModeButton);
            groupBox1.Controls.Add(DateModeButton);
            groupBox1.Controls.Add(CalculusModeButton);
            groupBox1.Controls.Add(ProgrammerModeButton);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 712);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculator";
            // 
            // FunctionButton
            // 
            FunctionButton.BackColor = Color.FromArgb(169, 178, 187);
            FunctionButton.FlatStyle = FlatStyle.Flat;
            FunctionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FunctionButton.ForeColor = Color.Black;
            FunctionButton.Location = new Point(922, 679);
            FunctionButton.Name = "FunctionButton";
            FunctionButton.Size = new Size(123, 83);
            FunctionButton.TabIndex = 44;
            FunctionButton.Text = "f(x)";
            FunctionButton.UseVisualStyleBackColor = false;
            FunctionButton.Click += FunctionButton_Click;
            // 
            // IntegralButton
            // 
            IntegralButton.BackColor = Color.FromArgb(169, 178, 187);
            IntegralButton.FlatStyle = FlatStyle.Flat;
            IntegralButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IntegralButton.ForeColor = Color.Black;
            IntegralButton.Location = new Point(1051, 679);
            IntegralButton.Name = "IntegralButton";
            IntegralButton.Size = new Size(123, 83);
            IntegralButton.TabIndex = 45;
            IntegralButton.Text = "∫";
            IntegralButton.UseVisualStyleBackColor = false;
            // 
            // XButton
            // 
            XButton.BackColor = Color.White;
            XButton.FlatStyle = FlatStyle.Flat;
            XButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            XButton.ForeColor = Color.Black;
            XButton.Location = new Point(579, 325);
            XButton.Name = "XButton";
            XButton.Size = new Size(123, 83);
            XButton.TabIndex = 46;
            XButton.Text = "x";
            XButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1491, 784);
            Controls.Add(XButton);
            Controls.Add(IntegralButton);
            Controls.Add(FunctionButton);
            Controls.Add(groupBox1);
            Controls.Add(EqualButton);
            Controls.Add(MCButton);
            Controls.Add(MRButton);
            Controls.Add(MemoryMinusButton);
            Controls.Add(MemoryPlusButton);
            Controls.Add(AnsButton);
            Controls.Add(ExponentButton);
            Controls.Add(FactorialButton);
            Controls.Add(SqrtButton);
            Controls.Add(TanhButton);
            Controls.Add(TanButton);
            Controls.Add(ModButton);
            Controls.Add(CoshButton);
            Controls.Add(CosButton);
            Controls.Add(LogButton);
            Controls.Add(SinhButton);
            Controls.Add(SinButton);
            Controls.Add(TenMultipliedByXTime);
            Controls.Add(MultiplyByItselfForYTimesButton);
            Controls.Add(SquareButton);
            Controls.Add(ClosingBracketButton);
            Controls.Add(OpeningBracketButton);
            Controls.Add(PointButton);
            Controls.Add(ZeroNumberButton);
            Controls.Add(AddButton);
            Controls.Add(ThreeNumberButton);
            Controls.Add(TwoNumberButton);
            Controls.Add(OneNumberButton);
            Controls.Add(SubtractButton);
            Controls.Add(SixNumberButton);
            Controls.Add(FiveNumberButton);
            Controls.Add(FourNumberButton);
            Controls.Add(MultiplyButton);
            Controls.Add(NineNumberButton);
            Controls.Add(EightNumberButton);
            Controls.Add(SevenNumberButton);
            Controls.Add(DivideButton);
            Controls.Add(PercenteButton);
            Controls.Add(BackspaceButton);
            Controls.Add(ClearEverythingButton);
            Controls.Add(DarkThemeSwitch);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "SINCOTAN";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ConverterGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private CheckBox DarkThemeSwitch;
        private Button ClearEverythingButton;
        private Button BackspaceButton;
        private Button PercenteButton;
        private Button DivideButton;
        private Button NineNumberButton;
        private Button EightNumberButton;
        private Button SevenNumberButton;
        private Button MultiplyButton;
        private Button SubtractButton;
        private Button SixNumberButton;
        private Button FiveNumberButton;
        private Button FourNumberButton;
        private Button AddButton;
        private Button ThreeNumberButton;
        private Button TwoNumberButton;
        private Button OneNumberButton;
        private Button ClosingBracketButton;
        private Button OpeningBracketButton;
        private Button PointButton;
        private Button ZeroNumberButton;
        private Button AnsButton;
        private Button ExponentButton;
        private Button FactorialButton;
        private Button SqrtButton;
        private Button TanhButton;
        private Button TanButton;
        private Button ModButton;
        private Button CoshButton;
        private Button CosButton;
        private Button LogButton;
        private Button SinhButton;
        private Button SinButton;
        private Button TenMultipliedByXTime;
        private Button MultiplyByItselfForYTimesButton;
        private Button SquareButton;
        private Button EqualButton;
        private Button MCButton;
        private Button MRButton;
        private Button MemoryMinusButton;
        private Button MemoryPlusButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Button ScientificModeButton;
        private Button CalculusModeButton;
        private Button ProgrammerModeButton;
        private Button DateModeButton;
        private GroupBox ConverterGroupBox;
        private Button PressureConvertButton;
        private Button MassConvertButton;
        private Button SpeedConvertButton;
        private Button AngleConvertButton;
        private Button TimeConvertButton;
        private Button VolumeConvertButton;
        private Button AreaConvertButton;
        private Button LengthConvertButton;
        private GroupBox groupBox1;
        private ToolStripMenuItem historyToolStripMenuItem;
        private Button FunctionButton;
        private Button IntegralButton;
        private Button XButton;
    }
}
