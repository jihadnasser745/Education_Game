using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace shadowss
{
    public partial class Form2 : Form
    {
        int sizex, sizey,index;
        string im,curr;
        int time = 10;
        Random r = new Random();
        PictureBox[] p;
        string[] files = Directory.GetFiles("images");
        int countt = 0, countf = 0, count = 0;
        public Form2()
        {
            InitializeComponent();
            start();
            next();
            for(int i = 0; i < 6; i++)
            {
                p[i] = new PictureBox();
                p[i].Size = new Size(100, 115);
                p[i].Left = 220 + 120 * (i % 2);
                p[i].Top = 10 + 120 * ((i ) / 2);
                //p[i].Paint += new PaintEventHandler(paint);
                p[i].BackColor = Color.Transparent;
                p[i].Tag = i + 1;
                p[i].Click += new EventHandler(click);
                pic.Controls.Add(p[i]);
                //p[i].Invalidate();
            }
            timer1.Start();
        }

        private void start()
        {
            p = new PictureBox[6];
            sizex = Screen.PrimaryScreen.WorkingArea.Size.Width;
            sizey = Screen.PrimaryScreen.WorkingArea.Size.Height;
            back.Size = new Size(sizex / 10, sizey / 15);
            main.Size = new Size((sizex * 9 / 10), (sizey * 8 / 10));
            main.Left = sizex * 5 / 10;
            main.Top = sizey / 20;
            pic.Size = new Size(450, 375);
            pic.Left = main.Width / 20;
            pic.Top = (main.Height - pic.Height) / 2;
            pic.BackColor = Color.Aqua;
            label1.Left = 3 * sizex / 5 + 100;
            label1.Top = sizey / 5 + 10;
            pictureBox1.Top =  sizey / 5;
            pictureBox1.Left = 3 * sizex / 5;
            panel2.Top = sizey / 3;
            panel2.Left= 3 * sizex / 5 - 35/2 ;
            panel2.Width = sizex/ 6;
            panel2.Height = sizey / 3 + 25/2;
            label11.Left = 100;
            label11.Top = sizey /4 - 20 ;
            label11.Height = sizey / 2;
            label12.Left = 100;
            label12.Top = sizey / 4 - 20;
            label12.Height = sizey / 2;
            label13.Left = 100;
            label13.Top = sizey / 4 - 20;
            label13.Height = sizey / 2;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = time.ToString();
            if (time <= 0)
            {
                timer1.Stop();
                label8.Text = countt.ToString();
                label9.Text = countf.ToString();
                countt =  (int)((countt * 100)/count);
                countf = countf * 100/count;
                if (countt > countf)
                {
                    label10.Text = (countt - countf).ToString() + "/100";
                    if ((countt - countf) >= 80) label13.Show();
                    if ((countt - countf) >= 50 || (countt - countf) < 80) label12.Show();
                    if ((countt - countf) < 50) label11.Show();
                }

                else
                {
                    label10.Text = "0/100";
                    label11.Show();
                }
                panel2.Show();
            }
        }
        private void next()
        {
            im = r.Next(11, 21).ToString();
            foreach (string s in files)
            {
                if (s.Substring(0, im.Length + 8) == "images\\" + im + "_")
                {
                    curr = s;
                    index = int.Parse(s.Substring(im.Length + 8, 1));
                }
            }
            pic.BackgroundImage = Image.FromFile(curr);
        }
        private void click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                PictureBox pressed = (PictureBox)sender;
                int pr = int.Parse(pressed.Tag.ToString());
                if (pr == index)
                {
                    time += 3;
                    next();
                    countt++;
                    count++;
                }
                else
                {
                    next();
                    countf++;
                    count++;
                }

            }
        }

        private void paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.Red, 3), new Rectangle(0, 0, 100, 115));
        }
    }
}
