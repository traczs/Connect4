using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Connect_4
{
    public partial class Form1 : Form
    {
        string x;
        string y;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = textBox1.Text;
            y = textBox2.Text;
            Form game = new Form2(x, y);
            game.Show();
            this.Hide();
        }
    }
}
