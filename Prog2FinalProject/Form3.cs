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
    public partial class Form3 : Form {
        private Form myParent;
        double savingsBal = 0.0;
        double checkingsBal = 0.0;
        double investmentsBal = 0.0;

        public Form3(Form myParent, bool loggedin) {
            InitializeComponent();
            bool login = loggedin;
            this.myParent = myParent;
            
            //var property = new SettingsProperty(Settings.Default.Properties["<baseSetting>"]);
            //Settings.Default.Properties.Add(property);

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = myParent;
            f1.Show();
            this.Hide();
        }

        private void savingsbalance_Click(object sender, EventArgs e) {

        }

        private void Form3_VisibleChanged(object sender, EventArgs e) {
            savingsbalance.Text = "Savings Account Balance: " + savingsBal;
            checkingsbalance.Text = "Checking Account Balance: " + checkingsBal;
            investmentsbalance.Text = "Investment Account Balance: " + investmentsBal;
        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e) {
            savingsbalance.Text = "Savings Account Balance $" + Properties.Settings.Default.Savings;
            checkingsbalance.Text = "Checking Account Balance $" + Properties.Settings.Default.Checking;
            investmentsbalance.Text = "Investments Account Balance $" + Properties.Settings.Default.Investments;
            if (Properties.Settings.Default.SavingsTrans.Count < 5) {
                L1.Items.Add("Add at least 5 transactions to the account");   
            }
            else {
                for (int i = 1; i < 2; i++) { 
                    L1.Items.Add(Properties.Settings.Default.SavingsTrans[Properties.Settings.Default.SavingsTrans.Count - i]);
                }
            }

            if (Properties.Settings.Default.CheckingTrans.Count < 5) { 
                L2.Items.Add("Add at least 5 transactions to the account");
            }
            else{     
                for (int i = 1; i < 2; i++) { 
                        L2.Items.Add(Properties.Settings.Default.CheckingTrans[Properties.Settings.Default.CheckingTrans.Count - i]);
                        }
            if (Properties.Settings.Default.InvestmentsTrans.Count < 5)
            {
                L3.Items.Add("Add at least 5 transactions to the account");
            }
            else
            {

                for (int i = 1; i < 2; i++)
                {
                    L3.Items.Add(Properties.Settings.Default.InvestmentsTrans[Properties.Settings.Default.InvestmentsTrans.Count - i]);
                }
            }
        }

           
        }

        private void L1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void L2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}


