using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timerTick.Text = "00:00:00";
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void activateButtonColor(Button clickedButton)
        {
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.Transparent;
                currentActiveButton.ForeColor = Color.Black;

            }

            clickedButton.BackColor = ColorTranslator.FromHtml("#e80054");
            clickedButton.ForeColor = Color.White;
            currentActiveButton = clickedButton;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_hover(object sender, EventArgs e)
        {
            //////if button property flatstyle is standard
            ////button1.BackColor = ColorTranslator.FromHtml("#e80054");

            ////if button property flatstyle is flat
            //button1.FlatStyle = FlatStyle.Flat;
            //button1.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#FF5733"); // Hover color
            //button1.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#C70039"); // Clicked color

            //button1.GotFocus += (sender, e) =>
            //{
            //    button1.BackColor = ColorTranslator.FromHtml("#28A745"); // Active background color
            //    button1.ForeColor = Color.White; // Active font color
            //};

            //button1.LostFocus += (sender, e) =>
            //{
            //    button1.BackColor = Color.White; // Reset background color when inactive
            //    button1.ForeColor = Color.Black; // Reset font color when inactive
            //};


        }

        //Login form button on_click event
        private void button1_Click(object sender, EventArgs e)
        {
            //method to change color of active button
            activateButtonColor((Button)sender);

            Login_form Login_form_obj = new Login_form();

            //by default form act as its own window
            Login_form_obj.TopLevel = false;

            //to remove minimize, close button
            Login_form_obj.FormBorderStyle = FormBorderStyle.None;

            //to make form fill entire space
            Login_form_obj.Dock = DockStyle.Fill;

            // clear all previous form
            showPanel.Controls.Clear();
            showPanel.Controls.Add(Login_form_obj);
            Login_form_obj.Show();
        }

        //Register form button on_click event
        private void registerButton_Click(object sender, EventArgs e)
        {
            activateButtonColor((Button)sender);

            showPanel.Controls.Clear();
            registerForm registerForm_obj = new registerForm();
            registerForm_obj.TopLevel = false;
            registerForm_obj.FormBorderStyle = FormBorderStyle.None;
            registerForm_obj.Dock = DockStyle.Fill;
            showPanel.Controls.Add(registerForm_obj);
            registerForm_obj.Show();

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            activateButtonColor((Button)sender);
            showPanel.Controls.Clear();
            calculatorForm calculatorForm_obj = new calculatorForm();
            calculatorForm_obj.TopLevel = false;
            calculatorForm_obj.FormBorderStyle = FormBorderStyle.None;
            calculatorForm_obj.Dock = DockStyle.Fill;

            showPanel.Controls.Add(calculatorForm_obj);
            calculatorForm_obj.Show();
        }
    }
}
