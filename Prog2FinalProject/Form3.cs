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

            for (int i = 0; i < 6; i++) {
                L1.Items.Add(Properties.Settings.Default.SavingsTrans[Properties.Settings.Default.SavingsTrans.Count-i]);
                L2.Items.Add(Properties.Settings.Default.CheckingTrans[Properties.Settings.Default.SavingsTrans.Count-i]);
                L3.Items.Add(Properties.Settings.Default.InvestmentsTrans[Properties.Settings.Default.SavingsTrans.Count-i]);

            }
        }
    }
}
