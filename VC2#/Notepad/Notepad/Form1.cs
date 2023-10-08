using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fiileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "open";
            dlg.ShowDialog();
            string fname = dlg.FileName;
            StreamReader sr = new StreamReader(fname);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg2 = new SaveFileDialog();
            dlg2.ShowDialog();
            string fname = dlg2.FileName;
            StreamWriter sw = new StreamWriter(fname);
            sw.Write(richTextBox1.Text);
            sw.Flush();
            sw.Close();


        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }

        }

        private void coloursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color=richTextBox1.SelectionColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }

        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey its Karanveer");
        }
    }
}
