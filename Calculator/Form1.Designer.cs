namespace Calculator
{
    partial class CalculatorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveLastButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.SubstractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveLastButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.DotButton);
            this.panel1.Controls.Add(this.DivideButton);
            this.panel1.Controls.Add(this.Button9);
            this.panel1.Controls.Add(this.Button8);
            this.panel1.Controls.Add(this.Button7);
            this.panel1.Controls.Add(this.EqualsButton);
            this.panel1.Controls.Add(this.SumButton);
            this.panel1.Controls.Add(this.SubstractButton);
            this.panel1.Controls.Add(this.MultiplyButton);
            this.panel1.Controls.Add(this.Button6);
            this.panel1.Controls.Add(this.Button5);
            this.panel1.Controls.Add(this.Button4);
            this.panel1.Controls.Add(this.Button3);
            this.panel1.Controls.Add(this.Button2);
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Controls.Add(this.Button0);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 279);
            this.panel1.TabIndex = 0;
            // 
            // RemoveLastButton
            // 
            this.RemoveLastButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveLastButton.Location = new System.Drawing.Point(116, 3);
            this.RemoveLastButton.Name = "RemoveLastButton";
            this.RemoveLastButton.Size = new System.Drawing.Size(50, 50);
            this.RemoveLastButton.TabIndex = 17;
            this.RemoveLastButton.Text = "<-";
            this.RemoveLastButton.UseVisualStyleBackColor = true;
            this.RemoveLastButton.Click += new System.EventHandler(this.RemoveLastButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(4, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(106, 50);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "С";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DotButton.Location = new System.Drawing.Point(4, 227);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(50, 50);
            this.DotButton.TabIndex = 15;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivideButton.Location = new System.Drawing.Point(172, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(50, 50);
            this.DivideButton.TabIndex = 14;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button9.Location = new System.Drawing.Point(116, 59);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(50, 50);
            this.Button9.TabIndex = 13;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button8.Location = new System.Drawing.Point(60, 59);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(50, 50);
            this.Button8.TabIndex = 12;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button7.Location = new System.Drawing.Point(4, 59);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(50, 50);
            this.Button7.TabIndex = 11;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EqualsButton.Location = new System.Drawing.Point(116, 227);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(106, 50);
            this.EqualsButton.TabIndex = 10;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // SumButton
            // 
            this.SumButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SumButton.Location = new System.Drawing.Point(172, 171);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(50, 50);
            this.SumButton.TabIndex = 9;
            this.SumButton.Text = "+";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // SubstractButton
            // 
            this.SubstractButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubstractButton.Location = new System.Drawing.Point(172, 115);
            this.SubstractButton.Name = "SubstractButton";
            this.SubstractButton.Size = new System.Drawing.Size(50, 50);
            this.SubstractButton.TabIndex = 8;
            this.SubstractButton.Text = "-";
            this.SubstractButton.UseVisualStyleBackColor = true;
            this.SubstractButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplyButton.Location = new System.Drawing.Point(172, 59);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(50, 50);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button6.Location = new System.Drawing.Point(116, 115);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(50, 50);
            this.Button6.TabIndex = 6;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button5.Location = new System.Drawing.Point(60, 115);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(50, 50);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button4.Location = new System.Drawing.Point(4, 115);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(50, 50);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button3.Location = new System.Drawing.Point(116, 171);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(50, 50);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(60, 171);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(50, 50);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(4, 171);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(50, 50);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Button0
            // 
            this.Button0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button0.Location = new System.Drawing.Point(60, 227);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(50, 50);
            this.Button0.TabIndex = 0;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputBox.Location = new System.Drawing.Point(16, 12);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.OutputBox.Size = new System.Drawing.Size(218, 62);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.WordWrap = false;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 363);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "CalculatorForm";
            this.Text = " Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorForm_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button Button6;
        private Button Button5;
        private Button Button4;
        private Button Button3;
        private Button Button2;
        private Button Button1;
        private Button Button0;
        private Button DivideButton;
        private Button Button9;
        private Button Button8;
        private Button Button7;
        private Button EqualsButton;
        private Button SumButton;
        private Button SubstractButton;
        private Button MultiplyButton;
        private TextBox OutputBox;
        private Button DotButton;
        private Button RemoveLastButton;
        private Button ClearButton;
    }
}