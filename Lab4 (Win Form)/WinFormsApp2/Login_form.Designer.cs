namespace WinFormsApp2
{
    partial class Login_form
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
            label1 = new Label();
            textEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 85);
            label1.Name = "label1";
            label1.Size = new Size(99, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(297, 144);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(272, 25);
            textEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 147);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 184);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(297, 181);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(272, 25);
            textPassword.TabIndex = 4;
            textPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(371, 230);
            button1.Name = "button1";
            button1.Size = new Size(99, 32);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textEmail);
            Controls.Add(label1);
            Name = "Login_form";
            Text = "Login_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textEmail;
        private Label label2;
        private Label label3;
        private TextBox textPassword;
        private Button button1;
    }
}