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
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Text = ((int.Parse(textBox2.Text)) + 1) % 60).ToString();
                if (textBox2.ToString() == "0")
                {
                    textBox1.Text = ((int.Parse(textBox1.Text)) + 1) % 60).ToString();
                    if (textBox1.Text.ToString() == "1")
                    {
                        timer1.Enabled = false;

                    }
                }
            }
            if (radioButton2.Checked)
            {
                textBox2.Text = ((int.Parse(textBox2.Text)) + 1) % 60).ToString();
                if (textBox2.ToString() == "0")
                {
                    textBox1.Text = ((int.Parse(textBox1.Text)) + 1) % 60)).ToString();
                    if (textBox1.Text.ToString() = "2")
                    {
                        timer1.Enabled = false;

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString()="2")
            {
                Console.WriteLine("congratulations");
            }
        }
    }
}
