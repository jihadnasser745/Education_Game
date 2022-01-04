using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace projet_info_II
{
    public partial class show : Form
    {
        public show(int n)
        {
            InitializeComponent();
            label1.Text = n.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value > 99)
            {
                timer1.Stop();
                if (label1.Text == "1")
                {
                    Game g = new Game();
                    g.Show();
                    Close();
                }
                if(label1.Text == "2")
                {
                    confbdpqserie cbd = new confbdpqserie(1);
                    cbd.Show();
                    Close();
                }
                if (label1.Text == "3")
                {
                    confbdpqserie cbd = new confbdpqserie(2);
                    cbd.Show();
                    Close();
                }
                if (label1.Text == "4")
                {
                    confbdpqserie cbd = new confbdpqserie(3);
                    cbd.Show();
                    Close();
                }
                if (label1.Text == "5")
                {
                    confbdpqserie cbd = new confbdpqserie(4);
                    cbd.Show();
                    Close();
                }
                if (label1.Text == "6")
                {
                    confbdpqserie cbd = new confbdpqserie(5);
                    cbd.Show();
                    Close();
                }
                if (label1.Text == "7")
                {
                    confbdpqserie cbd = new confbdpqserie(6);
                    cbd.Show();
                    Close();
                }
                if (label1.Text == "8")
                {
                    confbdpqserie cbd = new confbdpqserie(7);
                    cbd.Show();
                    Close();
                }
                if (label1.Text == "9")
                {
                    comporale co = new comporale();
                    co.Show();
                    Close();
                }
                if (label1.Text == "10")
                {
                    lect_son_a ls = new lect_son_a();
                    ls.Show();
                    Close();
                }
                if (label1.Text == "11")
                {
                    grammaire g = new grammaire();
                    g.Show();
                    Close();
                }
                if (label1.Text == "12")
                {
                    orthographe_er_é oere = new orthographe_er_é();
                    oere.Show();
                    Close();
                }
                if (label1.Text == "13")
                {
                    homophone_et_est hee = new homophone_et_est();
                    hee.Show();
                    Close();
                }
                if (label1.Text == "14")
                {
                    Process.Start("JeDEveile.exe");
                    Close();
                }
            }
        }

        private void show_Load(object sender, EventArgs e)
        {
            //progressBar1.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
