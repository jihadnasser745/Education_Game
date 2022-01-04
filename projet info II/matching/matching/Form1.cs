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
namespace matching
{
    public partial class Form1 : Form
    {
        int w = SystemInformation.VirtualScreen.Width, h = SystemInformation.VirtualScreen.Height;
        PictureBox[] pics = new PictureBox[10];
        System.Windows.Media.MediaPlayer[] play = new System.Windows.Media.MediaPlayer[5];
        PictureBox[] points = new PictureBox[10];
        //PictureBox pp = new PictureBox();
        Random g = new Random();
        List<int> li = new List<int>(),li2=new List<int>();
        string img;
        Image cover,cover1;
        Point startpt,endpt;
        bool startdraw = false;
        StreamReader rd;
        string[] name = new string[5];
        SpeechSynthesizer reader = new SpeechSynthesizer();
        string[] names;
        int count = 0, count1 = 0;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                play[i] = new System.Windows.Media.MediaPlayer();
            }
            Start();
            
            
        }

               

        private void Start()
        {
            panel2.Left = 0;
            panel2.Top = 0;
            panel2.Width= w / 4;
            panel2.Height = h;
            panel2.Controls.Add(pictureBox2);
            pictureBox2.Height = h;
            pictureBox2.Width = w / 4;
            pictureBox2.Top = pictureBox2.Left = 0;
            panel3.Left = 3 * w / 4 ;
            panel3.Top = 0;
            panel3.Width = w / 4;
            panel3.Height = h;
            Back.Left = 0;
            Back.Top = h / 30;
            panel1.Width = w / 2;
            panel1.Height = h;
            panel1.Left = w / 4;
            panel1.Top = 0;
            panel1.Controls.Add(label1);
            label1.Top = panel1.Height - 50;
            label1.Left = panel1.Width / 4;
            Question.Left = 0;
            Question.Top = 0;
            pictureBox1.Top = h - 400;
            pictureBox1.Left = panel3.Width / 3;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel4);
            panel4.Width = panel3.Width;
            panel4.Left =0 ;
            
            panel4.Top = panel3.Height / 2;
            label4.Left = panel4.Width / 6;
            label4.Top = 0;
           
            for(int i = 0; i < 10; i++)
            {
                pics[i] = new PictureBox();
                points[i] = new PictureBox();
                pics[i].Size = new Size(165, 112);
                pics[i].BackgroundImageLayout = ImageLayout.Stretch;
                pics[i].Left = i < 5 ? (w/2-165)/12 : (w/2-165) * 11 / 12;
                pics[i].Top = (i % 5) * (h-100) / 5 + 75;
                points[i].Width = points[i].Height = 20;
                points[i].Top = pics[i].Top + (pics[i].Height - points[i].Height) / 2;
                points[i].Left = i < 5 ? pics[i].Left + 185 : pics[i].Left - 40;
                points[i].BackColor = Color.Blue;
                panel1.BackColor = Color.Aqua;
                panel1.Controls.Add(points[i]);
                panel1.Controls.Add(pics[i]);
                
            }
            rd = new StreamReader(Directory.GetCurrentDirectory() + "\\names.txt");
            names = rd.ReadToEnd().Split(' ');
            replay();
           
        }

        private void replay()
        {
            li.Clear();
            li2.Clear();
            pictureBox2.Visible = false;
            Back.BackColor = Color.Lime;
            panel4.Visible = false;
            pictureBox1.Visible = false;
            if (cover != null) cover.Dispose();
            cover = new Bitmap(panel1.Width, panel1.Height);
            using (Graphics g = Graphics.FromImage(cover))
            {
                g.FillRegion(Brushes.Aqua, new Region(new Rectangle(0, 0, panel1.Width, panel1.Height)));
            }
            panel1.BackgroundImage = cover;

            for (int i = 0; i < 5; i++)
            {
                int k, k1;
                do { k = g.Next(1, 26); } while (li.Contains(k));
                li.Add(k);
                points[i].MouseDown += new MouseEventHandler(Down);
                pics[i].BackgroundImage = Image.FromFile("1\\" + k.ToString() + ".png");

                do { k1 = g.Next(5, 10); } while (li2.Contains(k1));
                li2.Add(k1);
                points[i].Tag = i;
                points[k1].Tag = i;
                points[k1].MouseUp += new MouseEventHandler(Up);
                pics[k1].BackgroundImage = Image.FromFile("2\\" + k.ToString() + ".png");
                // play[i] = new System.Windows.Media.MediaPlayer();
                play[i].Open(new Uri(Directory.GetCurrentDirectory() + "\\3\\" + k.ToString() + ".mp3"));
                name[i] = names[k - 1];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            replay();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            projet_info_II.Game g = new projet_info_II.Game();
            g.Show();
            Close();
        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startdraw)//bool
            {
                cover = (Image)cover1.Clone(); ;
                using (Graphics g = Graphics.FromImage(cover))
                {
                    g.DrawLine(new Pen(Color.Red, 3), startpt, e.Location);
                }
                panel1.BackgroundImage=cover;
            }

        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(cover, 0, 0, panel1.Width, panel1.Height);
        }

        private void Up(object sender, MouseEventArgs e)
        {
            if (startdraw)
            {
                startdraw = false;
                PictureBox p = (PictureBox)sender;
                if (p.Tag.ToString() == img)
                {
                    endpt = new Point(p.Left + 10, p.Top + 10);
                    using (Graphics g = Graphics.FromImage(cover1))
                    {
                        g.DrawLine(new Pen(Color.Green, 3), startpt, endpt);
                    }

                    reader.SpeakAsync(name[int.Parse(img)]);
                    count++;
                    count1++;
                    //pp.Enabled = false;
                }
                else count1++;
                cover = (Image)cover1.Clone();
                panel1.BackgroundImage = cover;
                if (count == 5)
                {
                    if (count1 == 5)
                    {
                         panel4.Show();
                        label3.Text = count1.ToString();
                        pictureBox1.Show();
                        label4.Text = "PERFECT";
                        //pp.Enabled = true;
                       
                    }
                    else
                    {
                        if (count1 == 6 || count1 == 7)
                        {
                            panel4.Show();
                            label3.Text = count1.ToString();
                            pictureBox1.Show();
                            label4.Text = "GOOD";
                           // pp.Enabled = true;
                        }
                        else
                        {
                            panel4.Show();
                            label3.Text = count1.ToString();
                            pictureBox1.Show();
                            label4.Text = "GAME OVER";
                            pictureBox2.Show();
                            Back.BackColor = Color.PaleTurquoise;
                           // pp.Enabled = true;
                        }
                    }
                }
            }
        }

        private void Down(object sender, MouseEventArgs e)
        {
            startdraw = true;
            PictureBox p= (PictureBox)sender;
            img = p.Tag.ToString();
            startpt = new Point(p.Left + 10, p.Top + 10);
            cover1 = panel1.BackgroundImage;
            //pp= (PictureBox)sender;

        }
    }
}
