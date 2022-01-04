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
    public partial class confbdpq_serie2 : Form
    {
        int i;
        int[] t = new int[10];
        private SoundPlayer _sound0, _sound1, _sound2;
        int j = 1;
        private void reponce1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "Confbdpq_serie2", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confbdpq_serie2.xml");
                if (reponce1.Text == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()))
                {
                    pictureBox3.Visible = true;
                    _sound1.Play();
                    note.m++;
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    suivant.Visible = true;
                }
                else
                {
                    pictureBox4.Visible = true;
                    _sound2.Play();
                    reponce1.Visible = false;
                    reponce2.Visible = false;
                    suivant.Visible = true;
                }
            }
        }

        private void reponce2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "Confbdpq", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confbdpq_serie2.xml");
                if (reponce2.Text == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()))
                {
                    pictureBox3.Visible = true;
                    note.m++;
                    suivant.Visible = true;
                }
                else
                {
                    pictureBox4.Visible = true;
                    suivant.Visible = true;
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            registration r = new registration();
            r.Show();
            _sound0.Stop();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
this.Close();
            confson cs = new confson();
            cs.Show();
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

        private void suivant_Click_1(object sender, EventArgs e)
        {
                reponce1.Visible = true;
                reponce2.Visible = true;
                _sound1.Stop();
                _sound2.Stop();
                label5.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                i = t[j];
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confbdpq_serie2.xml");
                label2.Text = xml.DeChiffrer(dr[0]["label"].ToString());
                label5.Text = xml.DeChiffrer(dr[0]["nomcorrecte"].ToString());
                reponce1.Text = xml.DeChiffrer(dr[0]["name1"].ToString());
                reponce2.Text = xml.DeChiffrer(dr[0]["name2"].ToString());
                string s = i.ToString() + ".jpg";
                pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\picconfbdpqserie2\" + s);
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
                    label3.Text = note.m.ToString() + "/10";
                    label3.Visible = true;
                    if (note.m > 5)
                    {
                        label4.Text = "BRAVOOO";
                        label4.Visible = true;
                        pictureBox5.Visible = true;
                        _sound0.Play();
                        xml.notes(note.m, 4);
                    }
                    else
                    {
                        label4.Text = "Mal";
                        label4.Visible = true;
                        xml.notes(note.m, 4);
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

        private void confbdpq_serie2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label6.Text = xml.DonnerScore();
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confbdpq_serie2.xml");
            label2.Text = xml.DeChiffrer(dr[0]["label"].ToString());
            label5.Text = xml.DeChiffrer(dr[0]["nomcorrecte"].ToString());
            reponce1.Text = xml.DeChiffrer(dr[0]["name1"].ToString());
            reponce2.Text = xml.DeChiffrer(dr[0]["name2"].ToString());
            string s = i.ToString() + ".jpg";
            pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\picconfbdpqserie2\" + s);
            suivant.Visible = false;
        }

        public confbdpq_serie2()
        {
            InitializeComponent();
            _sound0 = new SoundPlayer("fettech.wav");
            _sound1 = new SoundPlayer("tasfik.wav");
            _sound2 = new SoundPlayer("fechel.wav");
            t = fonctions.randomdiff(10, 11);
            i = t[0];
            note.m = 1;
            var list = SpeechHelper.GetAllInstalledVoices();
        }
    }
}
