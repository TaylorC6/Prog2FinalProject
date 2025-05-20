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
            Properties.Settings.Default.Username = textBox1.Text;
            Form f1 = myParent;
            if (textBox1.Text != "") {
                f1.Show();
                this.Hide();
            } else {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Username Required";
            } 

            }

        private void textBox1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "Username Required") { textBox1.Text = ""; textBox1.ForeColor = Color.Black; }
        }
    }
}
