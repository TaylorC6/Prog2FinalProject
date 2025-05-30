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
        int a1 = 0; // subtract percentage based on income and expense on every line
        int a2 = 0;
        int a3 = 0;
        int a4 = 0;
        int a5 = 0;
        int a6 = 0;
        int a7 = 0;
        int a8 = 0;
        int a9 = 0;
        int a10 = 0;
        int a11 = 0;
        int a12 = 0;
        
        public HiveBank() {
            InitializeComponent();
        }
        // subscription title: TextBox
        //  ListBox:
        //  Add textBox

        //Properties.Settings.Default.<setting name here>

        private void button1_Click(object sender, EventArgs e) {
            //Transactions
            Form f5 = new Form5(this);
            f5.Show();
            this.Hide();
            }

        private void label5_Click(object sender, EventArgs e) {
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            //Accounts
            Form f3 = new Form3(this,account_created);
            this.Hide();
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
                if (button4.Text == "Log Out") { account_created = false; f2.Show(); this.Hide(); }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void Form1_VisibleChanged(object sender, EventArgs e) {

            if (account_created == true) { button4.Text = "Log Out"; 
            label5.Text = "Welcome " + Properties.Settings.Default.Username + "!";
            label11.Text = "Savings: $" + Properties.Settings.Default.Savings;
            In1.Height = 165 - a1;
            In1.Top = (int)285 + a1;
            Ex1.Height = 165 - a1;
            Ex1.Top = (int)285 + a2;
            In2.Height = 165 - a3;
            In2.Top = (int)285 + a3;
            Ex2.Height = 165 - a4;
            Ex2.Top = (int)285 + a4;
            In3.Height = 165 - a5;
            In3.Top = (int)285 + a5;
            Ex3.Height = 165 - a6;
            Ex3.Top = (int)285 + a6;
            In4.Height = 165 - a7;
            In4.Top = (int)285 + a7;
            Ex4.Height = 165 - a8;
            Ex4.Top = (int)285 + a8;
            In5.Height = 165 - a9;
            In5.Top = (int)285 + a9;
            Ex5.Height = 165 - a10;
            Ex5.Top = (int)285 + a10;
            In6.Height = 165 - a11;
            In6.Top = (int)285 + a11;
            Ex6.Height = 165 - a12;
            Ex6.Top = (int)285 + a12;


            }
        //private void Form1_FormClosing(object sender, FormClosingEventArgs){
        //    Properties.Settings.Default.Save();
        }


        private void button5_Click(object sender, EventArgs e) 
        {
            
        }

        private void label18_Click(object sender, EventArgs e) {

        }



        private void button5_Click_1(object sender, EventArgs e) {
            Application.Exit();
        }
    }
    
}