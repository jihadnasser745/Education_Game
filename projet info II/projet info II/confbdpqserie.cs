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
    public partial class confbdpqserie : Form 
    {
        public confbdpqserie(int n)
        {
            InitializeComponent();
            label1.Text = n.ToString();
        }

        private void confbdpqserie_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                confbdpq bdpq = new confbdpq();
                bdpq.Show();
                Close();
            }
            if (label1.Text == "2")
            {
                confch_s_ss chs = new confch_s_ss();
                chs.Show();
                Close();
            }
            if (label1.Text == "3")
            {
                confbp b = new confbp();
                b.Show();
                Close();
            }
            if (label1.Text == "4")
            {
                confcg cg = new confcg();
                cg.Show();
                Close();
            }

            if (label1.Text == "5")
            {
                confgch gch = new confgch();
                gch.Show();
                Close();
            }
            if (label1.Text == "6")
            {
                confdt dt = new confdt();
                dt.Show();
                Close();
            }
            if (label1.Text == "7")
            {
                confvf vf = new confvf();
                vf.Show();
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                confbdpq_serie2 bdpq2 = new confbdpq_serie2();
                bdpq2.Show();
                Close();
            }
            if (label1.Text == "2")
            {
                confchsss_serie2 chs = new confchsss_serie2();
                chs.Show();
                Close();
            }
            if (label1.Text == "3")
            {
                confbpserie2 b = new confbpserie2();
                b.Show();
                Close();
            }
            if (label1.Text == "4")
            {
                confcg_serie2 cg = new confcg_serie2();//
                cg.Show();
                Close();
            }

            if (label1.Text == "5")
            {
                confgch_serie2 gch = new confgch_serie2();//
                gch.Show();
                Close();
            }
            if (label1.Text == "6")
            {
                confdt_serie2 dt = new confdt_serie2();
                dt.Show();
                Close();
            }
            if (label1.Text == "7")
            {
                confvf_serie2 vf = new confvf_serie2();//
                vf.Show();
                Close();
            }
        }
        registration r1 = new registration();
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            r1.pictureBox3_Click(pictureBox7, e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            r1.pictureBox4_Click(pictureBox6, e);
        }
    }
}
