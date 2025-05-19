using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2FinalProject {
    public partial class Form1 : Form {

        private Form myParent;
        public Form1(Form2 form) {
            
            if (Properties.Resources.Username != ""){
                button4.Text = "Exit";
            }
            InitializeComponent();
            // subscription title: TextBox
            //  ListBox:
            //  Add textBox
            
 
        }
        private void button1_Click(object sender, EventArgs e) {
            //Transactions
        }

        private void label5_Click(object sender, EventArgs e) {





        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            //Accounts
        }

        private void button3_Click(object sender, EventArgs e) {
            //Upcoming
        }

        private void button4_Click(object sender, EventArgs e) {
            Form log = new Form2(this);
            if (Properties.Resources.Username == "") {
                log.Show();
                this.Hide();
            else;

            }
        }
    }
}
