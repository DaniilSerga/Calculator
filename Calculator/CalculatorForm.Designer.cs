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
            this.ButtonNegation = new System.Windows.Forms.Button();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSubstract = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonNegation);
            this.panel1.Controls.Add(this.textDisplay);
            this.panel1.Controls.Add(this.buttonClean);
            this.panel1.Controls.Add(this.ButtonDivide);
            this.panel1.Controls.Add(this.ButtonNine);
            this.panel1.Controls.Add(this.ButtonEight);
            this.panel1.Controls.Add(this.ButtonSeven);
            this.panel1.Controls.Add(this.ButtonResult);
            this.panel1.Controls.Add(this.ButtonAdd);
            this.panel1.Controls.Add(this.ButtonSubstract);
            this.panel1.Controls.Add(this.ButtonMultiply);
            this.panel1.Controls.Add(this.ButtonSix);
            this.panel1.Controls.Add(this.ButtonFive);
            this.panel1.Controls.Add(this.ButtonFour);
            this.panel1.Controls.Add(this.ButtonThree);
            this.panel1.Controls.Add(this.ButtonTwo);
            this.panel1.Controls.Add(this.ButtonOne);
            this.panel1.Controls.Add(this.ButtonZero);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 302);
            this.panel1.TabIndex = 0;
            // 
            // ButtonNegation
            // 
            this.ButtonNegation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonNegation.Location = new System.Drawing.Point(59, 249);
            this.ButtonNegation.Name = "ButtonNegation";
            this.ButtonNegation.Size = new System.Drawing.Size(50, 50);
            this.ButtonNegation.TabIndex = 17;
            this.ButtonNegation.Text = "+/-";
            this.ButtonNegation.UseVisualStyleBackColor = false;
            this.ButtonNegation.Click += new System.EventHandler(this.ButtonNegation_Click);
            // 
            // textDisplay
            // 
            this.textDisplay.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDisplay.Location = new System.Drawing.Point(3, 3);
            this.textDisplay.MaxLength = 10;
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.Size = new System.Drawing.Size(274, 72);
            this.textDisplay.TabIndex = 1;
            this.textDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // ButtonDivide
            // 
            this.ButtonDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonDivide.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDivide.Location = new System.Drawing.Point(171, 249);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(50, 50);
            this.ButtonDivide.TabIndex = 14;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = false;
            this.ButtonDivide.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonNine.Location = new System.Drawing.Point(115, 81);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(50, 50);
            this.ButtonNine.TabIndex = 13;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = false;
            this.ButtonNine.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEight.Location = new System.Drawing.Point(59, 81);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(50, 50);
            this.ButtonEight.TabIndex = 12;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = false;
            this.ButtonEight.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSeven.Location = new System.Drawing.Point(3, 81);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(50, 50);
            this.ButtonSeven.TabIndex = 11;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = false;
            this.ButtonSeven.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonResult.Enabled = false;
            this.ButtonResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonResult.Location = new System.Drawing.Point(227, 81);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(50, 218);
            this.ButtonResult.TabIndex = 10;
            this.ButtonResult.Text = "=";
            this.ButtonResult.UseVisualStyleBackColor = false;
            this.ButtonResult.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAdd.Location = new System.Drawing.Point(171, 81);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(50, 50);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // ButtonSubstract
            // 
            this.ButtonSubstract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonSubstract.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSubstract.Location = new System.Drawing.Point(171, 137);
            this.ButtonSubstract.Name = "ButtonSubstract";
            this.ButtonSubstract.Size = new System.Drawing.Size(50, 50);
            this.ButtonSubstract.TabIndex = 8;
            this.ButtonSubstract.Text = "-";
            this.ButtonSubstract.UseVisualStyleBackColor = false;
            this.ButtonSubstract.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonMultiply.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMultiply.Location = new System.Drawing.Point(171, 193);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(50, 50);
            this.ButtonMultiply.TabIndex = 7;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = false;
            this.ButtonMultiply.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSix.Location = new System.Drawing.Point(115, 137);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(50, 50);
            this.ButtonSix.TabIndex = 6;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = false;
            this.ButtonSix.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFive.Location = new System.Drawing.Point(59, 137);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(50, 50);
            this.ButtonFive.TabIndex = 5;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = false;
            this.ButtonFive.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFour.Location = new System.Drawing.Point(3, 137);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(50, 50);
            this.ButtonFour.TabIndex = 4;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = false;
            this.ButtonFour.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonThree.Location = new System.Drawing.Point(115, 193);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(50, 50);
            this.ButtonThree.TabIndex = 3;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = false;
            this.ButtonThree.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonTwo.Location = new System.Drawing.Point(59, 193);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(50, 50);
            this.ButtonTwo.TabIndex = 2;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = false;
            this.ButtonTwo.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOne.Location = new System.Drawing.Point(3, 193);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(50, 50);
            this.ButtonOne.TabIndex = 1;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = false;
            this.ButtonOne.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonZero.Location = new System.Drawing.Point(3, 249);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(50, 50);
            this.ButtonZero.TabIndex = 0;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = false;
            this.ButtonZero.Click += new System.EventHandler(this.NumberButton_Click);
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
            this.panel2.Controls.Add(this.ButtonMinimize);
            this.panel2.Controls.Add(this.ButtonClose);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 47);
            this.panel2.TabIndex = 3;
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonMinimize.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonMinimize.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMinimize.Location = new System.Drawing.Point(216, 4);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(40, 40);
            this.ButtonMinimize.TabIndex = 4;
            this.ButtonMinimize.Text = "–";
            this.ButtonMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonMinimize.UseVisualStyleBackColor = false;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonClose.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonClose.Location = new System.Drawing.Point(262, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(40, 40);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "x";
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
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
        private Button ButtonSix;
        private Button ButtonFive;
        private Button ButtonFour;
        private Button ButtonThree;
        private Button ButtonTwo;
        private Button ButtonOne;
        private Button ButtonZero;
        private Button ButtonDivide;
        private Button ButtonNine;
        private Button ButtonEight;
        private Button ButtonSeven;
        public Button ButtonResult;
        private Button ButtonAdd;
        private Button ButtonSubstract;
        private Button ButtonMultiply;
        private TextBox textDisplay;
        private Button buttonClean;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button ButtonMinimize;
        private Button ButtonClose;
        private Button ButtonNegation;
    }
}