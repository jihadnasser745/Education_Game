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
using notes;
using System.Media;

namespace projet_info_II
{
    public partial class homophone_et_est : Form
    {
        int i, f = -1;
        int[] t = new int[11];
        private SoundPlayer _sound0, _sound1, _sound2;
        public homophone_et_est()
        {
            InitializeComponent();
            t = fonctions.randomdiff(11,21);
            i = t[0];
            _sound0 = new SoundPlayer("fettech.wav");
            _sound1 = new SoundPlayer("tasfik.wav");
            _sound2 = new SoundPlayer("fechel.wav");
        }

        private void reponce2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "homophone_et_est", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "homophone_et_est1.xml");
                label1.Text = xml.DeChiffrer(dr[0]["name2"].ToString());
                if (xml.DeChiffrer(dr[0]["name2"].ToString()).ToUpper() == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()).ToUpper())
                {
                    note.homo++;
                    f++;
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    checkedListBox1.SetItemChecked(f, true);
                    pictureBox1.Visible = true;
                    _sound1.Play();
                }
                else
                {
                    f++;
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    pictureBox3.Visible = true;
                    _sound2.Play();
                }
            }
        }
        int j = 1;

        private void homophone_et_est_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            label2.Text = xml.DonnerScore();
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "homophone_et_est1.xml");
            label1.Text = xml.DeChiffrer(dr[0]["label"].ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Francais fr = new Francais();
            fr.Show();
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
            try {reponce1.Visible = true;
            reponce2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            _sound0.Stop();
            _sound1.Stop();
            _sound2.Stop();
            i = t[j];
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "homophone_et_est1.xml");
            label1.Text = xml.DeChiffrer(dr[0]["label"].ToString());
            suivant.Visible = false;
            if (j < 10) j++;
            else
            {
                suivant.Visible = false;
                label5.Text = note.homo.ToString() + "/10";
                label5.Visible = true;
                if (note.homo > 5)
                {
                    label6.Text = "BRAVOOO";
                    xml.notes(note.homo, 16);
                    label6.Visible = true;
                    _sound0.Play();
                    pictureBox4.Visible = true;
                }
                else
                {
                    label6.Text = "Mal";
                    xml.notes(note.homo, 16);
                    label6.Visible = true;
                }
            } }
            catch(Exception ex)
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

        private void reponce1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "homophone_et_est", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "homophone_et_est1.xml");
                label1.Text = xml.DeChiffrer(dr[0]["name1"].ToString());
                if (xml.DeChiffrer(dr[0]["name1"].ToString()).ToUpper() == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()).ToUpper())
                {
                    note.homo++;
                    f++;
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    checkedListBox1.SetItemChecked(f, true);
                    pictureBox1.Visible = true;
                    _sound1.Play();
                }
                else
                {
                    f++;
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    pictureBox3.Visible = true;
                    _sound2.Play();
                }
            }
        }
    }
}
