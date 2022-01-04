using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using count;
using xmlfile;
using DarrenLee.SpeechSynthesis;
using System.Media;

namespace projet_info_II
{
    public partial class dictee : Form
    {
        //private SoundPlayer  _sound1;
        public dictee()
        {
            InitializeComponent();
           // _sound1 = new SoundPlayer("tasfik.wav");
        }
        string s;
        Random r = new Random();
        private void dictee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label2.Text = xml.DonnerScore();
            suivant.Visible = false;
            int i = r.Next(1, 36);
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "dictee.xml");
            s = xml.DeChiffrer(dr[0]["phrase"].ToString());
        }

        private void suivant_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            suivant.Visible = false;
            textBox1.Clear();
            int i = r.Next(1, 36);
            DataRow[] dr = xml.xmlsearch("[ID] = '" + i.ToString() + "'", "dictee.xml");
            s = xml.DeChiffrer(dr[0]["phrase"].ToString());
            pictureBox5.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] t1 = s.ToUpper().Split(' ');
            string[] t2 = textBox1.Text.ToUpper().Split(' ');
            for (int j = 0; j < t1.Length; j++)
            {
                try
                {
                    if (t1.Length == t2.Length)
                        if (t1[j] != t2[j])
                        {
                            MessageBox.Show("\"" + t2[j] + "\"" + " est faut !! , le correction est \"" + t1[j] + "\"");
                            //textBox1.Text = "\"" + t2[j] + "\"" + " est faut !! , le correction est \"" + t1[j] + "\"";
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tu as manqué des mots la correction est " + s);
                }

            }
            pictureBox1.Visible = false;
            suivant.Visible = true;
        }

        private void sound_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SpeechHelper.Rate = 0;
            string error = SpeechHelper.Speak("fr-FR", "Microsoft Hortense Desktop", s);
            if (error != null)
            {
                MessageBox.Show(error);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
            Francais fr = new Francais();
            fr.Show();
            //_sound1.Stop();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
            registration r = new registration();
            r.Show();
            //_sound1.Stop();
        }
        registration r1 = new registration();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            r1.pictureBox3_Click(pictureBox3, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            r1.pictureBox4_Click(pictureBox2, e);
        }
    }
}
