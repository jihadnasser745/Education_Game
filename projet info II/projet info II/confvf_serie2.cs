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
using DarrenLee.SpeechSynthesis;

namespace projet_info_II
{
    public partial class confvf_serie2 : Form
    {
        int i;
        int[] t = new int[10];
        private SoundPlayer _sound0, _sound1, _sound2;
        public confvf_serie2()
        {
            note.g = 1;
            InitializeComponent();
            _sound0 = new SoundPlayer("fettech.wav");
            _sound1 = new SoundPlayer("tasfik.wav");
            _sound2 = new SoundPlayer("fechel.wav");
            t = fonctions.randomdiff(10, 11);
            i = t[0];
            var list = SpeechHelper.GetAllInstalledVoices();
        }
        int j = 1;
        private void suivant_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            confson cf = new confson();
            cf.Show();
            _sound0.Stop();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            registration r = new registration();
            r.Show();
            _sound0.Stop();
        }

        private void reponce1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "Confvf_serie2", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confvf_serie2.xml");
                label2.Text = xml.DeChiffrer(dr[0]["name1"].ToString());
                if (xml.DeChiffrer(dr[0]["name1"].ToString()).ToUpper() == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()).ToUpper())
                {
                    pictureBox3.Visible = true;
                    _sound1.Play();
                    note.g++;
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                }
                else
                {
                    pictureBox4.Visible = true;
                    _sound2.Play();
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                }
            }
        }

        private void reponce2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "Confvf_serie2", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confvf_serie2.xml");
                label2.Text = xml.DeChiffrer(dr[0]["name2"].ToString());
                if (xml.DeChiffrer(dr[0]["name2"].ToString()).ToUpper() == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()).ToUpper())
                {
                    pictureBox3.Visible = true;
                    _sound1.Play();
                    note.g++;
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                }
                else
                {
                    pictureBox4.Visible = true;
                    _sound2.Play();
                    suivant.Visible = true;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                }
            }
        }

        private void suivant_Click_1(object sender, EventArgs e)
        {
reponce1.Visible = true;
            reponce2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            _sound1.Stop();
            _sound2.Stop();
            i = t[j];
            this.WindowState = FormWindowState.Maximized;
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confvf_serie2.xml");
            label2.Text = xml.DeChiffrer(dr[0]["label"].ToString());
            label5.Text = xml.DeChiffrer(dr[0]["nomcorrecte"].ToString());
            string s = i.ToString() + ".jpg";
            pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\picconfvf_serie2\" + s);
            suivant.Visible = false;
            if (j < 9) j++;
            else
            {
                pictureBox1.Visible = false;
                reponce1.Visible = false;
                reponce2.Visible = false;
                sound.Visible = false;
                suivant.Visible = false;
                label2.Visible = false;
                label3.Text = note.g.ToString() + "/10";
                label3.Visible = true;
                if (note.g > 5)
                {
                    label4.Text = "BRAVOOO";
                    label4.Visible = true;
                    pictureBox5.Visible = true;
                    _sound0.Play();
                    xml.notes((note.g), 4);
                }
                else
                {
                    label4.Text = "Mal";
                    label4.Visible = true;
                    xml.notes((note.g), 4);
                }
            }
        }
        registration r1 = new registration();
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            r1.pictureBox3_Click(pictureBox8, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            r1.pictureBox4_Click(pictureBox2, e);
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

        private void confvf_serie2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label6.Text = xml.DonnerScore();
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confvf_serie2.xml");
            label2.Text = xml.DeChiffrer(dr[0]["label"].ToString());
            label5.Text = xml.DeChiffrer(dr[0]["nomcorrecte"].ToString());
            string s = i.ToString() + ".jpg";
            pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\picconfvf_serie2\" + s);
            suivant.Visible = false;
        }
    }
}
