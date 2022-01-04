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
    public partial class Logique : Form
    {
        public Logique()
        {
            InitializeComponent();
        }

        private void Logique_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Game g = new Game();
            g.Show();
            Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            registration r = new registration();
            r.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matching.Form1 f = new matching.Form1();
            f.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shadowss.Form2 f2 = new shadowss.Form2();
            f2.Show();
            Close();
        }
    }
}
