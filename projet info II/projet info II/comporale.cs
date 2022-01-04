using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using count;
using xmlfile;
using notes;
using DarrenLee.SpeechSynthesis;

namespace projet_info_II
{
    public partial class comporale : Form
    {
        public comporale()
        {
            InitializeComponent();
            var list = SpeechHelper.GetAllInstalledVoices();
        }
        private void comporale_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Text = xml.DonnerScore();
            timer1.Stop();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reponce1.Checked)
            {
                MessageBox.Show("BRAVO!!");
                panel1.Visible = false;
                panel2.Visible = true;
                note.co++;
            }
            else
            {
                MessageBox.Show("FAUSSE!!");
                panel1.Visible = false;
                panel2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reponce5.Checked)
            {
                MessageBox.Show("BRAVO!!");
                panel2.Visible = false;
                panel3.Visible = true;
                note.co++;
            }
            else
            {
                MessageBox.Show("FAUSSE!!");
                panel2.Visible = false;
                panel3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reponce9.Checked)
            {
                MessageBox.Show("BRAVO!!");
                panel3.Visible = false;
                panel4.Visible = true;
                note.co++;
            }
            else
            {
                MessageBox.Show("FAUSSE!!");
                panel3.Visible = false;
                panel4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (reponce10.Checked)
            {
                MessageBox.Show("BRAVO!!");
                panel4.Visible = false;
                panel5.Visible = true;
                note.co++;
            }
            else
            {
                MessageBox.Show("FAUSSE!!");
                panel4.Visible = false;
                panel5.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (reponce13.Checked)
            {
                MessageBox.Show("BRAVO!!");
                panel5.Visible = false;
                panel6.Visible = true;
                note.co++;
            }
            else
            {
                MessageBox.Show("FAUSSE!!");
                panel5.Visible = false;
                panel6.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)//baddi 7at lscore bi button aw aya chi byezhar hon l i 3edded la lsa7
        {
            if (reponce17.Checked)
            {
                MessageBox.Show("BRAVO!!");
                panel6.Visible = false;
                note.co++;
                label2.Text = note.co.ToString() + "/6";
                label2.Visible = true;
                if (note.co >= 3)
                {
                    label3.Text = "Exellant!!";
                    xml.notes((note.co), 5);
                    label3.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("FAUSSE!!");
                panel6.Visible = false;
                label2.Text = note.co.ToString() + "/6";
                label2.Visible = true;
                if (note.co < 3)
                {
                    label3.Text = "Mal!!";
                    xml.notes((note.co), 5);
                    label3.Visible = true;
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            registration r = new registration();
            r.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            Francais fr = new Francais();
            fr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sound.Visible = true;
            panel1.Visible = true;
            timer1.Stop();
        }

        private void sound_Click(object sender, EventArgs e)
        {
            timer1.Start();
                DataRow[] d = xml.xmlsearch("[ID] = '" + 1.ToString() + "'", "Comporal.xml");
                string location = xml.DeChiffrer(d[0]["location"].ToString());
                StreamReader sr = new StreamReader(location + ".txt");
                string txtspeech = sr.ReadToEnd();
                SpeechHelper.Rate = 0;
                sound.Visible = false;
                string error = SpeechHelper.Speak("fr-FR", "Microsoft Hortense Desktop", txtspeech);
                if (error != null)
                {
                    MessageBox.Show(error);
                }
                sr.Close();
        }
        registration r1 = new registration();
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            r1.pictureBox3_Click(pictureBox9, e);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            r1.pictureBox4_Click(pictureBox8, e);
        }
    }
}
