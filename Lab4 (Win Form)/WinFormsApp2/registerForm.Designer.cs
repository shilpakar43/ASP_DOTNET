namespace WinFormsApp2
{
    partial class registerForm
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
            label1 = new Label();
            Nme = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 32);
            label1.Name = "label1";
            label1.Size = new Size(135, 45);
            label1.TabIndex = 0;
            label1.Text = "Register";
            label1.Click += label1_Click;
            // 
            // Nme
            // 
            Nme.AutoSize = true;
            Nme.Location = new Point(211, 91);
            Nme.Name = "Nme";
            Nme.Size = new Size(0, 17);
            Nme.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 164);
            label3.Name = "label3";
            label3.Size = new Size(31, 17);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 203);
            label4.Name = "label4";
            label4.Size = new Size(57, 17);
            label4.TabIndex = 3;
            label4.Text = "Province";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 247);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 4;
            label5.Text = "District";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 122);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 5;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 296);
            label6.Name = "label6";
            label6.Size = new Size(36, 17);
            label6.TabIndex = 6;
            label6.Text = "Skills";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 25);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(273, 164);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(84, 25);
            numericUpDown1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Koshi", "Madesh", "Bagmati", "Gandaki", "Lumbini", "Karnali", "Sudhurpaschim" });
            comboBox1.Location = new Point(273, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 25);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(273, 244);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 25);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "C++", "Python", "C#", "Java" });
            checkedListBox1.Location = new Point(273, 296);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(195, 80);
            checkedListBox1.TabIndex = 11;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Nme);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(Nme, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(numericUpDown1, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(comboBox2, 0);
            Controls.SetChildIndex(checkedListBox1, 0);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Nme;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private CheckedListBox checkedListBox1;
    }
}
