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
using count;
using System.Media;
using notes;

namespace projet_info_II
{
    public partial class grammaire : Form
    {
        int i, c = 1,j=1;
        int[] t = new int[15];
        private SoundPlayer _sound0, _sound1, _sound2;
        public grammaire()
        {
            InitializeComponent();
            t = fonctions.randomdiff(15,43);
            i = t[0];
            _sound0 = new SoundPlayer("fettech.wav");
            _sound1 = new SoundPlayer("tasfik.wav");
            _sound2 = new SoundPlayer("fechel.wav");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Francais f = new Francais();
            f.Show();
            this.Close();
            _sound0.Stop();
            _sound1.Stop();
            _sound2.Stop();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            registration r = new registration();
            r.Show();
            _sound0.Stop();
            _sound1.Stop();
            _sound2.Stop();
        }

        private void suivant_Click_1(object sender, EventArgs e)
        {
            try
            {
pictureBox1.Visible = true;
            i = t[j];
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "conjugaison.xml");
            label1.Text = xml.DeChiffrer(dr[0]["sujets"].ToString());
            label2.Text = xml.DeChiffrer(dr[0]["verbes"].ToString());
            textBox1.Clear();
            if (j < 14) j++;
            else
            {
                label3.Text = c.ToString() + "/15";
                label3.Visible = true;
                if (note.gramm > 8)
                {
                    label4.Text = "BRAVOOO";
                    xml.notes(note.gramm, 14);
                    label4.Visible = true;
                    panel1.Visible = false;
                    _sound0.Play();
                }
                else
                {
                    label4.Text = "Mal";
                    xml.notes(note.gramm, 14);
                    panel1.Visible = false;
                    label4.Visible = true;
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "tu peut retouner (Back) et commencer de nouveau");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "conjugaison.xml");
            if (textBox1.Text == xml.DeChiffrer(dr[0]["conjugaison"].ToString()))
            {
                note.gramm++;
                pictureBox1.Visible = false;
                suivant.Visible = true;
                pictureBox4.Visible = true;//emojie
            }
            else
            {
                pictureBox1.Visible = false;
                suivant.Visible = true;
                pictureBox3.Visible = true;//emojie
            }
        }

        private void grammaire_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label6.Text = xml.DonnerScore();
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "conjugaison.xml");
            label1.Text = xml.DeChiffrer(dr[0]["sujets"].ToString());
            label2.Text = xml.DeChiffrer(dr[0]["verbes"].ToString());
            label3.Visible = false;
            label4.Visible = false;
            suivant.Visible = false;
        }
    }
}
