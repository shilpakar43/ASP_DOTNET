namespace WinFormsApp2
{
    partial class calculatorForm
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            clearButton = new Button();
            button11 = new Button();
            equalToButton = new Button();
            addOperator = new Button();
            subtractOperator = new Button();
            divideOperator = new Button();
            multipyOperator = new Button();
            label1 = new Label();
            backButton = new Button();
            button12 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 86);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(218, 25);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(275, 117);
            button1.Name = "button1";
            button1.Size = new Size(50, 43);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(331, 117);
            button2.Name = "button2";
            button2.Size = new Size(50, 43);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(387, 117);
            button3.Name = "button3";
            button3.Size = new Size(50, 43);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(275, 166);
            button4.Name = "button4";
            button4.Size = new Size(50, 43);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(331, 166);
            button5.Name = "button5";
            button5.Size = new Size(50, 43);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(387, 166);
            button6.Name = "button6";
            button6.Size = new Size(50, 43);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(275, 215);
            button7.Name = "button7";
            button7.Size = new Size(50, 43);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(331, 215);
            button8.Name = "button8";
            button8.Size = new Size(50, 43);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(387, 215);
            button9.Name = "button9";
            button9.Size = new Size(50, 43);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(443, 166);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(50, 43);
            clearButton.TabIndex = 10;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // button11
            // 
            button11.Location = new Point(331, 264);
            button11.Name = "button11";
            button11.Size = new Size(50, 43);
            button11.TabIndex = 11;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button_Click;
            // 
            // equalToButton
            // 
            equalToButton.BackColor = Color.FromArgb(232, 0, 84);
            equalToButton.FlatStyle = FlatStyle.Flat;
            equalToButton.ForeColor = Color.White;
            equalToButton.Location = new Point(443, 215);
            equalToButton.Name = "equalToButton";
            equalToButton.Size = new Size(50, 141);
            equalToButton.TabIndex = 12;
            equalToButton.Text = "=";
            equalToButton.UseVisualStyleBackColor = false;
            equalToButton.Click += equalToButton_Click;
            // 
            // addOperator
            // 
            addOperator.Location = new Point(331, 313);
            addOperator.Name = "addOperator";
            addOperator.Size = new Size(50, 43);
            addOperator.TabIndex = 13;
            addOperator.Text = "+";
            addOperator.UseVisualStyleBackColor = true;
            addOperator.Click += button_Click;
            // 
            // subtractOperator
            // 
            subtractOperator.Location = new Point(387, 313);
            subtractOperator.Name = "subtractOperator";
            subtractOperator.Size = new Size(50, 43);
            subtractOperator.TabIndex = 14;
            subtractOperator.Text = "-";
            subtractOperator.UseVisualStyleBackColor = true;
            subtractOperator.Click += button_Click;
            // 
            // divideOperator
            // 
            divideOperator.Location = new Point(275, 264);
            divideOperator.Name = "divideOperator";
            divideOperator.Size = new Size(50, 43);
            divideOperator.TabIndex = 15;
            divideOperator.Text = "/";
            divideOperator.UseVisualStyleBackColor = true;
            divideOperator.Click += button_Click;
            // 
            // multipyOperator
            // 
            multipyOperator.Location = new Point(275, 313);
            multipyOperator.Name = "multipyOperator";
            multipyOperator.Size = new Size(50, 43);
            multipyOperator.TabIndex = 16;
            multipyOperator.Text = "*";
            multipyOperator.UseVisualStyleBackColor = true;
            multipyOperator.Click += button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 38);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // backButton
            // 
            backButton.Location = new Point(443, 117);
            backButton.Name = "backButton";
            backButton.Size = new Size(50, 43);
            backButton.TabIndex = 17;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // button12
            // 
            button12.Location = new Point(387, 264);
            button12.Name = "button12";
            button12.Size = new Size(50, 43);
            button12.TabIndex = 18;
            button12.Text = "00";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_Click;
            // 
            // calculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button12);
            Controls.Add(backButton);
            Controls.Add(label1);
            Controls.Add(multipyOperator);
            Controls.Add(divideOperator);
            Controls.Add(subtractOperator);
            Controls.Add(addOperator);
            Controls.Add(equalToButton);
            Controls.Add(button11);
            Controls.Add(clearButton);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "calculatorForm";
            Text = "calculatorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button clearButton;
        private Button button11;
        private Button equalToButton;
        private Button addOperator;
        private Button subtractOperator;
        private Button divideOperator;
        private Button multipyOperator;
        private Label label1;
        private Button backButton;
        private Button button12;
    }
}