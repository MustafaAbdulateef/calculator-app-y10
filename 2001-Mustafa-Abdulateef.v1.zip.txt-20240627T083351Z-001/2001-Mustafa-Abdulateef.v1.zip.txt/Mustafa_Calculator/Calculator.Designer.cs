
namespace Mustafa_Calculator
{
    partial class Calculator
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
            textBoxDisplay = new TextBox();
            tableLayoutPanel = new TableLayoutPanel();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonAdd = new Button();
            buttonMinus = new Button();
            buttonSquare = new Button();
            buttonSquareRoot = new Button();
            buttonPowerofY = new Button();
            buttonInverseSin = new Button();
            buttonTan = new Button();
            buttonSin = new Button();
            buttonInverseTan = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonPlusorMinus = new Button();
            buttonZero = new Button();
            buttonDecimal = new Button();
            buttonInverseCos = new Button();
            buttonCos = new Button();
            buttonEquals = new Button();
            buttonPi = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.BackColor = SystemColors.Window;
            textBoxDisplay.BorderStyle = BorderStyle.None;
            tableLayoutPanel.SetColumnSpan(textBoxDisplay, 5);
            textBoxDisplay.Dock = DockStyle.Fill;
            textBoxDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDisplay.ForeColor = Color.Black;
            textBoxDisplay.Location = new Point(3, 3);
            textBoxDisplay.Multiline = true;
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.RightToLeft = RightToLeft.No;
            tableLayoutPanel.SetRowSpan(textBoxDisplay, 2);
            textBoxDisplay.Size = new Size(298, 118);
            textBoxDisplay.TabIndex = 0;
            textBoxDisplay.TextAlign = HorizontalAlignment.Right;
            textBoxDisplay.TextChanged += textBoxDisplay_TextChanged;
            textBoxDisplay.KeyDown += textBoxDisplay_KeyDown;
            textBoxDisplay.KeyPress += textBoxDisplay_KeyPress;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.White;
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Controls.Add(textBoxDisplay, 0, 0);
            tableLayoutPanel.Controls.Add(buttonDelete, 4, 2);
            tableLayoutPanel.Controls.Add(buttonClear, 3, 2);
            tableLayoutPanel.Controls.Add(buttonMultiply, 3, 3);
            tableLayoutPanel.Controls.Add(buttonDivide, 4, 3);
            tableLayoutPanel.Controls.Add(buttonAdd, 3, 4);
            tableLayoutPanel.Controls.Add(buttonMinus, 4, 4);
            tableLayoutPanel.Controls.Add(buttonSquare, 3, 5);
            tableLayoutPanel.Controls.Add(buttonSquareRoot, 4, 5);
            tableLayoutPanel.Controls.Add(buttonPowerofY, 3, 6);
            tableLayoutPanel.Controls.Add(buttonInverseSin, 0, 2);
            tableLayoutPanel.Controls.Add(buttonTan, 2, 3);
            tableLayoutPanel.Controls.Add(buttonSin, 0, 3);
            tableLayoutPanel.Controls.Add(buttonInverseTan, 2, 2);
            tableLayoutPanel.Controls.Add(buttonSeven, 0, 4);
            tableLayoutPanel.Controls.Add(buttonEight, 1, 4);
            tableLayoutPanel.Controls.Add(buttonNine, 2, 4);
            tableLayoutPanel.Controls.Add(buttonFour, 0, 5);
            tableLayoutPanel.Controls.Add(buttonFive, 1, 5);
            tableLayoutPanel.Controls.Add(buttonSix, 2, 5);
            tableLayoutPanel.Controls.Add(buttonOne, 0, 6);
            tableLayoutPanel.Controls.Add(buttonTwo, 1, 6);
            tableLayoutPanel.Controls.Add(buttonThree, 2, 6);
            tableLayoutPanel.Controls.Add(buttonPlusorMinus, 0, 7);
            tableLayoutPanel.Controls.Add(buttonZero, 1, 7);
            tableLayoutPanel.Controls.Add(buttonDecimal, 2, 7);
            tableLayoutPanel.Controls.Add(buttonInverseCos, 1, 2);
            tableLayoutPanel.Controls.Add(buttonCos, 1, 3);
            tableLayoutPanel.Controls.Add(buttonEquals, 3, 7);
            tableLayoutPanel.Controls.Add(buttonPi, 4, 6);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 9;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(304, 496);
            tableLayoutPanel.TabIndex = 25;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(220, 53, 69);
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 18F);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(243, 127);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(58, 56);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "⌫";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(220, 53, 69);
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI", 18F);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(183, 127);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(54, 56);
            buttonClear.TabIndex = 24;
            buttonClear.Text = "CE";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = Color.FromArgb(0, 123, 255);
            buttonMultiply.Dock = DockStyle.Fill;
            buttonMultiply.FlatStyle = FlatStyle.Flat;
            buttonMultiply.Font = new Font("Segoe UI", 18F);
            buttonMultiply.ForeColor = Color.White;
            buttonMultiply.Location = new Point(183, 189);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(54, 56);
            buttonMultiply.TabIndex = 8;
            buttonMultiply.Text = "×";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = Color.FromArgb(0, 123, 255);
            buttonDivide.Dock = DockStyle.Fill;
            buttonDivide.FlatStyle = FlatStyle.Flat;
            buttonDivide.Font = new Font("Segoe UI", 18F);
            buttonDivide.ForeColor = Color.White;
            buttonDivide.Location = new Point(243, 189);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(58, 56);
            buttonDivide.TabIndex = 12;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(0, 123, 255);
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 18F);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(183, 251);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(54, 56);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.FromArgb(0, 123, 255);
            buttonMinus.Dock = DockStyle.Fill;
            buttonMinus.FlatStyle = FlatStyle.Flat;
            buttonMinus.Font = new Font("Segoe UI", 18F);
            buttonMinus.ForeColor = Color.White;
            buttonMinus.Location = new Point(243, 251);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(58, 56);
            buttonMinus.TabIndex = 26;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.BackColor = Color.FromArgb(40, 167, 69);
            buttonSquare.Dock = DockStyle.Fill;
            buttonSquare.FlatStyle = FlatStyle.Flat;
            buttonSquare.Font = new Font("Segoe UI", 18F);
            buttonSquare.ForeColor = Color.White;
            buttonSquare.Location = new Point(183, 313);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(54, 56);
            buttonSquare.TabIndex = 7;
            buttonSquare.Text = "𝒙²";
            buttonSquare.UseVisualStyleBackColor = false;
            buttonSquare.Click += buttonSquare_Click;
            // 
            // buttonSquareRoot
            // 
            buttonSquareRoot.BackColor = Color.FromArgb(40, 167, 69);
            buttonSquareRoot.Dock = DockStyle.Fill;
            buttonSquareRoot.FlatStyle = FlatStyle.Flat;
            buttonSquareRoot.Font = new Font("Segoe UI", 18F);
            buttonSquareRoot.ForeColor = Color.White;
            buttonSquareRoot.Location = new Point(243, 313);
            buttonSquareRoot.Name = "buttonSquareRoot";
            buttonSquareRoot.Size = new Size(58, 56);
            buttonSquareRoot.TabIndex = 3;
            buttonSquareRoot.Text = "√";
            buttonSquareRoot.UseVisualStyleBackColor = false;
            buttonSquareRoot.Click += buttonSquareRoot_Click;
            // 
            // buttonPowerofY
            // 
            buttonPowerofY.BackColor = Color.FromArgb(40, 167, 69);
            buttonPowerofY.Dock = DockStyle.Fill;
            buttonPowerofY.FlatStyle = FlatStyle.Flat;
            buttonPowerofY.Font = new Font("Segoe UI", 18F);
            buttonPowerofY.ForeColor = Color.White;
            buttonPowerofY.Location = new Point(183, 375);
            buttonPowerofY.Name = "buttonPowerofY";
            buttonPowerofY.Size = new Size(54, 56);
            buttonPowerofY.TabIndex = 21;
            buttonPowerofY.Text = "𝒙ʸ";
            buttonPowerofY.UseVisualStyleBackColor = false;
            buttonPowerofY.Click += buttonPowerofY_Click;
            // 
            // buttonInverseSin
            // 
            buttonInverseSin.BackColor = Color.FromArgb(40, 167, 69);
            buttonInverseSin.Dock = DockStyle.Fill;
            buttonInverseSin.FlatStyle = FlatStyle.Flat;
            buttonInverseSin.Font = new Font("Segoe UI", 11.25F);
            buttonInverseSin.ForeColor = Color.White;
            buttonInverseSin.Location = new Point(3, 127);
            buttonInverseSin.Name = "buttonInverseSin";
            buttonInverseSin.Size = new Size(54, 56);
            buttonInverseSin.TabIndex = 1;
            buttonInverseSin.Text = "Sin⁻¹";
            buttonInverseSin.UseVisualStyleBackColor = false;
            buttonInverseSin.Click += buttonInverseSin_Click;
            // 
            // buttonTan
            // 
            buttonTan.BackColor = Color.FromArgb(40, 167, 69);
            buttonTan.Dock = DockStyle.Fill;
            buttonTan.FlatStyle = FlatStyle.Flat;
            buttonTan.Font = new Font("Segoe UI", 11.25F);
            buttonTan.ForeColor = Color.White;
            buttonTan.Location = new Point(123, 189);
            buttonTan.Name = "buttonTan";
            buttonTan.Size = new Size(54, 56);
            buttonTan.TabIndex = 6;
            buttonTan.Text = "Tan";
            buttonTan.UseVisualStyleBackColor = false;
            buttonTan.Click += buttonTan_Click;
            // 
            // buttonSin
            // 
            buttonSin.BackColor = Color.FromArgb(40, 167, 69);
            buttonSin.Dock = DockStyle.Fill;
            buttonSin.FlatStyle = FlatStyle.Flat;
            buttonSin.Font = new Font("Segoe UI", 11.25F);
            buttonSin.ForeColor = Color.White;
            buttonSin.Location = new Point(3, 189);
            buttonSin.Name = "buttonSin";
            buttonSin.Size = new Size(54, 56);
            buttonSin.TabIndex = 5;
            buttonSin.Text = "Sin";
            buttonSin.UseVisualStyleBackColor = false;
            buttonSin.Click += buttonSin_Click;
            // 
            // buttonInverseTan
            // 
            buttonInverseTan.BackColor = Color.FromArgb(40, 167, 69);
            buttonInverseTan.Dock = DockStyle.Fill;
            buttonInverseTan.FlatStyle = FlatStyle.Flat;
            buttonInverseTan.Font = new Font("Segoe UI", 11.25F);
            buttonInverseTan.ForeColor = Color.White;
            buttonInverseTan.Location = new Point(123, 127);
            buttonInverseTan.Name = "buttonInverseTan";
            buttonInverseTan.Size = new Size(54, 56);
            buttonInverseTan.TabIndex = 2;
            buttonInverseTan.Text = "Tan⁻¹";
            buttonInverseTan.UseVisualStyleBackColor = false;
            buttonInverseTan.Click += buttonInverseTan_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.BackColor = SystemColors.ButtonFace;
            buttonSeven.Dock = DockStyle.Fill;
            buttonSeven.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonSeven.FlatStyle = FlatStyle.Flat;
            buttonSeven.Font = new Font("Segoe UI", 18F);
            buttonSeven.ForeColor = Color.FromArgb(74, 74, 74);
            buttonSeven.Location = new Point(3, 251);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(54, 56);
            buttonSeven.TabIndex = 17;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = false;
            buttonSeven.Click += buttonSeven_Click;
            // 
            // buttonEight
            // 
            buttonEight.BackColor = SystemColors.ButtonFace;
            buttonEight.Dock = DockStyle.Fill;
            buttonEight.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonEight.FlatStyle = FlatStyle.Flat;
            buttonEight.Font = new Font("Segoe UI", 18F);
            buttonEight.ForeColor = Color.FromArgb(74, 74, 74);
            buttonEight.Location = new Point(63, 251);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(54, 56);
            buttonEight.TabIndex = 18;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = false;
            buttonEight.Click += buttonEight_Click;
            // 
            // buttonNine
            // 
            buttonNine.BackColor = SystemColors.ButtonFace;
            buttonNine.Dock = DockStyle.Fill;
            buttonNine.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonNine.FlatStyle = FlatStyle.Flat;
            buttonNine.Font = new Font("Segoe UI", 18F);
            buttonNine.ForeColor = Color.FromArgb(74, 74, 74);
            buttonNine.Location = new Point(123, 251);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(54, 56);
            buttonNine.TabIndex = 19;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = false;
            buttonNine.Click += buttonNine_Click;
            // 
            // buttonFour
            // 
            buttonFour.BackColor = SystemColors.ButtonFace;
            buttonFour.Dock = DockStyle.Fill;
            buttonFour.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonFour.FlatStyle = FlatStyle.Flat;
            buttonFour.Font = new Font("Segoe UI", 18F);
            buttonFour.ForeColor = Color.FromArgb(74, 74, 74);
            buttonFour.Location = new Point(3, 313);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(54, 56);
            buttonFour.TabIndex = 13;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = false;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonFive
            // 
            buttonFive.BackColor = SystemColors.ButtonFace;
            buttonFive.Dock = DockStyle.Fill;
            buttonFive.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonFive.FlatStyle = FlatStyle.Flat;
            buttonFive.Font = new Font("Segoe UI", 18F);
            buttonFive.ForeColor = Color.FromArgb(74, 74, 74);
            buttonFive.Location = new Point(63, 313);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(54, 56);
            buttonFive.TabIndex = 14;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = false;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonSix
            // 
            buttonSix.BackColor = SystemColors.ButtonFace;
            buttonSix.Dock = DockStyle.Fill;
            buttonSix.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonSix.FlatStyle = FlatStyle.Flat;
            buttonSix.Font = new Font("Segoe UI", 18F);
            buttonSix.ForeColor = Color.FromArgb(74, 74, 74);
            buttonSix.Location = new Point(123, 313);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(54, 56);
            buttonSix.TabIndex = 15;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = false;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonOne
            // 
            buttonOne.BackColor = SystemColors.ButtonFace;
            buttonOne.Dock = DockStyle.Fill;
            buttonOne.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonOne.FlatStyle = FlatStyle.Flat;
            buttonOne.Font = new Font("Segoe UI", 18F);
            buttonOne.ForeColor = Color.FromArgb(74, 74, 74);
            buttonOne.Location = new Point(3, 375);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(54, 56);
            buttonOne.TabIndex = 9;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.BackColor = SystemColors.ButtonFace;
            buttonTwo.Dock = DockStyle.Fill;
            buttonTwo.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonTwo.FlatStyle = FlatStyle.Flat;
            buttonTwo.Font = new Font("Segoe UI", 18F);
            buttonTwo.ForeColor = Color.FromArgb(74, 74, 74);
            buttonTwo.Location = new Point(63, 375);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(54, 56);
            buttonTwo.TabIndex = 10;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = false;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonThree
            // 
            buttonThree.BackColor = SystemColors.ButtonFace;
            buttonThree.Dock = DockStyle.Fill;
            buttonThree.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonThree.FlatStyle = FlatStyle.Flat;
            buttonThree.Font = new Font("Segoe UI", 18F);
            buttonThree.ForeColor = Color.FromArgb(74, 74, 74);
            buttonThree.Location = new Point(123, 375);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(54, 56);
            buttonThree.TabIndex = 11;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = false;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonPlusorMinus
            // 
            buttonPlusorMinus.BackColor = SystemColors.ButtonFace;
            buttonPlusorMinus.Dock = DockStyle.Fill;
            buttonPlusorMinus.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonPlusorMinus.FlatStyle = FlatStyle.Flat;
            buttonPlusorMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPlusorMinus.ForeColor = Color.FromArgb(74, 74, 74);
            buttonPlusorMinus.Location = new Point(3, 437);
            buttonPlusorMinus.Name = "buttonPlusorMinus";
            buttonPlusorMinus.Size = new Size(54, 56);
            buttonPlusorMinus.TabIndex = 27;
            buttonPlusorMinus.Text = "+/-";
            buttonPlusorMinus.UseVisualStyleBackColor = false;
            buttonPlusorMinus.Click += buttonPlusorMinus_Click;
            // 
            // buttonZero
            // 
            buttonZero.BackColor = SystemColors.ButtonFace;
            buttonZero.Dock = DockStyle.Fill;
            buttonZero.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonZero.FlatStyle = FlatStyle.Flat;
            buttonZero.Font = new Font("Segoe UI", 18F);
            buttonZero.ForeColor = Color.FromArgb(74, 74, 74);
            buttonZero.Location = new Point(63, 437);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(54, 56);
            buttonZero.TabIndex = 28;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = false;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.BackColor = SystemColors.ButtonFace;
            buttonDecimal.Dock = DockStyle.Fill;
            buttonDecimal.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonDecimal.FlatStyle = FlatStyle.Flat;
            buttonDecimal.Font = new Font("Segoe UI", 18F);
            buttonDecimal.ForeColor = Color.FromArgb(74, 74, 74);
            buttonDecimal.Location = new Point(123, 437);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(54, 56);
            buttonDecimal.TabIndex = 29;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = false;
            buttonDecimal.Click += buttonDecimal_Click;
            // 
            // buttonInverseCos
            // 
            buttonInverseCos.BackColor = Color.FromArgb(40, 167, 69);
            buttonInverseCos.Dock = DockStyle.Fill;
            buttonInverseCos.FlatStyle = FlatStyle.Flat;
            buttonInverseCos.Font = new Font("Segoe UI", 11.25F);
            buttonInverseCos.ForeColor = Color.White;
            buttonInverseCos.Location = new Point(63, 127);
            buttonInverseCos.Name = "buttonInverseCos";
            buttonInverseCos.Size = new Size(54, 56);
            buttonInverseCos.TabIndex = 30;
            buttonInverseCos.Text = "Cos⁻¹";
            buttonInverseCos.UseVisualStyleBackColor = false;
            buttonInverseCos.Click += buttonInverseCos_Click;
            // 
            // buttonCos
            // 
            buttonCos.BackColor = Color.FromArgb(40, 167, 69);
            buttonCos.Dock = DockStyle.Fill;
            buttonCos.FlatStyle = FlatStyle.Flat;
            buttonCos.Font = new Font("Segoe UI", 11.25F);
            buttonCos.ForeColor = Color.White;
            buttonCos.Location = new Point(63, 189);
            buttonCos.Name = "buttonCos";
            buttonCos.Size = new Size(54, 56);
            buttonCos.TabIndex = 31;
            buttonCos.Text = "Cos";
            buttonCos.UseVisualStyleBackColor = false;
            buttonCos.Click += buttonCos_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.FromArgb(0, 90, 179);
            tableLayoutPanel.SetColumnSpan(buttonEquals, 2);
            buttonEquals.Dock = DockStyle.Fill;
            buttonEquals.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 110, 179);
            buttonEquals.FlatStyle = FlatStyle.Flat;
            buttonEquals.Font = new Font("Segoe UI", 18F);
            buttonEquals.ForeColor = Color.White;
            buttonEquals.Location = new Point(183, 437);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(118, 56);
            buttonEquals.TabIndex = 20;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonPi
            // 
            buttonPi.BackColor = Color.FromArgb(40, 167, 69);
            buttonPi.Dock = DockStyle.Fill;
            buttonPi.FlatStyle = FlatStyle.Flat;
            buttonPi.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPi.ForeColor = Color.White;
            buttonPi.Location = new Point(243, 375);
            buttonPi.Name = "buttonPi";
            buttonPi.Size = new Size(58, 56);
            buttonPi.TabIndex = 32;
            buttonPi.Text = "π";
            buttonPi.UseVisualStyleBackColor = false;
            buttonPi.Click += buttonPi_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(304, 496);
            Controls.Add(tableLayoutPanel);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(320, 535);
            Name = "Calculator";
            Text = "Calculator";
            KeyDown += Calculator_KeyDown;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            double degrees;
            if (double.TryParse(textBoxDisplay.Text, out degrees))
            {
                double radians = degrees * (Math.PI / 180);

                double tan = Math.Sin(radians);
                textBoxDisplay.Text = tan.ToString();
            }
        }

        private void buttonInverseTan_Click(object sender, EventArgs e)
        {
            double inverseT;
            if (double.TryParse(textBoxDisplay.Text, out inverseT))
            {
                inverseT = Math.Atan(inverseT);

                double degrees = inverseT * (180 / Math.PI);
                textBoxDisplay.Text = inverseT.ToString();
            }
        }
        private void buttonCos_Click(object sender, EventArgs e)
        {
            double degrees;
            if (double.TryParse(textBoxDisplay.Text, out degrees))
            {
                double radians = degrees * (Math.PI / 180);

                double cos = Math.Cos(radians);
                textBoxDisplay.Text = cos.ToString();
            }
        }

        private void buttonInverseCos_Click(object sender, EventArgs e)
        {
            double inverseC;
            if (double.TryParse(textBoxDisplay.Text, out inverseC))
            {
                inverseC = Math.Acos(inverseC);

                double degrees = inverseC * (180 / Math.PI);
                textBoxDisplay.Text = inverseC.ToString();
            }
        }

        #endregion

            // YH - Don't get rid of this
        private TextBox textBoxDisplay;
        private TableLayoutPanel tableLayoutPanel;
        private Button buttonInverseSin;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonSeven;
        private Button buttonAdd;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonDivide;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonOne;
        private Button buttonTan;
        private Button buttonSin;
        private Button buttonDelete;
        private Button buttonSquareRoot;
        private Button buttonInverseTan;
        private Button buttonClear;
        private Button buttonMultiply;
        private Button buttonMinus;
        private Button buttonSquare;
        private Button buttonEquals;
        private Button buttonPowerofY;
        private Button buttonPlusorMinus;
        private Button buttonZero;
        private Button buttonDecimal;
        private Button buttonInverseCos;
        private Button buttonCos;
        private Button buttonPi;
    }
}
