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

namespace JeDEveile
{
    public partial class Form1 : Form
    {
        int k;
        int[] t1 = new int[5];
        int[] t2 = new int[9];
        bool DragMode = false;
        private SoundPlayer  _sound1, _sound2;

        Point InitialLocation0;
        public Form1()
        {
            InitializeComponent();
            t1 = fonctions.randomdiff(5, 6);
            t2 = fonctions.randomdiff(9, 10);
            k = t2[0];
            _sound1 = new SoundPlayer("tasfik.wav");
            _sound2 = new SoundPlayer("fechel.wav");
        }

        int b = 1;
        private void suivant_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            vrai = true;
            k = t2[b];
            pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\imagesequentiles\" + k.ToString() + @"\" + t1[0].ToString() + ".png");
            pictureBox1.Tag = t1[0];
            pictureBox2.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\imagesequentiles\" + k.ToString() + @"\" + t1[1].ToString() + ".png");
            pictureBox2.Tag = t1[1];
            pictureBox3.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\imagesequentiles\" + k.ToString() + @"\" + t1[2].ToString() + ".png");
            pictureBox3.Tag = t1[2];
            pictureBox4.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\imagesequentiles\" + k.ToString() + @"\" + t1[3].ToString() + ".png");
            pictureBox4.Tag = t1[3];
            pictureBox5.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\imagesequentiles\" + k.ToString() + @"\" + t1[4].ToString() + ".png");
            pictureBox5.Tag = t1[4];
            pictureBox1.Location = new Point(119, 65);
            pictureBox2.Location = new Point(299, 65);
            pictureBox3.Location = new Point(515, 65);
            pictureBox4.Location = new Point(705, 65);
            pictureBox5.Location = new Point(909, 65);
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();
            panel5.Controls.Clear();
            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(pictureBox4);
            this.Controls.Add(pictureBox5);
            pictureBox1.BringToFront();
            pictureBox2.BringToFront();
            pictureBox3.BringToFront();
            pictureBox4.BringToFront();
            pictureBox5.BringToFront();
            if (b < 8) b++;
            suivant.Visible = false;
            button1.Visible = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (!DragMode)
                {
                    InitialLocation0 = p.Location;
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
        bool vrai = true;
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            p.BringToFront();
            if (DragMode)
            {
                int RealX = e.X + p.Left;
                int RealY = e.Y + p.Top;
                if ((RealX > panel1.Left) && (RealX < panel1.Left + panel1.Width) && (RealY > panel1.Top) && (RealY < panel1.Top + panel1.Height))
                {
                    this.Controls.Remove(p);
                    panel1.Controls.Add(p);
                    if (p.Tag.ToString() != 1.ToString())
                    {
                        vrai = false;
                        pictureBox9.Visible = true;
                    }
                    p.Location = new Point(20, 28);
                }
                else
                if ((RealX > panel2.Left) && (RealX < panel2.Left + panel2.Width) && (RealY > panel2.Top) && (RealY < panel2.Top + panel2.Height))
                {
                    this.Controls.Remove(p);
                    panel2.Controls.Add(p);
                    if (p.Tag.ToString() != 2.ToString())
                    {
                        vrai = false;
                        pictureBox10.Visible = true;
                    }
                    p.Location = new Point(20, 28);
                }
                else
                   if ((RealX > panel3.Left) && (RealX < panel3.Left + panel3.Width) && (RealY > panel3.Top) && (RealY < panel3.Top + panel3.Height))
                {
                    this.Controls.Remove(p);
                    panel3.Controls.Add(p);
                    if (p.Tag.ToString() != 3.ToString())
                    {
                        vrai = false;
                        pictureBox11.Visible = true;
                    }
                    p.Location = new Point(20, 28);
                }
                else
                       if ((RealX > panel4.Left) && (RealX < panel4.Left + panel4.Width) && (RealY > panel4.Top) && (RealY < panel4.Top + panel4.Height))
                {
                    this.Controls.Remove(p);
                    panel4.Controls.Add(p);
                    if (p.Tag.ToString() != 4.ToString())
                    {
                        vrai = false;
                        pictureBox12.Visible = true;
                    }
                    p.Location = new Point(20, 28);
                }
                else
                          if ((RealX > panel5.Left) && (RealX < panel5.Left + panel5.Width) && (RealY > panel5.Top) && (RealY < panel5.Top + panel5.Height))
                {
                    this.Controls.Remove(p);
                    panel5.Controls.Add(p);
                    if (p.Tag.ToString() != 5.ToString())
                    {
                        vrai = false;
                        pictureBox13.Visible = true;
                    }
                    p.Location = new Point(20, 28);
                }
                else
                {
                    p.Location = InitialLocation0;
                }
                DragMode = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            suivant.Visible = false;
            pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\imagesequentiles\" + k.ToString() + @"\" + t1[0].ToString() + ".png");
            pictureBox1.Tag = t1[0];
            pictureBox2.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\imagesequentiles\" + k.ToString() + @"\" + t1[1].ToString() + ".png");
            pictureBox2.Tag = t1[1];
            pictureBox3.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\imagesequentiles\" + k.ToString() + @"\" + t1[2].ToString() + ".png");
            pictureBox3.Tag = t1[2];
            pictureBox4.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\imagesequentiles\" + k.ToString() + @"\" + t1[3].ToString() + ".png");
            pictureBox4.Tag = t1[3];
            pictureBox5.ImageLocation = (@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\pictures\imagesequentiles\" + k.ToString() + @"\" + t1[4].ToString() + ".png");
            pictureBox5.Tag = t1[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vrai == true)
            {
                pictureBox7.Visible = true;
                _sound1.Play();
            }
            else
            {
                pictureBox8.Visible = true;
                _sound2.Play();
            }
            suivant.Visible = true;
            button1.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Close();
            projet_info_II.Game g = new projet_info_II.Game();
            g.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
            _sound1.Stop();
            _sound2.Stop();
            projet_info_II.registration r = new projet_info_II.registration();
            r.Show();
        }
    }
}
