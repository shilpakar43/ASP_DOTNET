namespace WinFormsApp2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            timerToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            calculatorButton = new Button();
            registerButton = new Button();
            button1 = new Button();
            showPanel = new Panel();
            timerTick = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            showPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(232, 0, 84);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, timerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(920, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 21);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(42, 21);
            editToolStripMenuItem.Text = "Edit";
            // 
            // timerToolStripMenuItem
            // 
            timerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, stopToolStripMenuItem });
            timerToolStripMenuItem.ForeColor = Color.White;
            timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            timerToolStripMenuItem.Size = new Size(53, 21);
            timerToolStripMenuItem.Text = "Timer";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(103, 22);
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(103, 22);
            stopToolStripMenuItem.Text = "Stop";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(calculatorButton);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 425);
            panel1.TabIndex = 1;
            // 
            // calculatorButton
            // 
            calculatorButton.FlatAppearance.BorderSize = 0;
            calculatorButton.FlatStyle = FlatStyle.Flat;
            calculatorButton.Location = new Point(0, 66);
            calculatorButton.Name = "calculatorButton";
            calculatorButton.Padding = new Padding(15, 0, 0, 0);
            calculatorButton.Size = new Size(155, 33);
            calculatorButton.TabIndex = 2;
            calculatorButton.Text = "Calculator";
            calculatorButton.TextAlign = ContentAlignment.MiddleLeft;
            calculatorButton.UseVisualStyleBackColor = true;
            calculatorButton.Click += calculatorButton_Click;
            // 
            // registerButton
            // 
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Location = new Point(0, 33);
            registerButton.Name = "registerButton";
            registerButton.Padding = new Padding(15, 0, 0, 0);
            registerButton.Size = new Size(155, 33);
            registerButton.TabIndex = 1;
            registerButton.Text = "Register";
            registerButton.TextAlign = ContentAlignment.MiddleLeft;
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.Size = new Size(155, 33);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseHover += button1_hover;
            // 
            // showPanel
            // 
            showPanel.BackColor = Color.White;
            showPanel.Controls.Add(timerTick);
            showPanel.Dock = DockStyle.Fill;
            showPanel.Location = new Point(155, 25);
            showPanel.Name = "showPanel";
            showPanel.Size = new Size(765, 425);
            showPanel.TabIndex = 2;
            // 
            // timerTick
            // 
            timerTick.AutoSize = true;
            timerTick.Location = new Point(681, 307);
            timerTick.Name = "timerTick";
            timerTick.Size = new Size(43, 17);
            timerTick.TabIndex = 0;
            timerTick.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 450);
            Controls.Add(showPanel);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            showPanel.ResumeLayout(false);
            showPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem timerToolStripMenuItem;
        private Panel panel1;
        private Button button1;
        private Panel showPanel;

        // for storing current active button
        private Button currentActiveButton = null;
        private Button calculatorButton;
        private Button registerButton;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private Label timerTick;
    }
}