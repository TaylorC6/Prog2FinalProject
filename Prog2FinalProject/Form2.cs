using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2FinalProject
{
    public partial class Form2 : Form
    {
        private Form myParent;
        public Form2(Form myParent)
        {
            InitializeComponent();
            this.myParent = myParent;
            string name = textBox1.Text;
            string mail = textBox2.Text;
            string password = textBox3.Text;
            string unknown = textBox4.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Form f1 = myParent;
            f1.Show();
            this.Hide();
        } 

        private void textBox1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "Username Required") { textBox1.Text = ""; textBox1.ForeColor = Color.Black; }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            bool b1 = false;
            bool b2 = false;
            bool b3 = false;
            if (textBox1.Text == "") { textBox1.Text = "Username Required"; textBox1.ForeColor = Color.Red; b1 = false; } else if (textBox1.Text != "Username Required") { b1 = true; }
            if (textBox2.Text == "") { textBox2.Text = "Email Required"; textBox2.ForeColor = Color.Red; b2 = false; } else if (textBox2.Text != "Email Required") { b2 = true; }
            if (textBox3.Text == "") { textBox3.Text = "Password Required"; textBox3.ForeColor = Color.Red; b3 = false; } else if (textBox3.Text != "Password Required") { b3 = true; }
            if (b1 == true && b2 == true && b3 == true) { button2.Visible = false;
                Properties.Settings.Default.Username = textBox1.Text;
                Properties.Settings.Default.Email = textBox2.Text;
                Properties.Settings.Default.Password = textBox3.Text;
                Properties.Settings.Default.LoggedIn = true;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) {

        }

        private void textBox2_Click(object sender, EventArgs e) {
            if (textBox2.Text == "Email Required") { textBox2.Text = ""; textBox2.ForeColor = Color.Black; }
        }

        private void textBox3_Click(object sender, EventArgs e) {
            if (textBox3.Text == "Password Required") { textBox3.Text = ""; textBox3.ForeColor = Color.Black; }
        }
    }
}
