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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int trans_amt = int.Parse(textBox2.Text);
            Form2.trans[Form2.trans_no++] = trans_amt;
            if (trans_amt > Form1.bal)
            {
                MessageBox.Show("No enough Balance");

            }
            else
            {
                Form1.bal = Form1.bal - trans_amt;
                MessageBox.Show("Amount transferred to " + textBox1.Text + " new balance is" + Form1.bal.ToString());
            }
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
             
        }
    }
}
