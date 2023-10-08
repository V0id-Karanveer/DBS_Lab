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
    public partial class Form1 : Form
    {
        public static string user = "Karan";
        public static string pass = "1234";
        public static int bal = 10000;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == user && textBox2.Text == pass)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Creds");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
