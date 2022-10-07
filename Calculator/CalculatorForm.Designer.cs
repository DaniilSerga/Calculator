namespace Calculator
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.ButtonNegation = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textDisplay);
            this.panel1.Controls.Add(this.buttonClean);
            this.panel1.Controls.Add(this.ButtonNegation);
            this.panel1.Controls.Add(this.buttonDivide);
            this.panel1.Controls.Add(this.buttonNine);
            this.panel1.Controls.Add(this.buttonEight);
            this.panel1.Controls.Add(this.buttonSeven);
            this.panel1.Controls.Add(this.buttonResult);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonSubstract);
            this.panel1.Controls.Add(this.buttonMultiply);
            this.panel1.Controls.Add(this.buttonSix);
            this.panel1.Controls.Add(this.buttonFive);
            this.panel1.Controls.Add(this.buttonFour);
            this.panel1.Controls.Add(this.buttonThree);
            this.panel1.Controls.Add(this.buttonTwo);
            this.panel1.Controls.Add(this.buttonOne);
            this.panel1.Controls.Add(this.buttonZero);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 302);
            this.panel1.TabIndex = 0;
            // 
            // textDisplay
            // 
            this.textDisplay.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDisplay.Location = new System.Drawing.Point(3, 3);
            this.textDisplay.MaxLength = 10;
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textDisplay.Size = new System.Drawing.Size(274, 72);
            this.textDisplay.TabIndex = 1;
            this.textDisplay.WordWrap = false;
            this.textDisplay.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonClean.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClean.Location = new System.Drawing.Point(115, 249);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(50, 50);
            this.buttonClean.TabIndex = 16;
            this.buttonClean.Text = "С";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ButtonNegation
            // 
            this.ButtonNegation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonNegation.Location = new System.Drawing.Point(59, 249);
            this.ButtonNegation.Name = "ButtonNegation";
            this.ButtonNegation.Size = new System.Drawing.Size(50, 50);
            this.ButtonNegation.TabIndex = 15;
            this.ButtonNegation.Text = "+/-";
            this.ButtonNegation.UseVisualStyleBackColor = true;
            this.ButtonNegation.Click += new System.EventHandler(this.ButtonNegation_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDivide.Location = new System.Drawing.Point(171, 249);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(50, 50);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNine.Location = new System.Drawing.Point(115, 81);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(50, 50);
            this.buttonNine.TabIndex = 13;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEight.Location = new System.Drawing.Point(59, 81);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(50, 50);
            this.buttonEight.TabIndex = 12;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSeven.Location = new System.Drawing.Point(3, 81);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(50, 50);
            this.buttonSeven.TabIndex = 11;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResult.Location = new System.Drawing.Point(227, 81);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(50, 218);
            this.buttonResult.TabIndex = 10;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(171, 81);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSubstract.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubstract.Location = new System.Drawing.Point(171, 137);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(50, 50);
            this.buttonSubstract.TabIndex = 8;
            this.buttonSubstract.Text = "-";
            this.buttonSubstract.UseVisualStyleBackColor = false;
            this.buttonSubstract.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMultiply.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiply.Location = new System.Drawing.Point(171, 193);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(50, 50);
            this.buttonMultiply.TabIndex = 7;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSix.Location = new System.Drawing.Point(115, 137);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(50, 50);
            this.buttonSix.TabIndex = 6;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFive.Location = new System.Drawing.Point(59, 137);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(50, 50);
            this.buttonFive.TabIndex = 5;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFour.Location = new System.Drawing.Point(3, 137);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(50, 50);
            this.buttonFour.TabIndex = 4;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThree.Location = new System.Drawing.Point(115, 193);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(50, 50);
            this.buttonThree.TabIndex = 3;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTwo.Location = new System.Drawing.Point(59, 193);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(50, 50);
            this.buttonTwo.TabIndex = 2;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOne.Location = new System.Drawing.Point(3, 193);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(50, 50);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonZero.Location = new System.Drawing.Point(3, 249);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(50, 50);
            this.buttonZero.TabIndex = 0;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculatorView.Properties.Resources.Calculator_31111;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "MyCalculator";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonMinimize);
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 47);
            this.panel2.TabIndex = 3;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMinimize.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMinimize.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinimize.Location = new System.Drawing.Point(216, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(40, 40);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.Text = "–";
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonClose.BackColor = System.Drawing.SystemColors.Window;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(262, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "x";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(306, 367);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormCalculator";
            this.Text = "MyCalculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorForm_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonOne;
        private Button buttonZero;
        private Button buttonDivide;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonSeven;
        public Button buttonResult;
        private Button buttonAdd;
        private Button buttonSubstract;
        private Button buttonMultiply;
        private TextBox textDisplay;
        private Button ButtonNegation;
        private Button buttonClean;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button buttonMinimize;
        private Button buttonClose;
    }
}