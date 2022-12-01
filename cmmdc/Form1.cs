using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cmmdc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, m, rest;

            n = int.Parse(textBox1.Text);
            m = int.Parse(textBox2.Text);

            while (m>0)
            {
                rest = n % m;
                n = m;
                m = rest;
            }
            textBox3.Text += "\r\n cmmdc = \r\n";
            textBox3.Text += n.ToString();
        }
    }
}
