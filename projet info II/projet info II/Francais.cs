using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_info_II
{
    public partial class Francais : Form
    {
        public Francais()
        {
            InitializeComponent();
        }

        private void Francais_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            show s = new show(9);
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            show s = new show(10);
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show s = new show(11);
            s.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            show s = new show(12);
            s.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show s = new show(13);
            s.Show();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dictee d = new dictee();
            d.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            Game g = new Game();
            g.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
            registration r = new registration();
            r.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            confson cs = new confson();
            cs.Show();
            Close();
        }
        registration r1 = new registration();
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            r1.pictureBox3_Click(pictureBox11, e);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            r1.pictureBox4_Click(pictureBox10, e);
        }
    }
}
