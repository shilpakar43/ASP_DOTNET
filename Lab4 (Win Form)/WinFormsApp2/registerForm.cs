using System;

namespace WinFormsApp2
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ComboBox1 function
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string province = comboBox1.SelectedItem.ToString();

            string[] koshi_dist = new string[] { "Bhojpur", "Dhankuta", "Illam", "Jhapa", "Khotang", "Morang", "Okhaldhunga", "Panchthar", "Sankhuwasabha", "Solukhumbu", "Sunsari", "Taplejung", "Terhathum", "Udayapur" };
            string[] madhesh_dist = new string[] {"Birgunj", "Kailali", "Gaur", "Malangwa", "Janakpur", "Siraha", "Jaleshwar", "Rajbiraj"};
            string[] bagmati_dist = new string[] { "Rasuwa", "Nuwakot", "Dhading", "Chitwan", "Makwanpur", "Kathmandu", "Lalitpur", "Bhaktapur", "Kavrepalanchok", "Sindhupalchok", "Dolkha", "Ramechap", "Sindhuli" };
            string[] gandaki_dist = new string[] { "Mustang","Manang", "Myagdi", "Baglung", "Parbat", "Kaski", "Syangja", "Tanahun", "Nawalparasi East", "Lamnjung", "Gorkha" };
            string[] lumbini_dist = new string[] { "Rukum East", "Rolpa", "Pyuthan", "Gulmi", "Arghakhanchi", "Palpa", "Nawalparasi West", "Rupandehi", "Kapilvastu", "Dang", "Banke", "Bardiya" };
            string[] karnali_dist = new string[] { "Humla", "Mugu", "Jumla", "Dolpa", "Rukum West", "Jajarkot", "Dailekh", "Kalikot", "Surkhet", "Salyan" };
            string[] sudur_dist = new string[] { "Darchula", "Bajhang", "Bajura", "Achham", "Doti", "Baitadi", "Dadeldhura", "Kanchanpur", "Kailali" };

            switch (province)
            {
                case "Koshi":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(koshi_dist);
                    break;
                case "Madhesh":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(madhesh_dist);
                    break;
                case "Bagmati":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(bagmati_dist);
                    break;
                case "Gandaki":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(gandaki_dist);
                    break;
                case "Lumbini":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(lumbini_dist);
                    break;
                case "Karnali":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(karnali_dist);
                    break;
                case "SudhurPaschim":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(sudur_dist);
                    break;
                default:
                    comboBox2.Items.Clear();
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
