using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gen;
            gen = "";
            gen += textBox1.Text;
            if (radioButton1.Checked)
            {
                gen += " ,male from ";
            }
            else if(radioButton2.Checked){
                gen += " ,female from ";
            }
            gen += comboBox1.SelectedItem;
            if (checkBox1.Checked)
            {
                gen += " has done college";
            }
            if (checkBox2.Checked)
            {
                gen += " has done school";
            }
            DateTime iDate;
            
            gen += " Dob: " + dateTimePicker2.Value; ;
            MessageBox.Show(gen);

        }
    }
}
