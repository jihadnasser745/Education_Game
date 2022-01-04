using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class level4 : Form
    {
        DataSet ds = new DataSet();
        DataTable dt;
        int i, j4 = 0,k=0,n;
        Random r = new Random();
        int count;
        public level4()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Show();
            label7.Show();
            label6.Show();
            label5.Show();
            button5.Hide();
            button4.Hide();
            button3.Hide();
            button2.Hide();
            timer1.Stop();
            n = i;
            DataRow dr = dt.Rows[i];
            if (button2.Text.ToString() == dr["correction"].ToString().Trim())
            {
                MessageBox.Show("bravooo");
                k++;
                j4++;
            }
            else
            {
                if (i < 30)
                    MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString() + "  " + "car " + dr["demonstration"].ToString());
                else
                {
                    MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString());
                }
                k++;
            }
            if (k < 10)
                button6.Show();
            else
            {
                MessageBox.Show("cette niveau est fini avec " + j4 + "/10 la note");
                this.Close();
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Show();
            label7.Show();
            label6.Show();
            label5.Show();
            button5.Hide();
            button4.Hide();
            button3.Hide();
            button2.Hide();
            timer1.Stop();
            n = i;
            DataRow dr = dt.Rows[i];
            if (button3.Text.ToString() == dr["correction"].ToString().Trim())
            {
                MessageBox.Show("bravooo");
                k++;
                j4++;
            }
            else
            {
                if (i < 30)
                    MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString() + "  " + "car " + dr["demonstration"].ToString());
                else
                {
                    MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString());
                }
                k++;
            }
            if (k < 10)
                button6.Show();
            else
            {
                MessageBox.Show("cette niveau est fini avec " + j4 + "/10 la note");
                this.Close();
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Show();
            label7.Show();
            label6.Show();
            label5.Show();
            button5.Hide();
            button4.Hide();
            button3.Hide();
            button2.Hide();
            timer1.Stop();
            n = i;
            DataRow dr = dt.Rows[i];
            if (button4.Text.ToString() == dr["correction"].ToString().Trim())
            {
                MessageBox.Show("bravooo");
                k++;
                j4++;
            }
            else
            {
                
                    if (i < 30)
                        MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString() + "  " + "car " + dr["demonstration"].ToString());
                    else
                    {
                        MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString());
                    }
                    k++;
            }
            if (k < 10)
                button6.Show();
            else
            {
                MessageBox.Show("cette niveau est fini avec " + j4 + "/10 la note");
                this.Close();
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label8.Show();
            label7.Show();
            label6.Show();
            label5.Show();
            button5.Hide();
            button4.Hide();
            button3.Hide();
            button2.Hide();
            timer1.Stop();
            n = i;
            DataRow dr = dt.Rows[i];
            if (button5.Text.ToString() == dr["correction"].ToString().Trim())
            {
                MessageBox.Show("bravooo");
                k++;
                j4++;
            }
            else
            {if (i < 30)
                    MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString() + "  " + "car " + dr["demonstration"].ToString());
                else
                {
                    MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString());
                }
               k++;

            }
            if (k < 10)
                button6.Show();
            else
            {
                MessageBox.Show("cette niveau est fini avec " + j4 + "/10 la note");
                this.Close();
              
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            methode4();
        }
        private void methode4()
        {
            timer1.Start();
            count++;
            label4.Text = count.ToString();
            if (count == 15)
            {
                if (k == 9)
                {
                    timer1.Stop();
                    MessageBox.Show("cette niveau est fini avec " + j4 + "/10 la note");
                    this.Close();
                    
                }
                else
                {

                    timer1.Stop();
                    MessageBox.Show("pardont la time est fini");

                    k++;
                    methode1();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            methode1();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows[i];
            j4++;
            k++;
            MessageBox.Show("la reponce correct est: " + dr["correction"].ToString());
            button7.Hide();
            if (k == 10)
            {
                timer1.Stop();
                MessageBox.Show("cette niveau est fini avec " + j4 + "/10 la note");
                this.Close();

            }
            else
            {
                methode1();
            }
        }

        private void methode1()
        {
            button5.Show();
            button4.Show();
            button3.Show();
            button2.Show();
            label1.Text = "question " + (k + 1) + ":";
            do
            {
                if (k < 2)
                    i = r.Next(6, 15);
                else
                {
                    if ((k >= 2) && (k < 4))
                        i = r.Next(16, 24);
                    else
                    {
                        if ((k >= 4) && (k < 6))
                            i = r.Next(25, 30);
                        else
                            if ((k >= 6) && (k < 8))
                            i = r.Next(31, 35);
                        else
                            i = r.Next(36, 40);

                    }
                }
            } while (n == i);
            count = 0;
            timer1.Start();
            methode4();
            DataRow dr = dt.Rows[i];
            label2.Text = dr["question"].ToString();
            button5.Text = dr["chois1"].ToString().Trim();
            button2.Text = dr["chois2"].ToString().Trim();
            button3.Text = dr["chois3"].ToString().Trim();
            button4.Text = dr["chois4"].ToString().Trim();
            label5.Text = button2.Text;
            label6.Text = button3.Text;
            label7.Text = button4.Text;
            label8.Text = button5.Text;
            label8.Hide();
            label7.Hide();
            label6.Hide();
            label5.Hide();

            button6.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void level4_Load(object sender, EventArgs e)
        {
            ds.ReadXml(@"C:\Users\User\Desktop\WindowsFormsApp13\WindowsFormsApp13\bin\Debug\level4.xml");
            dt = ds.Tables[0];
            i = r.Next(1, 5);
            label1.Text = "question " + (k + 1) + ":";
            DataRow dr = dt.Rows[i];
            label2.Text = dr["question"].ToString();
            button2.Text = dr["chois1"].ToString().Trim();
            button3.Text = dr["chois2"].ToString().Trim();
            button4.Text = dr["chois3"].ToString().Trim();
            button5.Text = dr["chois4"].ToString().Trim();
            label5.Text = button2.Text;
            label6.Text = button3.Text;
            label7.Text = button4.Text;
            label8.Text = button5.Text;
            button6.Hide();
            label8.Hide();
            label7.Hide();
            label6.Hide();
            label5.Hide();
        }
    }
}
