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
    public partial class Form2 : Form
    {
        public static int[] trans = {0,0,0};
        public static int trans_no = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.user;
            label2.Text = Form1.bal.ToString();
            string result;
            for(int i=0;i<trans.Length;i++){
                result = trans[i].ToString();
                listView1.Items.Add(result);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            
            
        }
    }
}
