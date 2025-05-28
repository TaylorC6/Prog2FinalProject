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
    public partial class Form5 : Form
    {
        private Form myParent;
        public Form5(Form myParent)
        {
            InitializeComponent();
            this.myParent = myParent;
        }

        private void button1_Click(object sender, EventArgs e) {
            Form f1 = myParent;
            f1.Show();
            this.Hide();
            }

        private void button2_Click(object sender, EventArgs e) {
            string temp = "";
            bool success = float.TryParse(textBox2.Text);
            if (textBox1.Text.Contains("~")){
                MessageBox.Show("You cannot use ~ in your transaction name.");
            }
            else if (success == false){
                MessageBox.Show("You must enter a  positive number!");
            }
            else{
                temp = textBox1.Text + "~" + textBox2.Text;
                
                
            }

        }
    }
}
