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
    public partial class lect_son_ou : Form
    {
        private SoundPlayer _sound0, _sound1, _sound2;
        public lect_son_ou()
        {
            InitializeComponent();
            var list = SpeechHelper.GetAllInstalledVoices();
            _sound0 = new SoundPlayer("fettech.wav");
            _sound1 = new SoundPlayer("tasfik.wav");
            _sound2 = new SoundPlayer("fechel.wav");
        }
        bool DragMode = false;
        Point InitialLocation1;
        private void lect_son_ou_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label17.Text = xml.DonnerScore();
            label5.Visible = false;
            label6.Visible = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (p.Parent.GetType().ToString().IndexOf("Panel") < 0)
                {
                    if (!DragMode)
                    {
                        InitialLocation1 = p.Location;
                        DragMode = true;
                        p.Left = (e.X + p.Left) - p.Width / 2;
                        p.Top = (e.Y + p.Top) - p.Height / 2;
                    }
                    if (Math.Abs(p.Left - (e.X - p.Width / 2)) > 5)
                        p.Left = (e.X + p.Left) - p.Width / 2;
                    if (Math.Abs(p.Top - (e.Y - p.Height / 2)) > 5)
                        p.Top = (e.Y + p.Top) - p.Height / 2;
                }
            }
        }
        int i = 0, j = 5, k = 5, l = 0;
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            SpeechHelper.Rate = 0;
            string error = SpeechHelper.Speak("fr-FR", "Microsoft Hortense Desktop", p.Name);
            if (error != null)
            {
                MessageBox.Show(error);
            }
            if (DragMode)
            {
                int RealX = e.X + p.Left;
                int RealY = e.Y + p.Top;
                if ((RealX > panel1.Left) && (RealX < panel1.Left + panel1.Width) && (RealY > panel1.Top) && (RealY < panel1.Top + panel1.Height))
                {
                    this.Controls.Remove(p);
                    panel1.Controls.Add(p);
                    p.Location = new Point(60 + j, 10 + i);
                    j = j + 60;
                    i = i + 30;
                }
                else if ((RealX > panel2.Left) && (RealX < panel2.Left + panel2.Width) && (RealY > panel2.Top) && (RealY < panel2.Top + panel2.Height))
                {
                    this.Controls.Remove(p);
                    panel2.Controls.Add(p);
                    p.Location = new Point(k, 5 + l);
                    k = k + 60;
                    l = l + 20;
                }
                else
                {
                    p.Location = InitialLocation1;
                }
                DragMode = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechHelper.Rate = 0;
            string error = SpeechHelper.Speak("fr-FR", "Microsoft Hortense Desktop", label2.Text);
            if (error != null)
            {
                MessageBox.Show(error);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Francais fr = new Francais();
            fr.Show();
            this.Close();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {

            this.Close();
            registration r = new registration();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Contains(mouche))
            {
                checkBox2.Checked = true;
                note.lectou++;
            }
            if (panel1.Contains(poussin))
            {
                checkBox3.Checked = true;
                note.lectou++;
            }
            if (panel1.Contains(bougie))
            {
                checkBox7.Checked = true;
                note.lectou++;
            }
            if (panel1.Contains(bouche))
            {
                checkBox9.Checked = true;
                note.lectou++;
            }
            if (panel2.Contains(vache))
            {
                checkBox1.Checked = true;
                note.lectou++;
            }
            if (panel2.Contains(cheval))
            {
                checkBox4.Checked = true;
                note.lectou++;
            }
            if (panel2.Contains(nuage))
            {
                checkBox6.Checked = true;
                note.lectou++;
            }
            if (panel2.Contains(chaussure))
            {
                checkBox5.Checked = true;
                note.lectou++;
            }
            if (panel2.Contains(etloile))
            {
                checkBox10.Checked = true;
                note.lectou++;
            }
            if (panel2.Contains(dragon))
            {
                checkBox8.Checked = true;
                note.lectou++;
            }
            if ((panel1.Contains(mouche)) && (panel1.Contains(poussin)) && (panel1.Contains(bougie)) && (panel1.Contains(bouche)) && (panel2.Contains(vache)) && (panel2.Contains(cheval)) && (panel2.Contains(nuage)) && (panel2.Contains(chaussure)) && (panel2.Contains(etloile))&&(panel2.Contains(dragon)))
            {
                MessageBox.Show("Bravooo!!");
            }
            else
            {
                if ((panel1.Contains(vache))) checkBox1.Checked = false;
                if ((panel2.Contains(mouche))) checkBox2.Checked = false;
                if ((panel2.Contains(poussin))) checkBox3.Checked = false;
                if ((panel1.Contains(cheval))) checkBox4.Checked = false;
                if ((panel1.Contains(chaussure))) checkBox5.Checked = false;
                if ((panel1.Contains(nuage))) checkBox6.Checked = false;
                if ((panel2.Contains(bougie))) checkBox7.Checked = false;
                if ((panel1.Contains(dragon))) checkBox8.Checked = false;
                if ((panel2.Contains(bouche))) checkBox9.Checked = false;
                if ((panel1.Contains(etloile))) checkBox10.Checked = false;
                panel1.Controls.Remove(vache);
                panel1.Controls.Remove(mouche);
                panel1.Controls.Remove(poussin);
                panel1.Controls.Remove(cheval);
                panel1.Controls.Remove(chaussure);
                panel1.Controls.Remove(nuage);
                panel1.Controls.Remove(bougie);
                panel1.Controls.Remove(dragon);
                panel1.Controls.Remove(bouche);
                panel1.Controls.Remove(etloile);
                panel2.Controls.Remove(vache);
                panel2.Controls.Remove(mouche);
                panel2.Controls.Remove(poussin);
                panel2.Controls.Remove(cheval);
                panel2.Controls.Remove(chaussure);
                panel2.Controls.Remove(nuage);
                panel2.Controls.Remove(bougie);
                panel2.Controls.Remove(dragon);
                panel2.Controls.Remove(bouche);
                panel2.Controls.Remove(etloile);
            }
            label5.Text = note.lectou.ToString() + "/10";
            label5.Visible = true;
            if (note.lectou > 5)
            {
                label6.Text = "good";
                xml.notes(( note.lectou), 13);
                label6.Visible = true;
                pictureBox1.Visible = true;
                _sound0.Play();
                _sound1.Play();
            }
            else
            {
                label6.Text = "Mal";
                xml.notes(( note.lectou), 13);
                label6.Visible = true;
                _sound2.Play();
            }
        }
    }
}
