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
            string name = textBox1.Text;
            string mail = textBox2.Text;
            string password = textbox1.Text;
            string unknown = textBox4.Text;
            InitializeComponent();
            this.myParent = myParent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
