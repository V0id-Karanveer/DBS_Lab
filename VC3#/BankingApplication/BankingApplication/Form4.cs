using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form1.pass && textBox2.Text == textBox3.Text)
            {
                Form1.pass = textBox2.Text;
                MessageBox.Show("Password changed to " + Form1.pass);
                this.Hide();
            }
            else{
                MessageBox.Show("Check old Password or Check if both new passwords are equal");
            }
        }
    }
}
