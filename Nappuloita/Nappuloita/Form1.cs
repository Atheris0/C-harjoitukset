using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nappuloita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "2";
        }
    }
}
