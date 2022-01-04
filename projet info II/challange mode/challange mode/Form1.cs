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
using System.Speech.Synthesis;
using System.Media;

namespace challange_mode
{
    public partial class Form1 : Form
    {
        int w= SystemInformation.VirtualScreen.Width, h= SystemInformation.VirtualScreen.Height,count=0;
        bool player1, player2,started=false,ready1=false,ready2=false, f1, f2;
        PictureBox p1, p2;
        int time=1;
        SpeechSynthesizer reader = new SpeechSynthesizer();
        private SoundPlayer _sound0,_sound1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            reader.Speak((5-time).ToString());
            label25.Text = (4 - time).ToString();
            if (time == 4)
            {
                newquest();
                
                timer1.Stop();
                label25.Hide();
                panel9.Visible = true;
                panel8.Show();
                p1.Visible = p2.Visible = false;
                started = true;
            }
        }

        //System.Windows.Media.MediaPlayer[] =  new System.Windows.Media.MediaPlayer[] ;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            projet_info_II.Game g = new projet_info_II.Game();
            g.Show();
            this.Close();
        }

        int count1t = 1, count1f = 1, count2t = 1, count2f = 1;
        Random g = new Random();
        int correct, false1, false2, corrindx=3;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (started)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        if (f1)
                        {
                            if (corrindx == 1) {label23.Text = (count1t++).ToString(); newquest();  }
                            else {label24.Text = (count1f++).ToString(); f1 = false; p1.Show();p1.BackgroundImage = Properties.Resources.image__12_;  }
                            label3.Text = (count1t - count1f).ToString();
                        }
                        break;
                    case Keys.L:
                        if (f2)
                        {
                            if (corrindx == 3) { newquest(); label19.Text = (count2t++).ToString(); }
                            else { f2 = false; label22.Text = (count2f++).ToString(); p2.Show(); p2.BackgroundImage = Properties.Resources.image__12_; }
                            label4.Text = (count2t - count2f).ToString();
                        }
                        break;
                    case Keys.S:
                        if (f1)
                        {
                            if (corrindx == 2) { newquest(); label23.Text = (count1t++).ToString(); }
                            else { f1 = false; label24.Text = (count1f++).ToString(); p1.Show(); p1.BackgroundImage = Properties.Resources.image__12_; }
                            label3.Text = (count1t - count1f).ToString();
                        }
                        break;
                    case Keys.K:
                        if (f2)
                        {
                            if (corrindx == 2) { newquest(); label19.Text = (count2t++).ToString(); }
                            else { f2 = false; label22.Text = (count2f++).ToString(); p2.Show(); p2.BackgroundImage = Properties.Resources.image__12_; }
                            label4.Text = (count2t - count2f).ToString();
                        }
                        break;
                    case Keys.D:
                        if (f1)
                        {
                            if (corrindx == 3) { newquest(); label23.Text = (count1t++).ToString(); }
                            else { f1 = false; label24.Text = (count1f++).ToString(); p1.Show(); p1.BackgroundImage = Properties.Resources.image__12_; }
                            label3.Text = (count1t - count1f).ToString();
                        }
                        break;
                    case Keys.J:
                        if (f2)
                        {
                            if (corrindx == 1) { newquest(); label19.Text = (count2t++).ToString(); }
                            else { f2 = false; label22.Text = (count2f++).ToString(); p2.Show(); p2.BackgroundImage = Properties.Resources.image__12_; }
                            label4.Text = (count2t - count2f).ToString();
                        }
                        break;
                }
                if (!f2 && !f1 && !timer1.Enabled) {  newquest(); }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        ready1 = true;
                        label15.Visible = false;
                        p1.BackgroundImage = Properties.Resources.image__13_;
                        p1.Show();
                        break;
                    case Keys.K:
                        ready2 = true;
                        label16.Visible = false;
                        p2.BackgroundImage = Properties.Resources.image__13_;
                        p2.Show();
                        break;
                }
                if (ready1 && ready2&&!timer1.Enabled)
                {
                   
                    
                    label25.Show();
                    timer1.Start();
                    
                }
                
            }

        }

        private void newquest()
        {
            int a, b;
            f1 = f2 = false;
            count++;
            if (count >= 3 )
            {
                f1 = f2 = false;
                if (int.Parse(label3.Text) != int.Parse(label4.Text))
                {
                    if (int.Parse(label3.Text) > int.Parse(label4.Text))
                    {
                        p1.Visible = p2.Visible = false;
                        label8.Text = "Player 1 wins";
                        reader.Speak(label8.Text);
                        pictureBox4.Show();
                        pictureBox6.Show();
                        panel8.Visible = false;
                        panel9.Visible = false;
                        _sound0.Play();
                    }//baddna nda5el aswat w....
                    else
                    {
                        p1.Visible = p2.Visible = false;
                        label8.Text = "Player 2 wins";
                        reader.Speak(label8.Text);
                        pictureBox3.Show();
                        pictureBox5.Show();
                        panel8.Visible = false;
                        panel9.Visible = false;
                        _sound0.Play();

                    }//aswat....
                }
                else
                {
                    p1.Visible = p2.Visible = false;
                    label8.Text = "Draw";   
                    reader.Speak(label8.Text);
                   
                    
                    panel8.Visible = false;
                    panel9.Visible = false;

                }//aswat.....
                label9.Visible = false;
                label10.Visible = false;
                label14.Visible = false;
            }
            else
            {
                switch (g.Next(1, 5))
                {
                    case 1:
                        a = g.Next(5, 50);
                        b = g.Next(5, 50);
                        label8.Text = "What is " + a.ToString() + " + " + b.ToString();
                        correct = a + b;
                        do { false1 = correct + g.Next(-10, 10); } while (false1 == correct);
                        do { false2 = correct + g.Next(-10, 10); } while (false2 == false1 || false2 == correct);
                        break;
                    case 2:
                        a = g.Next(21, 50);
                        b = g.Next(4, a - 10);
                        label8.Text = "What is " + a.ToString() + " - " + b.ToString();
                        correct = a - b;
                        do { false1 = correct + g.Next(-10, 10); } while (false1 == correct);
                        do { false2 = correct + g.Next(-10, 10); } while (false2 == false1 || false2 == correct);
                        break;
                    case 3:
                        a = g.Next(1, 11);
                        b = g.Next(1, 11);
                        label8.Text = "What is " + a.ToString() + " x " + b.ToString();
                        correct = a * b;
                        do { false1 = a * (b + g.Next(-2, 2)); } while (false1 == correct);
                        do { false2 = a * (b + g.Next(-2, 2)); } while (false2 == false1 || false2 == correct);
                        break;
                    case 4:
                        a = g.Next(1, 11);
                        b = g.Next(1, 11);
                        label8.Text = "What is " + (a * b).ToString() + " / " + a.ToString();
                        correct = b;
                        do { false1 = (b + g.Next(-2, 2)); } while (false1 == correct);
                        do { false2 = (b + g.Next(-2, 2)); } while (false2 == false1 || false2 == correct);
                        break;


                }
                p1.Visible = p2.Visible = false;
                label8.Left = w / 4 - label8.Width / 2;
                reader.SpeakAsync(label8.Text.Replace("/", "divided by").Replace("-", "minus").Replace("x", "times"));
                label9.Left = (w / 2 - label9.Width) / 4;
                label10.Left = (w / 2 - label10.Width) / 2;
                label14.Left = (w / 2 - label14.Width) / 4 * 3;
                switch (g.Next(0, 3))
                {
                    case 0:
                        label14.Text = correct.ToString();
                        label10.Text = false1.ToString();
                        label9.Text = false2.ToString();
                        corrindx = 3;
                        break;
                    case 1:
                        label10.Text = correct.ToString();
                        label14.Text = false1.ToString();
                        label9.Text = false2.ToString();
                        corrindx = 2;
                        break;
                    case 2:
                        label9.Text = correct.ToString();
                        label10.Text = false1.ToString();
                        label14.Text = false2.ToString();
                        corrindx = 1;
                        break;

                }
                f1 = true;
                f2 = true;
            }
            label8.Show();
            label10.Show();
            label14.Show();
            label9.Show();
            
        }

        public Form1()
        {
            InitializeComponent();
            Start();
            _sound0 = new SoundPlayer("win.wav");
        }

        private void Start()
        {
            panel1.Width = w/2;
            panel1.Height = h;
            panel1.Left = (w) / 4;
            Split.Width = 25;
            Split.Height = h / 3;
            Split.Top = h / 3 * 2;
            Split.Left = (panel1.Width - Split.Width) / 2;
            panel4.Width = panel5.Width = panel1.Width / 6;
            panel4.Left = (panel1.Width - panel4.Width) / 6;
            panel5.Left = 5*(panel1.Width - panel5.Width) / 6;
            panel4.Top = panel5.Top = Split.Top + 20;
            label8.Top = h / 5;
            label9.Top = label10.Top = label14.Top = h / 5 * 2;
            label8.Left = w / 4 - label8.Width / 2;
            label9.Left = (w / 2 - label9.Width) / 4;
            label10.Left = (w / 2 - label10.Width) / 2;
            label14.Left = (w / 2 - label14.Width) / 4 * 3;
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label14.Hide();
            // label8.AutoEllipsis = true;
            panel6.Left = 0;
            panel6.Top = 0;
            panel6.Height = h;
            panel6.Width = w / 4;
            panel7.Top = 0;
            panel7.Left = 3 * w / 4;
            panel7.Height = h;
            panel7.Width = w / 4;
            label15.Top = h / 4;
            label16.Top = h / 4;
            pictureBox2.Left = 0;
            pictureBox2.Top = 0;
            panel8.Left = 0;
            panel8.Width = w / 4;
            panel9.Width = w / 4;
            panel9.Left = 9 * (panel6.Width - panel4.Width) / 2;
            p1 = new PictureBox();
            p2 = new PictureBox();
            p1.Left = p2.Left = (panel6.Width-150)/2;
            p1.Top = p2.Top = 2*h/3-150;
            p2.BackgroundImageLayout = p1.BackgroundImageLayout = ImageLayout.Stretch;
            p1.Size = p2.Size = new Size(150, 150);
            p1.BackgroundImage = Properties.Resources.image__12_;
            p2.BackgroundImage = Properties.Resources.image__13_;
            panel6.Controls.Add(p1);
            panel7.Controls.Add(p2);
            p1.Visible = p2.Visible = false;
            label25.Left = w / 4 - label25.Width / 2;
            panel7.Controls.Add(pictureBox3);
            pictureBox3.Top = 0;
            pictureBox3.Left = 0;
            pictureBox3.Height = h;
            pictureBox3.Width = w / 4;
            panel6.Controls.Add(pictureBox4);
            pictureBox4.Top = 0;
            pictureBox4.Left = 0;
            pictureBox4.Height = h;
            pictureBox4.Width = w / 4;
            panel6.Controls.Add(pictureBox5);
            pictureBox5.Top = 0;
            pictureBox5.Left = 0;
            pictureBox5.Height = h;
            pictureBox5.Width = w / 4;
            panel7.Controls.Add(pictureBox6);
            pictureBox6.Top = 0;
            pictureBox6.Left = 0;
            pictureBox6.Height = h;
            pictureBox6.Width = w / 4;
        }
    }
}
