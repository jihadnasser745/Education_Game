using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xmlfile;

namespace projet_info_II
{
    public partial class confson : Form
    {
        public confson()
        {
            InitializeComponent();
        }

        private void confson_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label6.Text = xml.DonnerScore();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
            Francais f = new Francais();
            f.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
            registration r = new registration();
            r.Show();
        }
        registration r1 = new registration();
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            r1.pictureBox3_Click(pictureBox7, e);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            r1.pictureBox4_Click(pictureBox6, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Confbdpq", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                show s = new show(2);
                s.Show();
                Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Confusions ch-s/ss", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                show s = new show(3);
                s.Show();
                Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Confusions b-p", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                show s = new show(4);
                s.Show();
                Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Confusions c-g", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                show s = new show(5);
                s.Show();
                Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Confusions j-ch", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                show s = new show(6);
                s.Show();
                Close();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Confusions d-t", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                show s = new show(7);
                s.Show();
                Close();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Confusions v-f", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                show s = new show(8);
                s.Show();
                Close();
            }
        }
    }
}
