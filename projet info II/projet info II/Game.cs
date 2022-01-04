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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        private void Game_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label2.Text = xmlfile.xml.DonnerScore();
        }

        private void francais_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Francais", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Francais f = new Francais();
                f.Show();
                this.Close();
            }
        }

        private void maths_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
               WindowsFormsApp13.math f = new WindowsFormsApp13.math();
                f.Show();
                Close();
            }
        }

        private void logique_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Logique l = new Logique();
                l.Show();
                Close();
            }
        }

        private void geom_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

            }
        }

        private void jeusdeveile_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                show s = new show(14);
                s.Show();
                Close();
            }
        }

        private void autres_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu veux jouer?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                challange_mode.Form1 f = new challange_mode.Form1();
                f.Show();
                Close();
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
            registration r1 = new registration();
            r1.Show();
        }
        registration r = new registration();
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            r.pictureBox3_Click(pictureBox9, e);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            r.pictureBox4_Click(pictureBox8, e);
        }
    }
}
