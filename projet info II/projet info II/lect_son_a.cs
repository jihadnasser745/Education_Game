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
    public partial class lect_son_a : Form
    {
        private SoundPlayer _sound0, _sound1, _sound2;
        public lect_son_a()
        {
            InitializeComponent();
            var list = SpeechHelper.GetAllInstalledVoices();
            _sound0 = new SoundPlayer("fettech.wav");
            _sound1 = new SoundPlayer("tasfik.wav");
            _sound2 = new SoundPlayer("fechel.wav");
        }
        bool DragMode = false;
        Point InitialLocation1;
        private void lect_son_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label17.Text = xml.DonnerScore();
            label5.Visible = false;
            label6.Visible = false;
            suivant.Visible = false;
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
        int i=0,j = 5,k=5,l=0;
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if (DragMode)
            {
                int RealX = e.X + p.Left;
                int RealY = e.Y + p.Top;
                if ((RealX > panel1.Left) && (RealX < panel1.Left + panel1.Width) && (RealY > panel1.Top) && (RealY < panel1.Top + panel1.Height))
                {
                    this.Controls.Remove(p);
                    panel1.Controls.Add(p);
                    p.Location = new Point(60+j, 10+i);
                    j = j + 60;
                    i = i + 30;
                }
                else if ((RealX > panel2.Left) && (RealX < panel2.Left + panel2.Width) && (RealY > panel2.Top) && (RealY < panel2.Top + panel2.Height))
                {
                    this.Controls.Remove(p);
                    panel2.Controls.Add(p);
                    p.Location = new Point(k, 5+l);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Francais fr = new Francais();
            fr.Show();
            this.Close();
        }

        private void suivant_Click_1(object sender, EventArgs e)
        {
            lect_son_ou lso = new lect_son_ou();
            lso.Show();
            this.Close();
            _sound0.Stop();
            _sound1.Stop();
            _sound2.Stop();
        }

        private void sound_Click(object sender, EventArgs e)
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

        private void boire_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            SpeechHelper.Rate = 0;
            string error = SpeechHelper.Speak("fr-FR", "Microsoft Hortense Desktop", p.Name);
            if (error != null)
            {
                MessageBox.Show(error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suivant.Visible = true;
            if (panel1.Contains(abricot))
            {
                checkBox2.Checked = true;
                note.lecta++;
            }
            if (panel1.Contains(ballon))
            {
                checkBox6.Checked = true;
                note.lecta++;
            }
            if (panel1.Contains(sapin))
            {
                checkBox8.Checked = true;
                note.lecta++;
            }
            if (panel1.Contains(salade))
            {
                checkBox10.Checked = true;
                note.lecta++;
            }
            if (panel2.Contains(boire))
            {
                checkBox1.Checked = true;
                note.lecta++;
            }
            if (panel2.Contains(bouteille))
            {
                checkBox3.Checked = true;
                note.lecta++;
            }
            if (panel2.Contains(pomme))
            {
                checkBox4.Checked = true;
                note.lecta++;
            }
            if (panel2.Contains(poisson))
            {
                checkBox5.Checked = true;
                note.lecta++;
            }
            if (panel2.Contains(briquet))
            {
                checkBox7.Checked = true;
                note.lecta++;
            }
            if (panel2.Contains(indien))
            {
                checkBox9.Checked = true;
                note.lecta++;
            }
            if ((panel1.Contains(abricot))&& (panel1.Contains(ballon))&& (panel1.Contains(sapin))&& (panel1.Contains(salade))&& (panel2.Contains(boire))&& (panel2.Contains(bouteille))&& (panel2.Contains(pomme))&&(panel2.Contains(poisson))&& (panel2.Contains(briquet))&& (panel2.Contains(indien)))
            {
                MessageBox.Show("Bravooo!!");
            }//haydi lif zyedi bass ta ellu bravoo iza 7allun kellun
            else
            {
                if ((panel1.Contains(boire))) checkBox1.Checked = false;
                if ((panel2.Contains(abricot))) checkBox2.Checked = false;
                if ((panel1.Contains(bouteille))) checkBox3.Checked = false;
                if ((panel1.Contains(pomme))) checkBox4.Checked = false;
                if ((panel1.Contains(poisson))) checkBox5.Checked = false;
                if ((panel2.Contains(ballon))) checkBox6.Checked = false;
                if ((panel1.Contains(briquet))) checkBox7.Checked = false;
                if ((panel2.Contains(sapin))) checkBox8.Checked = false;
                if ((panel1.Contains(indien))) checkBox9.Checked = false;
                if ((panel2.Contains(salade))) checkBox10.Checked = false;
                panel1.Controls.Remove(boire);
                panel1.Controls.Remove(abricot);
                panel1.Controls.Remove(bouteille);
                panel1.Controls.Remove(pomme);
                panel1.Controls.Remove(poisson);
                panel1.Controls.Remove(ballon);
                panel1.Controls.Remove(briquet);
                panel1.Controls.Remove(sapin);
                panel1.Controls.Remove(indien);
                panel1.Controls.Remove(salade);
                panel2.Controls.Remove(boire);
                panel2.Controls.Remove(abricot);
                panel2.Controls.Remove(bouteille);
                panel2.Controls.Remove(pomme);
                panel2.Controls.Remove(poisson);
                panel2.Controls.Remove(ballon);
                panel2.Controls.Remove(briquet);
                panel2.Controls.Remove(sapin);
                panel2.Controls.Remove(indien);
                panel2.Controls.Remove(salade);
                label5.Text = note.lecta.ToString() + "/10";
                label5.Visible = true;
                if (note.lecta > 5)
                {
                    label6.Text = "good";
                    xml.notes((note.lecta ), 12);
                    label6.Visible = true;
                    pictureBox1.Visible = false;
                    _sound0.Play();
                    _sound1.Play();
                }
                else
                {
                    label6.Text = "Mal";
                    xml.notes((note.lecta), 12);
                    label6.Visible = true;
                    _sound2.Play();
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        { 
            
        }
    }
}
