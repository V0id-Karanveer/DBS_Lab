using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        string Operator = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input += "1";
            textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input += "2";
            textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input += "3";
            textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input += "4";
            textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            op1 = input;
            input = string.Empty;
            Operator = "+";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            op1 = input;
            input = string.Empty;
            Operator = "n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            op2 = input;
            double n1, n2;
            double.TryParse(op1, out n1);
            double.TryParse(op2, out n2);
            double res;
            if (Operator == "+")
            {
                res = n1 + n2;
                textBox1.Text = res.ToString();
            }
            if (Operator == "n")
            {
                res = Math.Pow(n1, n2);
                textBox1.Text = res.ToString();
            }





        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = string.Empty;
            Operator = string.Empty;
            op1 = string.Empty;
            op2 = string.Empty;
        }
        

    }
}
