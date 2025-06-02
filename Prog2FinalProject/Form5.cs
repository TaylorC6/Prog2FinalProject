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
        System.Collections.Specialized.StringCollection SavingsTransactions = Properties.Settings.Default.SavingsTrans;
        System.Collections.Specialized.StringCollection CheckingTransactions = Properties.Settings.Default.CheckingTrans;
        System.Collections.Specialized.StringCollection InvestmentsTransactions = Properties.Settings.Default.InvestmentsTrans;
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
           
                
                
            

        }

        private void button2_Click_1(object sender, EventArgs e) {
            float garbage = 0;
            string temp = "";
            bool success = float.TryParse(textBox2.Text, out garbage);
            bool Check = radioButton1.Checked;
            if (textBox1.Text.Contains("~")|| textBox1.Text.Contains("|")) {
                MessageBox.Show("You cannot use ~ or | in your transaction name.");
            }
            else if (success == false) {
                MessageBox.Show("You must enter a  positive number!");
            }
            else {
                temp = textBox1.Text + "~" + textBox2.Text +"|" + Check.ToString();
                Properties.Settings.Default.SavingsTrans.Add(temp);
                
                MessageBox.Show("success! " + temp + "||||||||" + Properties.Settings.Default.SavingsTrans
                                                         [Properties.Settings.Default.SavingsTrans.Count - 1]);
                
            }

        }

        private void button3_Click(object sender, EventArgs e) {
            Properties.Settings.Default.Save();
            Application.Exit();
        }
    }
}
