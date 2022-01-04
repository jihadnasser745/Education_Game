using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using xmlfile;
using count;
using notes;
using DarrenLee.SpeechSynthesis;

namespace projet_info_II
{
    public partial class confchsss_serie2 : Form
    {
        int i;
        int[] t = new int[10];
        private SoundPlayer _sound0, _sound1, _sound2;

        private void reponce1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "Confchsss_serie2", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confchsss_serie2.xml");
                if (reponce1.Text == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()))
                {
                    pictureBox3.Visible = true;
                    _sound1.Play();
                    note.c++;
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    reponce3.Visible = false;
                }
                else
                {
                    pictureBox4.Visible = true;
                    _sound2.Play();
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    reponce3.Visible = false;
                }
            }
        }

        private void reponce2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "Confchsss_serie2", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confchsss_serie2.xml");
                if (reponce2.Text == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()))
                {
                    pictureBox3.Visible = true;
                    _sound1.Play();
                    note.c++;
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    reponce3.Visible = false;
                }
                else
                {
                    pictureBox4.Visible = true;
                    _sound2.Play();
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    reponce3.Visible = false;
                }
            }
        }

        private void reponce3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "Confchsss_serie2", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confchsss_serie2.xml");
                if (reponce3.Text == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()))
                {
                    pictureBox3.Visible = true;
                    _sound1.Play();
                    note.c++;
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    reponce3.Visible = false;
                }
                else
                {
                    pictureBox4.Visible = true;
                    _sound2.Play();
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    reponce3.Visible = false;
                }
            }
        }
        int j = 1;
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
Close();
            confson cs = new confson();
            cs.Show();
            _sound0.Stop();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
 Close();
            registration r = new registration();
            r.Show();
            _sound0.Stop();
        }

        private void sound_Click(object sender, EventArgs e)
        {
            SpeechHelper.Rate = 0;
            string error = SpeechHelper.Speak("fr-FR", "Microsoft Hortense Desktop", label5.Text);
            if (error != null)
            {
                MessageBox.Show(error);
            }
        }

        private void suivant_Click(object sender, EventArgs e)
        {
i = t[j];
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            _sound1.Stop();
            _sound2.Stop();
            reponce1.Visible = true;
            reponce2.Visible = true;
            reponce3.Visible = true;
            label5.Visible = false;
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confchsss_serie2.xml");
            label2.Text = xml.DeChiffrer(dr[0]["label"].ToString());
            label5.Text = xml.DeChiffrer(dr[0]["nomcorrecte"].ToString());
            reponce1.Text = xml.DeChiffrer(dr[0]["name1"].ToString());
            reponce2.Text = xml.DeChiffrer(dr[0]["name2"].ToString());
            reponce3.Text = xml.DeChiffrer(dr[0]["name3"].ToString());
            string s = i.ToString() + ".jpg";
            pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\picconfchsss_serie2\" + s);
            suivant.Visible = false;
            if (j < 9) j++;
            else
            {
                pictureBox1.Visible = false;
                reponce1.Visible = false;
                reponce2.Visible = false;
                reponce3.Visible = false;
                sound.Visible = false;
                suivant.Visible = false;
                label2.Visible = false;
                label3.Text = note.c.ToString() + "/10";
                label3.Visible = true;
                if (note.c > 5)
                {
                    label4.Text = "BRAVOOO";
                    label4.Visible = true;
                    pictureBox5.Visible = true;
                    _sound0.Play();
                    xml.notes(note.c, 5);
                }
                else
                {
                    label4.Text = "Mal";
                    label4.Visible = true;
                    xml.notes(note.c, 5);
                }
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

        private void confchsss_serie2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label6.Text = xml.DonnerScore();
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confchsss_serie2.xml");
            label2.Text = xml.DeChiffrer(dr[0]["label"].ToString());
            label5.Text = xml.DeChiffrer(dr[0]["nomcorrecte"].ToString());
            reponce1.Text = xml.DeChiffrer(dr[0]["name1"].ToString());
            reponce2.Text = xml.DeChiffrer(dr[0]["name2"].ToString());
            reponce3.Text = xml.DeChiffrer(dr[0]["name3"].ToString());
            string s = i.ToString() + ".jpg";
            pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\picconfchsss_serie2\" + s);
            suivant.Visible = false;
        }

        public confchsss_serie2()
        {
            InitializeComponent();
            _sound0 = new SoundPlayer("fettech.wav");
            _sound1 = new SoundPlayer("tasfik.wav");
            _sound2 = new SoundPlayer("fechel.wav");
            t = fonctions.randomdiff(10, 11);
            i = t[0];
            note.c = 1;
            var list = SpeechHelper.GetAllInstalledVoices();
        }
    }
}
