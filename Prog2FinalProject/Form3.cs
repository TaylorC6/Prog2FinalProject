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

        double savingsBal = 0.0;
        double checkingsBal = 0.0;
        double investmentsBal = 0.0;

        public Form3(bool loggedin) {
            InitializeComponent();
            bool login= loggedin
            
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
    }
}
