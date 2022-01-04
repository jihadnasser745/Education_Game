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
    public partial class confdt : Form
    {
        int i;
        int[] t = new int[10];
        private SoundPlayer _sound0,_sound1,_sound2;
        public confdt()
        {
            InitializeComponent();
            _sound0 = new SoundPlayer("fettech.wav");
            _sound1 = new SoundPlayer("tasfik.wav");
            _sound2 = new SoundPlayer("fechel.wav");
            t = fonctions.randomdiff(10, 11);
            i = t[0];
            note.d = 1;
            var list = SpeechHelper.GetAllInstalledVoices();
        }

        private void confdt_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label6.Text = xml.DonnerScore();
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confdt.xml");
            label2.Text = xml.DeChiffrer(dr[0]["label"].ToString());
            label5.Text = xml.DeChiffrer(dr[0]["nomcorrecte"].ToString());
            string s = i.ToString() + ".jpeg";
            pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\picconfdt\" + s);
            suivant.Visible = false;
        }

        private void reponce1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "Confdt", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confdt.xml");
                label2.Text = xml.DeChiffrer(dr[0]["name1"].ToString());
                if (xml.DeChiffrer(dr[0]["name1"].ToString()).ToUpper() == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()).ToUpper())
                {
                    pictureBox3.Visible = true;
                    _sound1.Play();
                    note.d++;
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

        private void reponce2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Est ce que tu es sure??", "Confdt", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confdt.xml");
                label2.Text = xml.DeChiffrer(dr[0]["name2"].ToString());
                if (xml.DeChiffrer(dr[0]["name2"].ToString()).ToUpper() == xml.DeChiffrer(dr[0]["nomcorrecte"].ToString()).ToUpper())
                {
                    pictureBox3.Visible = true;
                    _sound1.Play();
                    note.d++;
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
        int j = 1;
        private void suivant_Click(object sender, EventArgs e)
        {
reponce1.Visible = true;
            reponce2.Visible = true;
            label5.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            _sound1.Stop();
            _sound2.Stop();
            i = t[j];
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "confdt.xml");
            label2.Text = xml.DeChiffrer(dr[0]["label"].ToString());
            label5.Text = xml.DeChiffrer(dr[0]["nomcorrecte"].ToString());
            string s = i.ToString() + ".jpeg";
            pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\picconfdt\" + s);
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
                label3.Text = note.d.ToString() + "/10";
                label3.Visible = true;
                if (note.d > 5)
                {
                    label4.Text = "BRAVOOO";
                    label4.Visible = true;
                    pictureBox5.Visible = true;
                    _sound0.Play();
                    xml.notes((note.d) , 9);
                }
                else
                {
                    label4.Text = "Mal";
                    label4.Visible = true;
                    xml.notes((note.d), 9);
                }
            } 
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
            registration r = new registration();
            r.Show();
            Close();
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

        private void sound_CheckedChanged(object sender, EventArgs e)
        {
            SpeechHelper.Rate = 0;
            string error = SpeechHelper.Speak("fr-FR", "Microsoft Hortense Desktop", label5.Text);
            if (error != null)
            {
                MessageBox.Show(error);
            }
        }
    }
}

