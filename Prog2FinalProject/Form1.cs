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
    public partial class HiveBank : Form {

        bool account_created = false;
        
        public HiveBank() {
            InitializeComponent();
        }
        // subscription title: TextBox
        //  ListBox:
        //  Add textBox

        //Properties.Settings.Default.<setting name here>

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
            Form f2 = new Form2(this);
            if (account_created == false) {
                account_created = true;
                f2.Show();
                this.Hide();
            }
            else {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void Form1_VisibleChanged(object sender, EventArgs e) {

            if (username_created == true) { button4.Text = "Log Out"; 
            label5.Text = "Welcome " + Properties.Settings.Default.Username + "!";
            label11.Text = "Savings: $" + Properties.Settings.Default.Savings;
            }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e){
            Properties.Settings.Default.Save();
        }     
        }
    }
}