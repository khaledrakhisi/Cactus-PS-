using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cactus_PS_;

namespace thousands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n = textBox1.SelectionStart;
            textBox1.Text = numberConvertor.splitNumber(textBox1.Text.Replace(",", ""), false);
            textBox1.SelectionStart = n+1;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //textBox1.Text = numberConvertor.splitNumber(textBox1.Text.Replace(",", ""), false);
            //textBox1.SelectionStart = textBox1.Text.Length;            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textBox1.Text = numberConvertor.splitNumber(textBox1.Text.Replace(",", ""), false);
            //textBox1.SelectionStart = textBox1.Text.Length;            
        }
    }
}
