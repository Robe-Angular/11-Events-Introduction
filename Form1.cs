using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Events_Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("button 1 key down");
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("button 2 key press");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked the form");
        }

        private void saySomething(object Sender, EventArgs e)
        {
            MessageBox.Show("Something");
        }

        private void saySomethingElse(object sender, EventArgs e)
        {
            MessageBox.Show("Something else");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(saySomething);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(saySomethingElse);
        }
    }

}
