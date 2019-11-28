using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingPrintHelper
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

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About acerca = new About();
            acerca.MdiParent = this;
            acerca.Show();
        }

        private void printHelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintHelper print = new PrintHelper();
            print.MdiParent = this;
            print.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2 print = new Form2();
            print.MdiParent = this;
            print.Show();
        }
    }
}
