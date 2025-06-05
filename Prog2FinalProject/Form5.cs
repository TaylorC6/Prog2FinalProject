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
                if (comboBox1.Text == "Savings")
                {
                    Properties.Settings.Default.SavingsTrans.Add(temp);
                    if (success)
                    {
                        Properties.Settings.Default.Savings += garbage;
                    }

                    MessageBox.Show("success! " + temp + "||||||||" + Properties.Settings.Default.SavingsTrans
                                                             [Properties.Settings.Default.SavingsTrans.Count - 1]);
                }
                else if (comboBox1.Text == "Checking")
                {
                    Properties.Settings.Default.CheckingTrans.Add(temp);
                    if (success)
                    {
                        Properties.Settings.Default.Checking += garbage;
                    }

                    MessageBox.Show("success! " + temp + "||||||||" + Properties.Settings.Default.CheckingTrans
                                                             [Properties.Settings.Default.CheckingTrans.Count - 1]);
                }
                else if (comboBox1.Text == "Investments")
                {
                    Properties.Settings.Default.InvestmentsTrans.Add(temp);
                    if (success)
                    {
                        Properties.Settings.Default.Investments += garbage;
                    } 

                    MessageBox.Show("success! " + temp + "||||||||" + Properties.Settings.Default.InvestmentsTrans
                                                             [Properties.Settings.Default.InvestmentsTrans.Count - 1]);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e) {
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
